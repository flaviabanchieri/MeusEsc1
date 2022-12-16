Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Consulta

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If respcb.Text = fundo.nome.Text Then
            ComboBox1.Visible = True
            Label3.Visible = False
        End If




    End Sub

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fundo.permissao.Text = "Administrador" Then
            Label32.Visible = True
            Label2.Visible = True


        End If

        If provresp.Text = fundo.nome.Text Then
            provanot.Visible = True
            Label6.Visible = True
        End If
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

        If Application.OpenForms().OfType(Of Agenda).Any Then
            DadosAlt.Show()
            DadosAlt.Label32.Text = "Remarcar"
            DadosAlt.diasprazoud.Text = diasprazoud.Text
            DadosAlt.respcb.Text = respcb.Text
            DadosAlt.partetxt.Text = partetxt.Text
            DadosAlt.diltxt.Text = diltxt.Text
            DadosAlt.TextBox2.Text = textbox2.Text
            Me.Close()
            Agenda.Close()
        Else
            DadosAlt.Show()
            DadosAlt.Label32.Text = "Remarcar"
            DadosAlt.diasprazoud.Text = diasprazoud.Text
            DadosAlt.respcb.Text = respcb.Text
            DadosAlt.partetxt.Text = partetxt.Text
            DadosAlt.diltxt.Text = diltxt.Text
            DadosAlt.TextBox2.Text = textbox2.Text
            Me.Close()

        End If










    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir este prazo permanentemente?", "Apagar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                Dim idint As Integer
                idint = Convert.ToInt32(idtxt.Text)

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from DadosPrazos1 where id = '" & idint & "'"
                cmd.ExecuteNonQuery()

                Call DadosAlt.display_dados()
                Call Painel.Prazos()
                Call Agenda.display_agenda_dia()

            Catch
                MsgBox("Selecionar prazo a ser apagado")
            End Try
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim idint As Integer
            idint = Convert.ToInt32(idtxt.Text)

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update dadosprazos1 set situacao = '" & ComboBox1.Text & "' where id = '" & idint & "'"
            cmd.ExecuteNonQuery()

            Call DadosAlt.display_dados()
            Call Painel.Prazos()
            Call Agenda.display_agenda_dia()

        Catch
            MsgBox("Feche a aba e tente novamente")
        End Try

        Label3.Visible = True
        statuscb.Text = ComboBox1.Text
        ComboBox1.Visible = False

    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir esta providência permanentemente?", "Apagar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                Dim idint As Integer
                idint = Convert.ToInt32(Label7.Text)

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from providencias where id = '" & idint & "'"
                cmd.ExecuteNonQuery()

                Call DadosAlt.display_dados()
                Call Painel.Prazos()
                Call Agenda.display_agenda_dia()

            Catch
                MsgBox("Selecionar providência a ser apagada")
            End Try
        End If
    End Sub


    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

        If respcb.Text = fundo.nome.Text Then
            ComboBox2.Visible = True
             Label14.Visible = False
        End If





    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim idint As Integer
            idint = Convert.ToInt32(idtxt.Text)

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update providencias set situacao = '" & ComboBox2.Text & "' where id = '" & idint & "'"
            cmd.ExecuteNonQuery()

            Call DadosAlt.display_dados()
            Call Painel.Prazos()
            Call Agenda.display_agenda_dia()

        Catch
            MsgBox("Feche a aba e tente novamente")
        End Try

        Label14.Visible = True
        statuscb.Text = ComboBox2.Text
        ComboBox2.Visible = False
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim idint As Integer
            idint = Convert.ToInt32(idtxt.Text)

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update providencias set anotacoes = '" & provanot.Text & "' where id = '" & idint & "'"
            cmd.ExecuteNonQuery()

            Call DadosAlt.display_dados()
            Call Painel.Prazos()
            Call Agenda.display_agenda_dia()

        Catch
            MsgBox("Feche a aba e tente novamente")
        End Try
    End Sub
End Class