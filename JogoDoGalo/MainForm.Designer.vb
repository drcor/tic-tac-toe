<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblNickJogador2 = New System.Windows.Forms.Label()
        Me.LblNickJogador1 = New System.Windows.Forms.Label()
        Me.PicBaseJogo = New System.Windows.Forms.PictureBox()
        Me.Pic00 = New System.Windows.Forms.PictureBox()
        Me.Pic01 = New System.Windows.Forms.PictureBox()
        Me.Pic02 = New System.Windows.Forms.PictureBox()
        Me.Pic12 = New System.Windows.Forms.PictureBox()
        Me.Pic11 = New System.Windows.Forms.PictureBox()
        Me.Pic10 = New System.Windows.Forms.PictureBox()
        Me.Pic20 = New System.Windows.Forms.PictureBox()
        Me.Pic21 = New System.Windows.Forms.PictureBox()
        Me.Pic22 = New System.Windows.Forms.PictureBox()
        Me.LblPontuacao1 = New System.Windows.Forms.Label()
        Me.LblPontuacao2 = New System.Windows.Forms.Label()
        Me.LblJogar1 = New System.Windows.Forms.Label()
        Me.LblJogar2 = New System.Windows.Forms.Label()
        Me.BtnRegras = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        CType(Me.PicBaseJogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNickJogador2
        '
        Me.LblNickJogador2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNickJogador2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNickJogador2.Location = New System.Drawing.Point(774, 127)
        Me.LblNickJogador2.Name = "LblNickJogador2"
        Me.LblNickJogador2.Size = New System.Drawing.Size(166, 28)
        Me.LblNickJogador2.TabIndex = 0
        Me.LblNickJogador2.Text = "..."
        '
        'LblNickJogador1
        '
        Me.LblNickJogador1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNickJogador1.Location = New System.Drawing.Point(26, 127)
        Me.LblNickJogador1.Name = "LblNickJogador1"
        Me.LblNickJogador1.Size = New System.Drawing.Size(166, 28)
        Me.LblNickJogador1.TabIndex = 1
        Me.LblNickJogador1.Text = "..."
        '
        'PicBaseJogo
        '
        Me.PicBaseJogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBaseJogo.BackColor = System.Drawing.Color.Transparent
        Me.PicBaseJogo.Image = Global.JogoDoGalo.My.Resources.Resources.base_jogo
        Me.PicBaseJogo.ImageLocation = ""
        Me.PicBaseJogo.Location = New System.Drawing.Point(224, 37)
        Me.PicBaseJogo.Name = "PicBaseJogo"
        Me.PicBaseJogo.Size = New System.Drawing.Size(513, 502)
        Me.PicBaseJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBaseJogo.TabIndex = 2
        Me.PicBaseJogo.TabStop = False
        '
        'Pic00
        '
        Me.Pic00.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic00.BackColor = System.Drawing.Color.Transparent
        Me.Pic00.Location = New System.Drawing.Point(224, 37)
        Me.Pic00.Name = "Pic00"
        Me.Pic00.Size = New System.Drawing.Size(170, 162)
        Me.Pic00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic00.TabIndex = 4
        Me.Pic00.TabStop = False
        '
        'Pic01
        '
        Me.Pic01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic01.BackColor = System.Drawing.Color.Transparent
        Me.Pic01.Location = New System.Drawing.Point(402, 37)
        Me.Pic01.Name = "Pic01"
        Me.Pic01.Size = New System.Drawing.Size(164, 162)
        Me.Pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic01.TabIndex = 5
        Me.Pic01.TabStop = False
        '
        'Pic02
        '
        Me.Pic02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic02.BackColor = System.Drawing.Color.Transparent
        Me.Pic02.Location = New System.Drawing.Point(574, 37)
        Me.Pic02.Name = "Pic02"
        Me.Pic02.Size = New System.Drawing.Size(163, 162)
        Me.Pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic02.TabIndex = 6
        Me.Pic02.TabStop = False
        '
        'Pic12
        '
        Me.Pic12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic12.BackColor = System.Drawing.Color.Transparent
        Me.Pic12.Location = New System.Drawing.Point(574, 206)
        Me.Pic12.Name = "Pic12"
        Me.Pic12.Size = New System.Drawing.Size(163, 154)
        Me.Pic12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic12.TabIndex = 7
        Me.Pic12.TabStop = False
        '
        'Pic11
        '
        Me.Pic11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic11.BackColor = System.Drawing.Color.Transparent
        Me.Pic11.Location = New System.Drawing.Point(402, 206)
        Me.Pic11.Name = "Pic11"
        Me.Pic11.Size = New System.Drawing.Size(164, 154)
        Me.Pic11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic11.TabIndex = 8
        Me.Pic11.TabStop = False
        '
        'Pic10
        '
        Me.Pic10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic10.BackColor = System.Drawing.Color.Transparent
        Me.Pic10.Location = New System.Drawing.Point(224, 206)
        Me.Pic10.Name = "Pic10"
        Me.Pic10.Size = New System.Drawing.Size(170, 154)
        Me.Pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic10.TabIndex = 9
        Me.Pic10.TabStop = False
        '
        'Pic20
        '
        Me.Pic20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic20.BackColor = System.Drawing.Color.Transparent
        Me.Pic20.Location = New System.Drawing.Point(224, 368)
        Me.Pic20.Name = "Pic20"
        Me.Pic20.Size = New System.Drawing.Size(170, 171)
        Me.Pic20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic20.TabIndex = 10
        Me.Pic20.TabStop = False
        '
        'Pic21
        '
        Me.Pic21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic21.BackColor = System.Drawing.Color.Transparent
        Me.Pic21.Location = New System.Drawing.Point(402, 368)
        Me.Pic21.Name = "Pic21"
        Me.Pic21.Size = New System.Drawing.Size(164, 171)
        Me.Pic21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic21.TabIndex = 11
        Me.Pic21.TabStop = False
        '
        'Pic22
        '
        Me.Pic22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic22.BackColor = System.Drawing.Color.Transparent
        Me.Pic22.Location = New System.Drawing.Point(574, 368)
        Me.Pic22.Name = "Pic22"
        Me.Pic22.Size = New System.Drawing.Size(163, 171)
        Me.Pic22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic22.TabIndex = 12
        Me.Pic22.TabStop = False
        '
        'LblPontuacao1
        '
        Me.LblPontuacao1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPontuacao1.Location = New System.Drawing.Point(26, 164)
        Me.LblPontuacao1.Name = "LblPontuacao1"
        Me.LblPontuacao1.Size = New System.Drawing.Size(54, 25)
        Me.LblPontuacao1.TabIndex = 13
        Me.LblPontuacao1.Text = "0"
        Me.LblPontuacao1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPontuacao2
        '
        Me.LblPontuacao2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPontuacao2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPontuacao2.Location = New System.Drawing.Point(774, 164)
        Me.LblPontuacao2.Name = "LblPontuacao2"
        Me.LblPontuacao2.Size = New System.Drawing.Size(54, 25)
        Me.LblPontuacao2.TabIndex = 14
        Me.LblPontuacao2.Text = "0"
        Me.LblPontuacao2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblJogar1
        '
        Me.LblJogar1.AutoSize = True
        Me.LblJogar1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJogar1.ForeColor = System.Drawing.Color.Red
        Me.LblJogar1.Location = New System.Drawing.Point(41, 287)
        Me.LblJogar1.Name = "LblJogar1"
        Me.LblJogar1.Size = New System.Drawing.Size(128, 22)
        Me.LblJogar1.TabIndex = 15
        Me.LblJogar1.Text = "Vez de jogar!"
        '
        'LblJogar2
        '
        Me.LblJogar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblJogar2.AutoSize = True
        Me.LblJogar2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJogar2.ForeColor = System.Drawing.Color.Red
        Me.LblJogar2.Location = New System.Drawing.Point(785, 287)
        Me.LblJogar2.Name = "LblJogar2"
        Me.LblJogar2.Size = New System.Drawing.Size(128, 22)
        Me.LblJogar2.TabIndex = 16
        Me.LblJogar2.Text = "Vez de jogar!"
        '
        'BtnRegras
        '
        Me.BtnRegras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegras.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegras.Location = New System.Drawing.Point(882, 12)
        Me.BtnRegras.Name = "BtnRegras"
        Me.BtnRegras.Size = New System.Drawing.Size(72, 38)
        Me.BtnRegras.TabIndex = 17
        Me.BtnRegras.Text = "Regras"
        Me.BtnRegras.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(12, 12)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(143, 29)
        Me.BtnSair.TabIndex = 18
        Me.BtnSair.Text = "Sair da partida"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 562)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnRegras)
        Me.Controls.Add(Me.LblJogar2)
        Me.Controls.Add(Me.LblJogar1)
        Me.Controls.Add(Me.LblPontuacao2)
        Me.Controls.Add(Me.LblPontuacao1)
        Me.Controls.Add(Me.Pic22)
        Me.Controls.Add(Me.Pic21)
        Me.Controls.Add(Me.Pic20)
        Me.Controls.Add(Me.Pic10)
        Me.Controls.Add(Me.Pic11)
        Me.Controls.Add(Me.Pic12)
        Me.Controls.Add(Me.Pic02)
        Me.Controls.Add(Me.Pic01)
        Me.Controls.Add(Me.Pic00)
        Me.Controls.Add(Me.PicBaseJogo)
        Me.Controls.Add(Me.LblNickJogador1)
        Me.Controls.Add(Me.LblNickJogador2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(984, 609)
        Me.MinimumSize = New System.Drawing.Size(984, 609)
        Me.Name = "MainForm"
        Me.Text = "Jogo do Galo"
        CType(Me.PicBaseJogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNickJogador2 As Label
    Friend WithEvents LblNickJogador1 As Label
    Friend WithEvents PicBaseJogo As PictureBox
    Friend WithEvents Pic00 As PictureBox
    Friend WithEvents Pic01 As PictureBox
    Friend WithEvents Pic02 As PictureBox
    Friend WithEvents Pic12 As PictureBox
    Friend WithEvents Pic11 As PictureBox
    Friend WithEvents Pic10 As PictureBox
    Friend WithEvents Pic20 As PictureBox
    Friend WithEvents Pic21 As PictureBox
    Friend WithEvents Pic22 As PictureBox
    Friend WithEvents LblPontuacao1 As Label
    Friend WithEvents LblPontuacao2 As Label
    Friend WithEvents LblJogar1 As Label
    Friend WithEvents LblJogar2 As Label
    Friend WithEvents BtnRegras As Button
    Friend WithEvents BtnSair As Button
End Class
