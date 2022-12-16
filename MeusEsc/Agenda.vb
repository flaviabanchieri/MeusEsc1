Imports System.Data.SqlClient
Imports System.Globalization
Public Class Agenda

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand



    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Longdate As String = datapick.Value.ToLongDateString
        Dim monthString As String = Longdate.Split(" "c)(3)
        titulo.Text = "Prazos"
        Label1.Text = datapick.Value.Day.ToString
        Label2.Text = monthString
        Label3.Text = datapick.Value.Year.ToString
        datapick.Visible = False
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
        semana()
        If l1.Text = DateTime.Now.ToShortDateString Then
            Label29.ForeColor = Color.Red
            seg.ForeColor = Color.Red
        ElseIf l2.Text = DateTime.Now.ToShortDateString Then
            Label30.ForeColor = Color.Red
            ter.ForeColor = Color.Red
        ElseIf l3.Text = DateTime.Now.ToShortDateString Then
            Label31.ForeColor = Color.Red
            quar.ForeColor = Color.Red
        ElseIf l4.Text = DateTime.Now.ToShortDateString Then
            Label32.ForeColor = Color.Red
            qui.ForeColor = Color.Red
        ElseIf l5.Text = DateTime.Now.ToShortDateString Then
            Label33.ForeColor = Color.Red
            sex.ForeColor = Color.Red
        ElseIf l6.Text = DateTime.Now.ToShortDateString Then
            Label40.ForeColor = Color.Red
            sab.ForeColor = Color.Red
        ElseIf l7.Text = DateTime.Now.ToShortDateString Then
            Label41.ForeColor = Color.Red
            dom.ForeColor = Color.Red

        End If

        display_agenda_dia()
        tabela_arrumada()

        Label44.Text = "prazos"





    End Sub


    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "Dia" Then
            Agendados.SelectTab(0)
            display_agenda_dia()

        Else
            Agendados.SelectTab(1)
            display_agenda_semana()
            tabela_arrumada()

        End If



    End Sub



    Public Function tabela_arrumada()

        If titulo.Text = "Prazos" Then
            Me.DataGridView1.Columns("Prazo").Visible = False
            Me.DataGridView1.Columns("Processo").HeaderText = "Processo"
            Me.DataGridView1.Columns("Diligencia").HeaderText = "Diligência"
            Me.DataGridView1.Columns("situacao").HeaderText = "Situação"
            Me.DataGridView1.Columns("responsavel").HeaderText = "Responsável"
            Me.DataGridView1.Columns("Parte").HeaderText = "Parte"
            Me.DataGridView1.Columns("Fatal").HeaderText = "Prazo Fatal"





        ElseIf titulo.Text = "Audiências" Then
            Me.DataGridView1.Columns("Data").Visible = False
            Me.DataGridView1.Columns("horamin").Visible = False
            Me.DataGridView1.Columns("minuto").Visible = False
            Me.DataGridView1.Columns("Processo").HeaderText = "Processo"
            Me.DataGridView1.Columns("anotacao").HeaderText = "Anotação"
            Me.DataGridView1.Columns("Parte").HeaderText = "Parte"
            Me.DataGridView1.Columns("Responsavel").HeaderText = "Responsável"
            Me.DataGridView1.Columns("Vara").HeaderText = "Vara"
            Me.DataGridView1.Columns("Sala").HeaderText = "Sala"
            Me.DataGridView1.Columns("hora").HeaderText = "Hora"
        ElseIf titulo.Text = "Atendimentos" Then
            Me.DataGridView1.Columns("Data").Visible = False
            Me.DataGridView1.Columns("horamin").Visible = False
            Me.DataGridView1.Columns("minuto").Visible = False
            Me.DataGridView1.Columns("hora").HeaderText = "Hora"
            Me.DataGridView1.Columns("parte").HeaderText = "Parte"
            Me.DataGridView1.Columns("processo").HeaderText = "Processo"
            Me.DataGridView1.Columns("anotacao").HeaderText = "Anotação"
        ElseIf titulo.Text = "Providências" Then
            Me.DataGridView1.Columns("Data").Visible = False
            Me.DataGridView1.Columns("Processo").HeaderText = "Processo"
            Me.DataGridView1.Columns("anotacoes").HeaderText = "Anotação"
            Me.DataGridView1.Columns("Parte").HeaderText = "Parte"
            Me.DataGridView1.Columns("Responsavel").HeaderText = "Responsável"
            Me.DataGridView1.Columns("diligencia").HeaderText = "Diligências"
            Me.DataGridView1.Columns("situacao").HeaderText = "Situação"
        End If
    End Function

    Public Function display_agenda_dia()
        Dim data As String
        data = Format(datapick.Value, "dd/MM/yyyy")

        Select Case titulo.Text
            Case "Prazos"


                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select ROW_NUMBER() OVER(ORDER BY prazo ASC) AS Item, RESPONSAVEL, PROCESSO, PARTE, DILIGENCIA, SITUACAO, PRAZO, FATAL from DadosPrazos1 WHERE PRAZO = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt





            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, responsavel, parte, processo, vara, sala, anotacao from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt





            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte, processo, anotacao from Atendimento WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt



            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt


        End Select
    End Function









    '=====================AGENDA DIA=============================================================================
    '============================================================================================================




    '===========================DATAPICK==========================================================================
    Private Sub Datapick_ValueChanged(sender As Object, e As EventArgs) Handles datapick.ValueChanged
        Dim Longdate As String = datapick.Value.ToLongDateString
        Dim monthString As String = Longdate.Split(" "c)(3)
        Label1.Text = datapick.Value.Day.ToString
        Label2.Text = monthString
        Label3.Text = datapick.Value.Year.ToString
        datapick.Visible = False
        display_agenda_dia()
        tabela_arrumada()



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click
        If datapick.Visible = True Then
            datapick.Visible = False
        Else
            datapick.Visible = True

        End If

        datapick.Focus()
        SendKeys.Send("{F4}")


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim menos As Date
        menos = datapick.Value.AddDays(-1)
        datapick.Value = menos
        display_agenda_dia()
        tabela_arrumada()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim add As Date
        add = datapick.Value.AddDays(1)
        datapick.Value = add
        display_agenda_dia()
        tabela_arrumada()

    End Sub



    'FUNCÕES MENU

    Public Sub audiencia_menu()
        titulo.Text = "Audiências"
        Label44.Text = titulo.Text

        Agendados.SelectTab(0)
        ComboBox4.Text = "Dia"
        display_agenda_dia()
        tabela_arrumada()

    End Sub

    Public Sub prazos_menu()
        titulo.Text = "Prazos"
        Label44.Text = titulo.Text
        Agendados.SelectTab(0)
        ComboBox4.Text = "Dia"
        display_agenda_dia()
        tabela_arrumada()

    End Sub

    Public Sub atendimento_menu()
        titulo.Text = "Atendimentos"
        Label44.Text = titulo.Text
        Agendados.SelectTab(0)
        ComboBox4.Text = "Dia"
        display_agenda_dia()
        tabela_arrumada()

    End Sub

    Public Sub providencias_menu()
        titulo.Text = "Providências"
        Label44.Text = titulo.Text
        Agendados.SelectTab(0)
        ComboBox4.Text = "Dia"
        display_agenda_dia()
        tabela_arrumada()

    End Sub


    '========================MENU VER======================================================
    Private Sub PrazoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrazoToolStripMenuItem.Click
        prazos_menu()

    End Sub

    Private Sub AudienciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudienciasToolStripMenuItem.Click
        audiencia_menu()

    End Sub

    Private Sub AtendimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtendimentoToolStripMenuItem.Click
        atendimento_menu()

    End Sub



    Private Sub ProvidênciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvidênciasToolStripMenuItem.Click
        providencias_menu()

    End Sub









    Public Sub cor_semana()
        Label29.ForeColor = Color.DimGray
        seg.ForeColor = Color.DimGray

        Label30.ForeColor = Color.DimGray
        ter.ForeColor = Color.DimGray

        Label31.ForeColor = Color.DimGray
        quar.ForeColor = Color.DimGray

        Label32.ForeColor = Color.DimGray
        qui.ForeColor = Color.DimGray

        Label33.ForeColor = Color.DimGray
        sex.ForeColor = Color.DimGray

        Label40.ForeColor = Color.DimGray
        sab.ForeColor = Color.DimGray

        Label41.ForeColor = Color.DimGray
        dom.ForeColor = Color.DimGray
        If l1.Text = DateTime.Now.ToShortDateString Then
            Label29.ForeColor = Color.Red
            seg.ForeColor = Color.Red
        ElseIf l2.Text = DateTime.Now.ToShortDateString Then
            Label30.ForeColor = Color.Red
            ter.ForeColor = Color.Red
        ElseIf l3.Text = DateTime.Now.ToShortDateString Then
            Label31.ForeColor = Color.Red
            quar.ForeColor = Color.Red
        ElseIf l4.Text = DateTime.Now.ToShortDateString Then
            Label32.ForeColor = Color.Red
            qui.ForeColor = Color.Red
        ElseIf l5.Text = DateTime.Now.ToShortDateString Then
            Label33.ForeColor = Color.Red
            sex.ForeColor = Color.Red
        ElseIf l6.Text = DateTime.Now.ToShortDateString Then
            Label40.ForeColor = Color.Red
            sab.ForeColor = Color.Red
        ElseIf l7.Text = DateTime.Now.ToShortDateString Then
            Label41.ForeColor = Color.Red
            dom.ForeColor = Color.Red

        End If
    End Sub


    Private Function semana()
        TextBox2.Text = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTimePicker1.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
        TextBox3.Text = DateTimePicker1.Value.Year


        Dim first As DateTime = FirstDateOfWeek(Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox2.Text))
        seg.Text = first.Day.ToString
        ter.Text = first.AddDays(1).Day
        quar.Text = first.AddDays(2).Day
        qui.Text = first.AddDays(3).Day
        sex.Text = first.AddDays(4).Day
        sab.Text = first.AddDays(5).Day
        dom.Text = first.AddDays(6).Day
        l1.Text = first
        l2.Text = first.AddDays(1)
        l3.Text = first.AddDays(2)
        l4.Text = first.AddDays(3)
        l5.Text = first.AddDays(4)
        l6.Text = first.AddDays(5)
        l7.Text = first.AddDays(6)


    End Function







    '=================================AGENDA SEMANA



    Public Function FirstDateOfWeek(ByVal Year As Integer, ByVal Week As Integer, Optional FirstDayOfWeek As DayOfWeek = DayOfWeek.Monday) As Date
        Dim dt As Date = New Date(Year, 1, 1)
        If dt.DayOfWeek > 4 Then dt = dt.AddDays(7 - dt.DayOfWeek) Else dt = dt.AddDays(-dt.DayOfWeek)
        dt = dt.AddDays(FirstDayOfWeek)
        Return dt.AddDays(7 * (Week - 1))
    End Function

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim menos As Date
        menos = DateTimePicker1.Value.AddDays(-7)
        DateTimePicker1.Value = menos
        semana()
        cor_semana()
        display_agenda_semana()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim menos As Date
        menos = DateTimePicker1.Value.AddDays(7)
        DateTimePicker1.Value = menos

        semana()
        cor_semana()
        display_agenda_semana()
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged


        semana()
        cor_semana()
        display_agenda_semana()
    End Sub

    Private Sub PrazoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrazoToolStripMenuItem1.Click
        If fundo.permissao.Text = "Administrador" Then
            DadosAlt.Show()
            DadosAlt.prazo_dados()
            Me.Close()
        Else
            MsgBox("Precisa permissão de administrador")
        End If



    End Sub

    Private Sub AudiênciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudiênciaToolStripMenuItem.Click
        If fundo.permissao.Text = "Administrador" Then
            DadosAlt.Show()
            DadosAlt.audiencias_dados()
            Me.Close()
        Else
            MsgBox("Precisa permissão de administrador")
        End If
    End Sub

    Private Sub AtendimentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtendimentoToolStripMenuItem1.Click

        DadosAlt.Show()
            DadosAlt.atendimento_dados()
            Me.Close()


    End Sub

    Private Sub ProvidênciasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProvidênciasToolStripMenuItem1.Click
        If fundo.permissao.Text = "Administrador" Then
            DadosAlt.Show()
            DadosAlt.providencias_dados()
            Me.Close()
        Else
            MsgBox("Precisa permissão de administrador")
        End If
    End Sub









    'BUTTONS ============================================











    '========================================= AGENDA SEMANA



    Public Function display_agenda_segunda()
        Dim data As String
        data = l1.Text

        Select Case titulo.Text
            Case "Prazos"


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
                segunda.DataSource = dt
                Me.segunda.Columns("Prazo").Visible = False
                Me.segunda.Columns("Diligencia").HeaderText = "Diligência"
                Me.segunda.Columns("Parte").HeaderText = "Parte"


            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, horamin, minuto, hora, parte from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                segunda.DataSource = dt
                Me.segunda.Columns("data").Visible = False
                Me.segunda.Columns("horamin").Visible = False
                Me.segunda.Columns("minuto").Visible = False



            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Atendimento WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                segunda.DataSource = dt
                Me.segunda.Columns("data").Visible = False
                Me.segunda.Columns("horamin").Visible = False
                Me.segunda.Columns("minuto").Visible = False

                Me.segunda.Columns("anotacao").HeaderText = "Anotação"


            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, responsavel, diligencia from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                segunda.DataSource = dt
                Me.segunda.Columns("data").Visible = False


                Me.segunda.Columns("diligencia").HeaderText = "Diligências"


        End Select
    End Function

    Public Function display_agenda_terca()
        Dim data As String
        data = l2.Text

        Select Case titulo.Text
            Case "Prazos"


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
                terca.DataSource = dt

                Me.terca.Columns("Prazo").Visible = False
                Me.terca.Columns("Diligencia").HeaderText = "Diligência"
                Me.terca.Columns("Parte").HeaderText = "Parte"


            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                terca.DataSource = dt
                Me.terca.Columns("data").Visible = False
                Me.terca.Columns("horamin").Visible = False
                Me.terca.Columns("minuto").Visible = False



            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Atendimentos WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                terca.DataSource = dt
                Me.terca.Columns("data").Visible = False
                Me.terca.Columns("horamin").Visible = False
                Me.terca.Columns("minuto").Visible = False

                Me.terca.Columns("anotacao").HeaderText = "Anotação"


            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, responsavel, diligencia from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                terca.DataSource = dt
                Me.terca.Columns("data").Visible = False


                Me.terca.Columns("diligencia").HeaderText = "Diligências"


        End Select
    End Function

    Public Function display_agenda_quarta()
        Dim data As String
        data = l3.Text

        Select Case titulo.Text
            Case "Prazos"


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
                quarta.DataSource = dt

                Me.quarta.Columns("Prazo").Visible = False
                Me.quarta.Columns("Diligencia").HeaderText = "Diligência"
                Me.quarta.Columns("Parte").HeaderText = "Parte"


            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                quarta.DataSource = dt
                Me.quarta.Columns("data").Visible = False
                Me.quarta.Columns("horamin").Visible = False
                Me.quarta.Columns("minuto").Visible = False



            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Atendimentos WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                quarta.DataSource = dt
                Me.quarta.Columns("data").Visible = False
                Me.quarta.Columns("horamin").Visible = False
                Me.quarta.Columns("minuto").Visible = False

                Me.quarta.Columns("anotacao").HeaderText = "Anotação"


            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, responsavel, diligencia from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                quarta.DataSource = dt
                Me.quarta.Columns("data").Visible = False


                Me.quarta.Columns("diligencia").HeaderText = "Diligências"


        End Select
    End Function

    Public Function display_agenda_quinta()
        Dim data As String
        data = l4.Text

        Select Case titulo.Text
            Case "Prazos"


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
                quinta.DataSource = dt

                Me.quinta.Columns("Prazo").Visible = False
                Me.quinta.Columns("Diligencia").HeaderText = "Diligência"
                Me.quinta.Columns("Parte").HeaderText = "Parte"


            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                quinta.DataSource = dt
                Me.quinta.Columns("data").Visible = False
                Me.quinta.Columns("horamin").Visible = False
                Me.quinta.Columns("minuto").Visible = False


            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Atendimentos WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                quinta.DataSource = dt
                Me.quinta.Columns("data").Visible = False
                Me.quinta.Columns("horamin").Visible = False
                Me.quinta.Columns("minuto").Visible = False

                Me.quinta.Columns("anotacao").HeaderText = "Anotação"


            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, responsavel, diligencia from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                quinta.DataSource = dt
                Me.quinta.Columns("data").Visible = False


                Me.quinta.Columns("diligencia").HeaderText = "Diligências"


        End Select
    End Function

    Public Function display_agenda_sexta()
        Dim data As String
        data = l5.Text

        Select Case titulo.Text
            Case "Prazos"


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
                sexta.DataSource = dt

                Me.sexta.Columns("Prazo").Visible = False
                Me.sexta.Columns("Diligencia").HeaderText = "Diligência"
                Me.sexta.Columns("Parte").HeaderText = "Parte"


            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                sexta.DataSource = dt
                Me.sexta.Columns("data").Visible = False
                Me.sexta.Columns("horamin").Visible = False
                Me.sexta.Columns("minuto").Visible = False



            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Atendimentos WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                sexta.DataSource = dt
                Me.sexta.Columns("data").Visible = False
                Me.quinta.Columns("horamin").Visible = False
                Me.quinta.Columns("minuto").Visible = False

                Me.sexta.Columns("anotacao").HeaderText = "Anotação"


            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, responsavel, diligencia from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                sexta.DataSource = dt
                Me.sexta.Columns("data").Visible = False


                Me.sexta.Columns("diligencia").HeaderText = "Diligências"


        End Select
    End Function
    Public Function display_agenda_sabado()
        Dim data As String
        data = l6.Text

        Select Case titulo.Text
            Case "Prazos"


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
                sabado.DataSource = dt

                Me.sabado.Columns("Prazo").Visible = False
                Me.sabado.Columns("Diligencia").HeaderText = "Diligência"
                Me.sabado.Columns("Parte").HeaderText = "Parte"


            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                sabado.DataSource = dt
                Me.sabado.Columns("data").Visible = False
                Me.sabado.Columns("horamin").Visible = False
                Me.sabado.Columns("minuto").Visible = False



            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Atendimentos WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                sabado.DataSource = dt
                Me.sabado.Columns("data").Visible = False
                Me.sabado.Columns("horamin").Visible = False
                Me.sabado.Columns("minuto").Visible = False

                Me.sabado.Columns("anotacao").HeaderText = "Anotação"


            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, responsavel, diligencia from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                sabado.DataSource = dt
                Me.sabado.Columns("data").Visible = False


                Me.sabado.Columns("diligencia").HeaderText = "Diligências"


        End Select
    End Function
    Public Function display_agenda_domingo()
        Dim data As String
        data = l7.Text

        Select Case titulo.Text
            Case "Prazos"


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
                domingo.DataSource = dt

                Me.domingo.Columns("Prazo").Visible = False
                Me.domingo.Columns("Diligencia").HeaderText = "Diligência"
                Me.domingo.Columns("Parte").HeaderText = "Parte"


            Case "Audiências"

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Audiencias WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                domingo.DataSource = dt
                Me.domingo.Columns("data").Visible = False
                Me.domingo.Columns("horamin").Visible = False
                Me.domingo.Columns("minuto").Visible = False


            Case "Atendimentos"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, hora, horamin, minuto, parte from Atendimentos WHERE data = '" & data & "' order by horamin desc, minuto"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                domingo.DataSource = dt
                Me.domingo.Columns("data").Visible = False
                Me.domingo.Columns("horamin").Visible = False
                Me.domingo.Columns("minuto").Visible = False

                Me.domingo.Columns("anotacao").HeaderText = "Anotação"


            Case "Providências"
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select data, responsavel, diligencia from Providencias WHERE data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                domingo.DataSource = dt
                Me.domingo.Columns("data").Visible = False


                Me.domingo.Columns("diligencia").HeaderText = "Diligências"


        End Select
    End Function


    Public Function display_agenda_semana()
        display_agenda_segunda()
        display_agenda_terca()
        display_agenda_quarta()
        display_agenda_quinta()
        display_agenda_sexta()
        display_agenda_sabado()
        display_agenda_domingo()

    End Function



    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        agendabtn.Visible = True
        painelbtn.Visible = True


        PictureBox1.Visible = True
        PictureBox14.Visible = True
        Menu.Visible = True
        PictureBox15.Visible = True
        PictureBox17.Visible = False
        PictureBox16.Visible = False
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        agendabtn.Visible = False
        painelbtn.Visible = False


        PictureBox14.Visible = False
        PictureBox1.Visible = False
        Menu.Visible = False
        PictureBox15.Visible = False
        PictureBox17.Visible = True
        PictureBox16.Visible = True
    End Sub
    Private Sub painelbtn_Click(sender As Object, e As EventArgs) Handles painelbtn.Click
        Painel.Show()
        Me.Close()

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Login.Show()
        Me.Close()
        fundo.Close()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Usuario.Show()
        Me.Close()
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If titulo.Text = "Prazos" Then



            TextBox2.Visible = True

            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            Dim i As String
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())


            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from dadosprazos1 where id = '" & i & "'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                Consulta.idtxt.Text = dr.GetInt32(0)
                Consulta.diasprazoud.Text = dr.GetInt32(3)
                Consulta.dprazofatal.Text = dr.GetString(5).ToString
                Consulta.ddataprazo.Text = dr.GetString(4).ToString
                Consulta.respcb.Text = dr.GetString(1).ToString
                Consulta.partetxt.Text = dr.GetString(7).ToString
                Consulta.statuscb.Text = dr.GetString(9).ToString
                Consulta.diltxt.Text = dr.GetString(8).ToString
                Consulta.textbox2.Text = dr.GetString(6).ToString
                Consulta.datapubtxt.Text = dr.GetString(2).ToString
            End While

            Consulta.ShowDialog()
        End If
    End Sub


End Class