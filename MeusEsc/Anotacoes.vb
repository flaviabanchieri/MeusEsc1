Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Public Class Anotacoes
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Meuesc.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Dim datas As String
        Dim dilig As String
        Dim user As String

        datas = Format(data.Value, "dd/MM/yyyy")
        dilig = dili.Text
        user = fundo.usuario.Text







        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into anotacoes(data, diligencia, resp) values ('" & datas & "','" & dilig & "','" & user & "')"
        cmd.ExecuteNonQuery()

        data.Value = Date.Now
        dili.ResetText()


        Painel.anotacao()
    End Sub
End Class