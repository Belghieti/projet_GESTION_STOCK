
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class choixAcha
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        password.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        user.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub choixAcha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "1234" Then
            Button1.Enabled = True

        End If
    End Sub
End Class