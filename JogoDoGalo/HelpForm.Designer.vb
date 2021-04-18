<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Me.BtnContinuar = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblRules = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnContinuar
        '
        Me.BtnContinuar.Location = New System.Drawing.Point(241, 400)
        Me.BtnContinuar.Name = "BtnContinuar"
        Me.BtnContinuar.Size = New System.Drawing.Size(117, 38)
        Me.BtnContinuar.TabIndex = 0
        Me.BtnContinuar.Text = "Ir para o jogo"
        Me.BtnContinuar.UseVisualStyleBackColor = True
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo.Location = New System.Drawing.Point(44, 23)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(62, 23)
        Me.LblTitulo.TabIndex = 3
        Me.LblTitulo.Text = "Regras"
        '
        'LblRules
        '
        Me.LblRules.Location = New System.Drawing.Point(44, 61)
        Me.LblRules.Name = "LblRules"
        Me.LblRules.Size = New System.Drawing.Size(533, 301)
        Me.LblRules.TabIndex = 4
        Me.LblRules.Text = "..."
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblRules)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnContinuar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(637, 497)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(637, 497)
        Me.Name = "HelpForm"
        Me.Text = "Regras do jogo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnContinuar As Button
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblRules As Label
End Class
