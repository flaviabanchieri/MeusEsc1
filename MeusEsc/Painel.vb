Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Public Class Painel
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub Painel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = DateTimePicker1.Value.ToShortDateString
        Prazos()
        audiencias()
        anotacao()
        Label7.Text = "Bem-vindo, " + fundo.nome.Text



    End Sub


    Public Sub Prazos()
        Dim data As String

        data = Format(DateTimePicker1.Value, "dd/MM/yyyy")

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()



        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select ROW_NUMBER() OVER(ORDER BY prazo ASC) AS Item, PARTE, DILIGENCIA, PRAZO from DadosPrazos1 WHERE PRAZO = '" & data & "'"

        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        Me.DataGridView1.Columns("Prazo").Visible = False
        Me.DataGridView1.Columns("Parte").HeaderText = "Parte"
        Me.DataGridView1.Columns("Diligencia").HeaderText = "Diligência"

    End Sub

    Public Sub audiencias()
        Dim data As String

        data = Format(DateTimePicker1.Value, "dd/MM/yyyy")

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()



        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Hora, parte from audiencias WHERE data = '" & data & "'"

        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView3.DataSource = dt




    End Sub


    Public Sub anotacao()
        Dim data As String

        data = Format(DateTimePicker1.Value, "dd/MM/yyyy")

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()



        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select data, diligencia from anotacoes order by data desc"

        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView5.DataSource = dt
    End Sub


































    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Agenda.Show()
        Me.Close()

    End Sub




    Private Sub DataGridView1_doubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Agenda.Show()
        Me.Close()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        agendabtn.Visible = True
        painelbtn.Visible = True

        PictureBox4.Visible = True
        PictureBox5.Visible = True
        Menu.Visible = True
        PictureBox3.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        agendabtn.Visible = False
        painelbtn.Visible = False


        PictureBox4.Visible = False
        PictureBox5.Visible = False
        Menu.Visible = False
        PictureBox3.Visible = False
        PictureBox1.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub agendabtn_Click(sender As Object, e As EventArgs) Handles agendabtn.Click
        Agenda.Show()
        Me.Close()

    End Sub


    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Anotacoes.ShowDialog()


    End Sub
    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If My.Application.OpenForms.Count = 1 Then
                For Each f As Form In My.Application.OpenForms
                    f.Close()
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView3_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView3.DoubleClick

        Agenda.Show()

        Agenda.audiencia_menu()

        Me.Close()



    End Sub
End Class