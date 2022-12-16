Public Class Usuario
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fundo.permissao.Text = "Administrador" Then
            AdicionarPrazoToolStripMenuItem.Visible = True

        End If
    End Sub

    Private Sub Label24_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdicionarPrazoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarPrazoToolStripMenuItem.Click
        TabControl1.SelectTab(1)

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

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Painel.Show()
        Me.Close()

    End Sub

    Private Sub Label24_Click_2(sender As Object, e As EventArgs) Handles Label24.Click
        txtnome.Visible = False
        txtsenha.Visible = False
        statuscb.Visible = False

    End Sub

    Private Sub Label16_Click_1(sender As Object, e As EventArgs) Handles Label16.Click
        txtnome.Visible = True
        txtsenha.Visible = True
        statuscb.Visible = True
    End Sub



    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave

        My.Settings.DiasAntes = TextBox2.Text
        My.Settings.Save()

    End Sub
End Class