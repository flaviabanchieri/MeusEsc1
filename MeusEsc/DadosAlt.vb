Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Data
Imports System.Drawing.Printing
Imports System.Linq
Imports Nager.Date
Imports System.Globalization

''' <summary>
''' Contains methods that extend the <see cref="DateTime"/> structure.
''' </summary>
Public Module DateTimeExtensions

    Private Function feriado(OrderDate As DateTime) As Boolean
        Dim salesStrt As New DateTime(OrderDate.Year, 12, 20)




        If OrderDate >= salesStrt Then
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' Gets a value indicating whether a <see cref="DateTime"/> value represents a week day.
    ''' </summary>
    ''' <param name="source">
    ''' The input <see cref="DateTime"/>, which acts as the <b>this</b> instance for the extension method.
    ''' </param>
    ''' <returns>
    ''' <b>true</b> if the represents a week day; otherwise <b>false</b>.
    ''' </returns>
    ''' <remarks>
    ''' All days other than Saturday and Sunday are considered week days.
    ''' </remarks>
    <Extension>
    Public Function IsWeekDaycivil(source As Date) As Boolean
        DateSystem.LicenseKey = "LostTimeIsNeverFoundAgain"


        Dim isjan As Boolean

        If source.Day < 21 And source.Month < 2 Then
            isjan = True
        End If



        Return source.DayOfWeek <> DayOfWeek.Saturday AndAlso
               source.DayOfWeek <> DayOfWeek.Sunday AndAlso
               DateSystem.IsPublicHoliday(source, CountryCode.BR) <> True AndAlso
               feriado(source) <> True AndAlso
               isjan <> True






    End Function



    ''' <summary>
    ''' Gets a value indicating whether a <see cref="DateTime"/> value represents a week day.
    ''' </summary>
    ''' <param name="source">
    ''' The input <see cref="DateTime"/>, which acts as the <b>this</b> instance for the extension method.
    ''' </param>
    ''' <returns>
    ''' <b>true</b> if the represents a week day; otherwise <b>false</b>.
    ''' </returns>
    ''' <remarks>
    ''' All days other than Saturday and Sunday are considered week days.
    ''' </remarks>
    <Extension>
    Public Function IsWeekDaypenal(source As Date) As Boolean
        DateSystem.LicenseKey = "LostTimeIsNeverFoundAgain"


        Dim isjan As Boolean

        If source.Day < 21 And source.Month < 2 Then
            isjan = True
        End If



        Return source.DayOfWeek <> DayOfWeek.Saturday AndAlso
               source.DayOfWeek <> DayOfWeek.Sunday AndAlso
               DateSystem.IsPublicHoliday(source, CountryCode.BR) <> True






    End Function

    ''' <summary>
    ''' Returns a new <see cref="DateTime"/> that adds the specified number of week days to a specified value.
    ''' </summary>
    ''' <param name="source">
    ''' The input <see cref="DateTime"/>, which acts as the <b>this</b> instance for the extension method.
    ''' </param>
    ''' <param name="value">
    ''' A number of whole and fractional days. The <i>value</i> parameter can be negative or positive.
    ''' </param>
    ''' <returns>
    ''' An object whose value is the sum of the date and time represented by this instance and the number of week days represented by <i>value</i>.
    ''' </returns>
    ''' <remarks>
    ''' All days other than Saturday and Sunday are considered week days.
    ''' </remarks>
    <Extension>
    Public Function AddWeekDayscivil(source As Date, value As Double) As Date
        'A unit will be +/- 1 day.
        Dim unit = Math.Sign(value) * 1.0

        'Start increasing the date by units from the initial date.
        Dim result = source

        'When testing for zero, allow a margin for precision error.
        Do Until Math.Abs(value) < 0.00001
            If Math.Abs(value) < 1.0 Then
                'There is less than one full day to add so we need to see whether adding it will take us past midnight.
                Dim temp = result.AddDays(value)

                If temp.Date = result.Date OrElse temp.IsWeekDaycivil() Then
                    'Adding the partial day did not take us into a weekend day so we're done.
                    result = temp
                    value = 0.0
                Else
                    'Adding the partial day took us into a weekend day so we need to add another day.
                    result = result.AddDays(unit)
                End If
            Else
                'Add a single day.
                result = result.AddDays(unit)

                If result.IsWeekDaycivil() Then
                    'Adding a day did not take us into a weekend day so we can reduce the remaining value to add.
                    value -= unit
                End If
            End If
        Loop

        Return result
    End Function

    ''' <summary>
    ''' Returns a new <see cref="DateTime"/> that adds the specified number of week days to a specified value.
    ''' </summary>
    ''' <param name="source">
    ''' The input <see cref="DateTime"/>, which acts as the <b>this</b> instance for the extension method.
    ''' </param>
    ''' <param name="value">
    ''' A number of whole and fractional days. The <i>value</i> parameter can be negative or positive.
    ''' </param>
    ''' <returns>
    ''' An object whose value is the sum of the date and time represented by this instance and the number of week days represented by <i>value</i>.
    ''' </returns>
    ''' <remarks>
    ''' All days other than Saturday and Sunday are considered week days.
    ''' </remarks>
    <Extension>
    Public Function AddWeekDayspenal(source As Date, value As Double) As Date
        'A unit will be +/- 1 day.
        Dim unit = Math.Sign(value) * 1.0

        'Start increasing the date by units from the initial date.
        Dim result = source

        'When testing for zero, allow a margin for precision error.
        Do Until Math.Abs(value) < 0.00001
            If Math.Abs(value) < 1.0 Then
                'There is less than one full day to add so we need to see whether adding it will take us past midnight.
                Dim temp = result.AddDays(value)

                If temp.Date = result.Date OrElse temp.IsWeekDaypenal() Then
                    'Adding the partial day did not take us into a weekend day so we're done.
                    result = temp
                    value = 0.0
                Else
                    'Adding the partial day took us into a weekend day so we need to add another day.
                    result = result.AddDays(unit)
                End If
            Else
                'Add a single day.
                result = result.AddDays(unit)

                If result.IsWeekDaypenal() Then
                    'Adding a day did not take us into a weekend day so we can reduce the remaining value to add.
                    value -= unit
                End If
            End If
        Loop

        Return result
    End Function

End Module
Public Class DadosAlt

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub prazosparte()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select nome from clientes"

        cmd.ExecuteNonQuery()

        Dim dt As New DataSet()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim column1 As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Tables(0).Rows.Count - 1
            column1.Add(dt.Tables(0).Rows(i)("nome").ToString())
        Next
        pparte.AutoCompleteSource = AutoCompleteSource.CustomSource
        pparte.AutoCompleteCustomSource = column1
        pparte.AutoCompleteMode = AutoCompleteMode.Suggest

        audpar.AutoCompleteSource = AutoCompleteSource.CustomSource
        audpar.AutoCompleteCustomSource = column1
        audpar.AutoCompleteMode = AutoCompleteMode.Suggest

        atcliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        atcliente.AutoCompleteCustomSource = column1
        atcliente.AutoCompleteMode = AutoCompleteMode.Suggest

        provcli.AutoCompleteSource = AutoCompleteSource.CustomSource
        provcli.AutoCompleteCustomSource = column1
        provcli.AutoCompleteMode = AutoCompleteMode.Suggest




    End Sub

    Private Sub manuallbl_Click(sender As Object, e As EventArgs) Handles manuallbl.Click
        If manual.Checked = False Then
            manual.Checked = True
            manuallbl.ForeColor = Color.Crimson
            ddataprazo.Enabled = True
        Else
            manual.Checked = False
            manuallbl.ForeColor = Color.DimGray
            If penal.Checked Then
                Acharprazopenal()
            Else
                Acharprazocivil()

            End If
            ddataprazo.Enabled = False
        End If

    End Sub





    Private Sub procurar()

        Dim data = Format(pdata.Value, "dd/MM/yyyy")
        Dim processo As String

        If pproc2.Text <> "" Then

            processo = pproc1.Text + "/" + pproc2.Text
        Else
            processo = pproc1.Text

        End If

        Dim texto As String
        texto = pparte.Text


        If TabControl1.SelectedIndex = 0 Then


            If ComboBox1.Text = "Data da publicação" Then


                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from DadosPrazos1 where publicacao = '" & Data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If

            If ComboBox1.Text = "Processo" Then


                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from DadosPrazos1 where processo = '" & processo & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If

            If ComboBox1.Text = "Data do prazo" Then


                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from DadosPrazos1 where prazo = '" & Data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If

            If ComboBox1.Text = "Prazo fatal" Then


                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from DadosPrazos1 where fatal = '" & Data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If


            If ComboBox1.Text = "Parte" Then


                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from DadosPrazos1 where parte = '" & texto & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If





        ElseIf TabControl1.SelectedIndex = 1 Then



            If ComboBox1.Text = "Parte" Then
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from audiencias where parte = '" & texto & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If

            If ComboBox1.Text = "Data" Then
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from audiencias where data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If


            If ComboBox1.Text = "Processo" Then
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from audiencias where processo = '" & processo & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If

        ElseIf TabControl1.SelectedIndex = 2 Then
            If ComboBox1.Text = "Cliente" Then
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from atendimento where parte = '" & texto & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If

            If ComboBox1.Text = "Data" Then
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from atendimento where data = '" & data & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If


        Else
            If ComboBox1.Text = "processo" Then
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from providencias where processo = '" & processo & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If

            If ComboBox1.Text = "Responsável" Then
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select * from providencias where responsavel = '" & ComboBox7.Text & "'"

                cmd.ExecuteNonQuery()

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If
        End If


    End Sub





    '======== FUNÇÕES MENU DADOS





    Public Sub prazo_dados()
        TabControl1.SelectTab(0)
        ComboBox1.Items.Clear()

        ComboBox1.Items.Add("Data da publicação")
        ComboBox1.Items.Add("Data do prazo")
        ComboBox1.Items.Add("Prazo fatal")
        ComboBox1.Items.Add("Parte")
        ComboBox1.Items.Add("Processo")








    End Sub

    Public Sub atendimento_dados()
        TabControl1.SelectTab(2)
        ComboBox1.Items.Clear()

        ComboBox1.Items.Add("Data")
        ComboBox1.Items.Add("Cliente")

    End Sub

    Public Sub audiencias_dados()
        TabControl1.SelectTab(1)
        ComboBox1.Items.Clear()

        ComboBox1.Items.Add("Data")
        ComboBox1.Items.Add("Parte")
        ComboBox1.Items.Add("Processo")


    End Sub

    Public Sub providencias_dados()
        TabControl1.SelectTab(3)
        ComboBox1.Items.Clear()

        ComboBox1.Items.Add("Data")
        ComboBox1.Items.Add("Responsavel")
        ComboBox1.Items.Add("Processo")

    End Sub







    '============================BUTTONS MENU AGENDA===================================

    Private Sub AudienciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudienciasToolStripMenuItem.Click
        Agenda.Show()
        Agenda.audiencia_menu()
        Me.Close()

    End Sub
    Private Sub PrazoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrazoToolStripMenuItem.Click
        Agenda.Show()
        Agenda.prazos_menu()
        Me.Close()

    End Sub

    Private Sub AtendimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtendimentoToolStripMenuItem.Click
        Agenda.Show()
        Agenda.atendimento_menu()
        Me.Close()

    End Sub

    Private Sub ProvidênciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvidênciasToolStripMenuItem.Click
        Agenda.Show()
        Agenda.providencias_menu()
        Me.Close()

    End Sub




    '=============BUTTONS MENU DADOS=========================


    Private Sub PrazoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrazoToolStripMenuItem1.Click
        prazo_dados()
        display_dados()



    End Sub

    Private Sub AudiênciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudiênciaToolStripMenuItem.Click
        audiencias_dados()
        display_dados()

    End Sub

    Private Sub AtendimentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtendimentoToolStripMenuItem1.Click
        atendimento_dados()
        display_dados()

    End Sub

    Private Sub ProvidênciasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProvidênciasToolStripMenuItem1.Click
        providencias_dados()
        display_dados()



    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub




    '=======FUNÇÕES DADOS========================

    Public Function display_dados()

        If TabControl1.SelectedIndex = 0 Then
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select * from DadosPrazos1"

            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Me.DataGridView1.Columns("id_proc").Visible = False



        ElseIf TabControl1.SelectedIndex = 1 Then
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select * from audiencias"

            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

            Me.DataGridView1.Columns("horamin").Visible = False
            Me.DataGridView1.Columns("minuto").Visible = False
            Me.DataGridView1.Columns("id_proc").Visible = False


        ElseIf TabControl1.SelectedIndex = 2 Then
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select * from atendimento"

            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Me.DataGridView1.Columns("horamin").Visible = False
            Me.DataGridView1.Columns("minuto").Visible = False
            Me.DataGridView1.Columns("id_proc").Visible = False
            Me.DataGridView1.Columns("id_client").Visible = False


        Else
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select * from providencias"

            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End If

    End Function

    Public Function Acharprazocivil()
        'achar prazo

        Dim inicio As Date
        Dim diasprazo As Integer
        Dim diasantes As Integer



        inicio = datapubtxt.Value
        diasprazo = diasprazoud.Value
        diasantes = Val(TextBox1.Text)

        If diasprazo - diasantes > 0 Then
            dprazofatal.Value = inicio.AddWeekDayscivil(diasprazo)
            ddataprazo.Value = dprazofatal.Value.AddWeekDayscivil(-diasantes)
        Else
            dprazofatal.Value = inicio.AddWeekDayscivil(diasprazo)
            ddataprazo.Value = inicio.AddWeekDayscivil(diasprazo)
        End If


    End Function

    Public Function Acharprazopenal()
        'achar prazo



        Dim inicio As Date
        Dim diasprazo As Integer = diasprazoud.Value
        Dim diasantes As Integer






        inicio = datapubtxt.Value
        diasantes = Val(TextBox1.Text)

        Dim Fat As Date

        fatal.Value = inicio.AddDays(diasprazo)

        Fat = fatal.Value


        If Fat.DayOfWeek = DayOfWeek.Sunday OrElse Fat.DayOfWeek = DayOfWeek.Saturday OrElse DateSystem.IsPublicHoliday(Fat, CountryCode.BR) Then
            If diasprazo - diasantes > 0 Then
                dprazofatal.Value = Fat.AddWeekDayspenal(1)
                ddataprazo.Value = dprazofatal.Value.AddWeekDayspenal(-diasantes)
            Else
                dprazofatal.Value = Fat.AddWeekDayspenal(1)
                ddataprazo.Value = Fat.AddWeekDayspenal(1)
            End If
        Else
            If diasprazo - diasantes > 0 Then
                dprazofatal.Value = Fat
                ddataprazo.Value = dprazofatal.Value.AddWeekDayspenal(-diasantes)
            Else
                dprazofatal.Value = Fat
                ddataprazo.Value = Fat
            End If

        End If






    End Function









    '================================== PRAZOS SALVAR ==============================================================================================
    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click
        'prazos
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Dim datapub As String
        Dim diasprazo As Double
        Dim dataprazo As String
        Dim prazofatal As String
        Dim proc As String
        Dim parte As String
        Dim dili As String
        Dim responsavel As String
        Dim estatus As String
        Dim criacao As String

        criacao = fundo.nome.Text

        datapub = Format(datapubtxt.Value, "dd/MM/yyyy")
        diasprazo = Convert.ToDouble(diasprazoud.Text)
        If proctxt2.Text <> "" Then
            proc = MaskedTextBox2.Text + "/" + proctxt2.Text
        Else proc = MaskedTextBox2.Text
        End If
        dataprazo = Format(ddataprazo.Value, "dd/MM/yyyy")
        parte = partetxt.Text
        prazofatal = Format(dprazofatal.Value, "dd/MM/yyyy")
        dili = diltxt.Text
        responsavel = respcb.Text
        estatus = statuscb.Text



        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into DadosPrazos1(Responsavel, Publicacao, Dias, Prazo, Fatal, Processo, Parte, Diligencia, SITUACAO, criacao) values ('" & responsavel & "','" & datapub & "','" & diasprazo & "','" & dataprazo & "','" & prazofatal & "','" & proc & "','" & parte & "','" & dili & "','" & estatus & "', '" & criacao & "')"
        cmd.ExecuteNonQuery()

        'display_dados_dados

        datapubtxt.Value = DateTime.Now
        diasprazoud.Text = 1
        DataGridView1.ResetText()
        ddataprazo.ResetText()
        partetxt.ResetText()
        proctxt2.ResetText()
        dprazofatal.ResetText()
        diltxt.ResetText()
        respcb.ResetText()
        statuscb.Text = "Pendente"
        TextBox1.Text = ""
        MaskedTextBox2.ResetText()
        penal.Checked = False

        display_dados()
        Painel.Prazos()

    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        'audiencias
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Dim horamin As String
        horamin = audhora.Text

        Dim minuto As String
        minuto = audminuto.Text

        Dim hora As String
        hora = audhora.Text + ":" + audminuto.Text







        Dim proc As String
        If audproc2.Text <> "" Then
            proc = audproc1.Text + "/" + audproc2.Text
        Else proc = audproc1.Text
        End If

        Dim parte As String
        parte = audpar.Text

        Dim vara As String
        vara = audvar.Text

        Dim resp As String
        resp = ComboBox2.Text

        Dim sala As String
        If audvir.Checked Then
            sala = "Virtual"
        Else
            sala = "Presencial"
        End If

        Dim data As String
        data = Format(auddata.Value, "dd/MM/yyyy")

        Dim anotacao As String
        anotacao = audano.Text



        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Audiencias(Responsavel, data, hora, horamin, minuto, vara, Processo, Parte, sala, anotacao) values ('" & resp & "','" & data & "','" & hora & "','" & horamin & "','" & minuto & "','" & vara & "','" & proc & "','" & parte & "','" & sala & "','" & anotacao & "')"
        cmd.ExecuteNonQuery()


        audvir.Checked = False
        auddata.ResetText()
        audpar.ResetText()
        audvar.ResetText()
        ComboBox2.ResetText()


        display_dados()

        Painel.audiencias()



    End Sub



    Private Sub DadosAlt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MeuescDataSet.Atendimento'. Você pode movê-la ou removê-la conforme necessário.
        Me.AtendimentoTableAdapter.Fill(Me.MeuescDataSet.Atendimento)
        display_dados()
        MaskedTextBox2.Culture = System.Globalization.CultureInfo.InvariantCulture


        'RESPONSÁVEL NOME
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()




        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from users"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        respcb.DataSource = dt
        respcb.DisplayMember = "nome"
        respcb.ValueMember = "usuario"

        ComboBox2.DataSource = dt
        ComboBox2.DisplayMember = "nome"
        ComboBox2.ValueMember = "usuario"

        provresp.DataSource = dt
        provresp.DisplayMember = "nome"
        provresp.ValueMember = "usuario"

        ComboBox7.DataSource = dt
        ComboBox7.DisplayMember = "nome"
        ComboBox7.ValueMember = "usuario"


        prazosparte()

        'FIM RESPONSAVEL NOME

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        display_dados()


    End Sub















    'PRAZO =========================






    'ACHAR PRAZO ===================================================================
    Private Sub datapubtxt_ValueChanged(sender As Object, e As EventArgs) Handles datapubtxt.ValueChanged
        If penal.Checked Then
            Acharprazopenal()
        Else
            Acharprazocivil()

        End If
    End Sub

    Private Sub diasprazoud_ValueChanged(sender As Object, e As EventArgs) Handles diasprazoud.ValueChanged
        If penal.Checked Then
            Acharprazopenal()
        Else
            Acharprazocivil()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If penal.Checked Then
            Acharprazopenal()
        Else
            Acharprazocivil()

        End If
    End Sub

    Private Sub penal_CheckedChanged(sender As Object, e As EventArgs) Handles penal.CheckedChanged
        If penal.Checked Then
            Acharprazopenal()
        Else
            Acharprazocivil()

        End If
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        display_dados()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        procurar()

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

    Private Sub painelbtn_Click(sender As Object, e As EventArgs) Handles painelbtn.Click
        Painel.Show()
        Me.Close()

    End Sub


    'PROVIDENCIAS
    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()



        Dim proc As String
        If provproc2.Text <> "" Then
            proc = PROVPROC1.Text + "/" + provproc2.Text
        Else proc = provproc1.Text
        End If

        Dim parte As String
        parte = provcli.Text



        Dim data As String
        data = Format(provdata.Value, "dd/MM/yyyy")

        Dim anotacao As String
        anotacao = provano.Text

        Dim diligencia As String
        diligencia = provdili.Text

        Dim responsavel As String
        responsavel = provresp.Text



        Dim criacao As String
        criacao = fundo.usuario.Text

        Dim situacao As String
        situacao = provstatus.Text




        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into providencias(responsavel, data, processo, diligencia, Parte, anotacoes, criacao, situacao) values ('" & responsavel & "','" & data & "','" & proc & "','" & diligencia & "','" & parte & "','" & anotacao & "', '" & criacao & "', '" & situacao & "')"
        cmd.ExecuteNonQuery()


        provproc2.ResetText()

        PROVPROC1.ResetText()

        provcli.ResetText()

        provdata.ResetText()

        provano.ResetText()

        provdili.ResetText()

        provresp.ResetText()

        provstatus.ResetText()





        display_dados()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Data da publicação" OrElse ComboBox1.Text = "Data" OrElse ComboBox1.Text = "Data do prazo" OrElse ComboBox1.Text = "Prazo fatal" Then
            pdata.Visible = True
            pproc1.Visible = False
            pprocb.Visible = False
            pproc2.Visible = False
            ComboBox7.Visible = False
            pparte.Visible = False
        ElseIf ComboBox1.Text = "Processo" Then
            pproc1.Visible = True
            pprocb.Visible = True
            pproc2.Visible = True
            pdata.Visible = False
            ComboBox7.Visible = False
            pparte.Visible = False

        ElseIf ComboBox1.Text = "Responsável" Then
            ComboBox7.Visible = True
            pdata.Visible = False
            pproc1.Visible = False
            pprocb.Visible = False
            pproc2.Visible = False
            pparte.Visible = False
        Else
            pparte.Visible = True
            pdata.Visible = False
            pproc1.Visible = False
            pprocb.Visible = False
            pproc2.Visible = False
            ComboBox7.Visible = False



        End If
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Dim horamin As String
        horamin = athora.Text

        Dim minuto As String
        minuto = atminuto.Text

        Dim hora As String
        hora = athora.Text + ":" + atminuto.Text







        Dim proc As String
        If atproc2.Text <> "" Then
            proc = atproc1.Text + "/" + atproc2.Text
        Else proc = atproc1.Text
        End If

        Dim parte As String
        parte = atcliente.Text



        Dim data As String
        data = Format(atdata.Value, "dd/MM/yyyy")

        Dim anotacao As String
        anotacao = atobs.Text

        Dim id As String
        id = idcli.Text






        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into atendimento(id_client, data, hora, horamin, minuto, processo, Parte, anotacao) values ('" & id & "','" & data & "','" & hora & "','" & horamin & "','" & minuto & "','" & proc & "','" & parte & "','" & anotacao & "')"
        cmd.ExecuteNonQuery()


        atdata.ResetText()
        atproc1.ResetText()
        atproc2.ResetText()
        athora.ResetText()
        atminuto.ResetText()
        atcliente.ResetText()
        atobs.ResetText()



        display_dados()


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
End Class