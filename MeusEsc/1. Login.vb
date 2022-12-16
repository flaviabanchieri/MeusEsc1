Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Public Class Login
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim i As Integer




    '-------VER A SENHA QUANDO SAIR DE USUÁRIO----------------------------------------------------------------------------------
    Private Sub User_Leave(sender As Object, e As EventArgs) Handles user.Leave
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()



        Try
            Dim i As String
            i = user.Text


            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from USERS where usuario = '" & i & "'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                senha2.Text = dr.GetString(1).ToString
                fundo.permissao.Text = dr.GetString(5).ToString
                fundo.nome.Text = dr.GetString(2).ToString
                fundo.usuario.Text = dr.GetString(0).ToString
            End While
        Catch
            MsgBox("Por favor entrar em contato com suporte técnico")
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Cadastrar.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If user.Text <> "" And pass.Text <> "" Then
            If pass.Text = senha2.Text Then

                Painel.Show()
                fundo.Show()
                fundo.Hide()


                Me.Close()
            Else
                incpass.Visible = True
                Label4.Visible = True

            End If

        End If
    End Sub



    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        incpass.Visible = False

        Label4.Visible = False


    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, PictureBox3.Click, PictureBox4.Click
        System.Diagnostics.Process.Start("http://banch.com.br")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        senha.Show()
        Me.Close()

    End Sub
End Class
