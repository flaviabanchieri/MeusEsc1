<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarPrazoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtpergunta = New System.Windows.Forms.ComboBox()
        Me.txtresposta = New System.Windows.Forms.TextBox()
        Me.ans = New System.Windows.Forms.Label()
        Me.ask = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.statuscb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nomelbl = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cargo = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AdicionarPrazoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1168, 24)
        Me.MenuStrip1.TabIndex = 85
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = " "
        '
        'AdicionarPrazoToolStripMenuItem
        '
        Me.AdicionarPrazoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AdicionarPrazoToolStripMenuItem.Name = "AdicionarPrazoToolStripMenuItem"
        Me.AdicionarPrazoToolStripMenuItem.Size = New System.Drawing.Size(154, 20)
        Me.AdicionarPrazoToolStripMenuItem.Text = "Configurações avançadas"
        Me.AdicionarPrazoToolStripMenuItem.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-7, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1182, 712)
        Me.TabControl1.TabIndex = 86
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1174, 686)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(43, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "MEUS DADOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtpergunta)
        Me.GroupBox3.Controls.Add(Me.txtresposta)
        Me.GroupBox3.Controls.Add(Me.ans)
        Me.GroupBox3.Controls.Add(Me.ask)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 363)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1050, 113)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recuperação de Senha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 18)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Resposta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Pergunta:"
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(907, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Salvar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(910, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Alterar Pergunta /Resposta"
        '
        'txtpergunta
        '
        Me.txtpergunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtpergunta.FormattingEnabled = True
        Me.txtpergunta.Items.AddRange(New Object() {"Nome do seu primeiro cachorro:", "Qual é a sua cor favorita?", "Nome da sua faculdade:"})
        Me.txtpergunta.Location = New System.Drawing.Point(103, 36)
        Me.txtpergunta.Name = "txtpergunta"
        Me.txtpergunta.Size = New System.Drawing.Size(161, 26)
        Me.txtpergunta.TabIndex = 43
        Me.txtpergunta.Visible = False
        '
        'txtresposta
        '
        Me.txtresposta.Location = New System.Drawing.Point(103, 71)
        Me.txtresposta.Name = "txtresposta"
        Me.txtresposta.Size = New System.Drawing.Size(161, 25)
        Me.txtresposta.TabIndex = 42
        Me.txtresposta.Visible = False
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ans.Location = New System.Drawing.Point(100, 73)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(46, 18)
        Me.ans.TabIndex = 41
        Me.ans.Text = "cargo"
        '
        'ask
        '
        Me.ask.AutoSize = True
        Me.ask.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ask.Location = New System.Drawing.Point(100, 35)
        Me.ask.Name = "ask"
        Me.ask.Size = New System.Drawing.Size(46, 18)
        Me.ask.TabIndex = 38
        Me.ask.Text = "cargo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsenha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.statuscb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.nomelbl)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cargo)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(38, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1050, 221)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações básicas"
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(101, 118)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.Size = New System.Drawing.Size(161, 25)
        Me.txtsenha.TabIndex = 35
        Me.txtsenha.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "********"
        '
        'statuscb
        '
        Me.statuscb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuscb.FormattingEnabled = True
        Me.statuscb.Items.AddRange(New Object() {"Advogado", "Secretária", "Financeiro", "Estagiário"})
        Me.statuscb.Location = New System.Drawing.Point(101, 162)
        Me.statuscb.Name = "statuscb"
        Me.statuscb.Size = New System.Drawing.Size(274, 24)
        Me.statuscb.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Senha:"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(101, 47)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(752, 25)
        Me.txtnome.TabIndex = 31
        Me.txtnome.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Cargo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 18)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Nome:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Usuário:"
        '
        'nomelbl
        '
        Me.nomelbl.AutoSize = True
        Me.nomelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomelbl.Location = New System.Drawing.Point(98, 49)
        Me.nomelbl.Name = "nomelbl"
        Me.nomelbl.Size = New System.Drawing.Size(48, 18)
        Me.nomelbl.TabIndex = 29
        Me.nomelbl.Text = "admin"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(1010, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Editar"
        '
        'cargo
        '
        Me.cargo.AutoSize = True
        Me.cargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargo.Location = New System.Drawing.Point(105, 158)
        Me.cargo.Name = "cargo"
        Me.cargo.Size = New System.Drawing.Size(46, 18)
        Me.cargo.TabIndex = 28
        Me.cargo.Text = "cargo"
        '
        'Label24
        '
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label24.Location = New System.Drawing.Point(1006, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "Salvar"
        Me.Label24.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1174, 686)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox4.Location = New System.Drawing.Point(39, 365)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1101, 221)
        Me.GroupBox4.TabIndex = 91
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Avançado"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 25)
        Me.TextBox2.TabIndex = 90
        Me.TextBox2.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 18)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Dias antes padrão:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(39, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1101, 310)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuários"
        '
        'Label23
        '
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label23.Location = New System.Drawing.Point(35, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 18)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "Voltar"
        Me.Label23.Visible = False
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1168, 700)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1184, 739)
        Me.MinimumSize = New System.Drawing.Size(1184, 739)
        Me.Name = "Usuario"
        Me.Text = "Editar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdicionarPrazoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtpergunta As ComboBox
    Friend WithEvents txtresposta As TextBox
    Friend WithEvents ans As Label
    Friend WithEvents ask As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtsenha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents statuscb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nomelbl As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cargo As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label15 As Label
End Class
