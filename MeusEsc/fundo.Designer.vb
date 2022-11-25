<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fundo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nome = New System.Windows.Forms.Label()
        Me.permissao = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nome
        '
        Me.nome.AutoSize = True
        Me.nome.Location = New System.Drawing.Point(131, 103)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(33, 13)
        Me.nome.TabIndex = 5
        Me.nome.Text = "nome"
        '
        'permissao
        '
        Me.permissao.AutoSize = True
        Me.permissao.Location = New System.Drawing.Point(131, 79)
        Me.permissao.Name = "permissao"
        Me.permissao.Size = New System.Drawing.Size(54, 13)
        Me.permissao.TabIndex = 4
        Me.permissao.Text = "permissao"
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Location = New System.Drawing.Point(131, 57)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(41, 13)
        Me.usuario.TabIndex = 3
        Me.usuario.Text = "usuario"
        '
        'fundo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 172)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.permissao)
        Me.Controls.Add(Me.usuario)
        Me.Name = "fundo"
        Me.Text = "fundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nome As Label
    Friend WithEvents permissao As Label
    Friend WithEvents usuario As Label
End Class
