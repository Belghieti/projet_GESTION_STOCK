Imports System.Data.SqlClient

Public Class user
    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim str As String = "select *from users where login_users = '" & TxtLogin.Text & "' and    password_users =  '" & TxtPassword.Text & "'  "


        If TxtLogin.Text = Nothing Then
            MessageBox.Show("Remplir login")

        ElseIf (TxtPassword.Text = Nothing) Then
            MessageBox.Show("Remplir password")
        Else

            cn.Open()
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                connection.id = dr.Item("id_users").ToString
                connection.nom = dr.Item("nom_users").ToString
                connection.prenom = dr.Item("prenom_user").ToString

                vente.Show()
                vente.BtnFerm.Enabled = False
                vente.Button3.Enabled = False
                vente.Button4.Enabled = False
            Else

                MsgBox("Incorect password or Username !!  ")
                dr.Close()
                cn.Close()
                Me.Close()

            End If


            dr.Close()
            cn.Close()

            Me.Hide()

        End If
    End Sub
End Class