<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anotacoes
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
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dili = New System.Windows.Forms.RichTextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'data
        '
        Me.data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.data.Location = New System.Drawing.Point(12, 27)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(111, 22)
        Me.data.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(9, 8)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 16)
        Me.Label31.TabIndex = 114
        Me.Label31.Text = "Data"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Diligência"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dili
        '
        Me.dili.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dili.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dili.Location = New System.Drawing.Point(12, 81)
        Me.dili.Multiline = False
        Me.dili.Name = "dili"
        Me.dili.Size = New System.Drawing.Size(373, 55)
        Me.dili.TabIndex = 124
        Me.dili.Text = ""
        '
        'Label44
        '
        Me.Label44.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.BackColor = System.Drawing.Color.Maroon
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(308, 147)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(77, 23)
        Me.Label44.TabIndex = 125
        Me.Label44.Text = "Salvar"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Anotacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 176)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.dili)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.data)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(413, 215)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(413, 215)
        Me.Name = "Anotacoes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Anotação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dili As RichTextBox
    Friend WithEvents Label44 As Label
End Class
