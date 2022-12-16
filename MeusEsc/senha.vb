
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class senha


    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub user_Leave(sender As Object, e As EventArgs) Handles user.Leave


        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()



        Try
            Dim i As String
            i = user.Text

            Label5.Text = i

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
                Label4.Text = dr.GetString(3).ToString
                TextBox1.Text = dr.GetString(4).ToString


            End While

        Catch
            MsgBox("Por favor entrar em contato com suporte técnico")
        End Try







        Label2.Visible = True
        pass.Visible = True




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pass.Text = TextBox1.Text And pass.Text <> "" Then
            TextBox2.Visible = True

            TextBox3.Visible = True
            user.Visible = False
            Label2.Visible = False
            pass.Visible = False
            Label4.Text = "Repetir senha"
            Label1.Text = "Nova senha"
            Button1.Visible = False
            Button2.Visible = True

        Else
            MsgBox("Resposta não confere, entrar em contato com suporte técnico de banch")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        If TextBox2.Text = TextBox3.Text And TextBox3.Text <> "" Then


            Try
                Dim i As String
                i = Label5.Text

                Dim senhas As String
                senhas = TextBox3.Text



                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update USERS set senha = '" & senhas & "' where usuario = '" & i & "'"
                cmd.ExecuteNonQuery()


                Login.Show()
                Me.Close()

            Catch
                MsgBox("Por favor entrar em contato com suporte técnico")
            End Try

        Else
            incpass.Visible = True
            TextBox3.BackColor = Color.LightCoral
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If user.Text <> "" Then
            Button1.Visible = True
            Button3.Visible = False
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Login.Show()
        Me.Close()
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        user.ResetText()
        pass.ResetText()

    End Sub
End Class