Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Public Class Cadastrar
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim i As Integer




















    'CADASTRAR
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        'salvar sql
        Dim strSql As String = ""
        Dim nome As String
        Dim usuario As String
        Dim senha As String
        Dim cargo As String
        Dim permissao As String
        Dim pergunta As String
        Dim resposta As String
        Dim data As String
        nome = nametxt.Text
        usuario = User.Text
        senha = pass.Text
        cargo = charge.Text
        pergunta = quest.Text
        resposta = Ans.Text
        If usuario = "agera" And resposta = "agera" Then
            permissao = "Administrador"
        Else
            permissao = "Usuário"
        End If
        data = Convert.ToString(DateAndTime.Now)




        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into users(NOME, USUARIO, SENHA, CARGO, PERMISSAO, PERGUNTA, RESPOSTA, CRIACAO) values ('" & nome & "','" & usuario & "','" & senha & "','" & cargo & "','" & permissao & "','" & pergunta & "','" & resposta & "','" & data & "')"
        cmd.ExecuteNonQuery()

        MsgBox("Cadastrado, por favor iniciar sessão")
        Login.Show()
        Me.Close()



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        nametxt.Clear()

        User.Clear()

        pass.Clear()

        charge.ResetText()

        quest.ResetText()

        Ans.Clear()

        Login.Show()

        Me.Close()

    End Sub
End Class