Imports System.Data.SqlClient

Public Class admin
    Public dr As SqlDataReader
    Public cmd As New SqlCommand
    Private Sub affiche()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from users"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_users"))
            listems.SubItems.Add(dr("login_users"))
            listems.SubItems.Add(dr("password_users"))
            listems.SubItems.Add(dr("nom_users"))
            listems.SubItems.Add(dr("prenom_user"))
            listems.SubItems.Add(dr("tele_user"))
            listems.SubItems.Add(dr("type_user"))
            listems.SubItems.Add(dr("note"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_id_Admin.Text = Nothing
        txt_Login.Text = Nothing
        txt_Nom.Text = Nothing
        txt_Prenom.Text = Nothing
        txt_tele.Text = Nothing
        TxtPassword.Text = Nothing
        TxtNote.Text = Nothing
        ComboType.Text = Nothing
        TxtAdress.Text = Nothing

        txt_id_Admin.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_id_Admin.Text = Nothing Or txt_Login.Text = Nothing Or txt_Nom.Text = Nothing Or txt_Prenom.Text = Nothing Or txt_tele.Text = Nothing Or ComboType.Text = Nothing Or TxtNote.Text = Nothing Or TxtPassword.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else


            If MsgBox("vous voulez vraiment ajoutez? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into users values ('" & txt_id_Admin.Text & "' , '" & txt_Login.Text & "' , '" & TxtPassword.Text & "','" & txt_Nom.Text & "','" & txt_Prenom.Text & "', '" & txt_tele.Text & "','" & ComboType.Text & "','" & TxtNote.Text & "')
"
                cmd.ExecuteNonQuery()
                MsgBox("ajouter avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txt_id_Admin.Text = Nothing Or txt_Login.Text = Nothing Or txt_Nom.Text = Nothing Or txt_Prenom.Text = Nothing Or txt_tele.Text = Nothing Or ComboType.Text = Nothing Or TxtNote.Text = Nothing Or TxtPassword.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else
            If MsgBox("vous voulez vraiment modifier? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " update users set login_users = ' " & txt_Login.Text & "' ,password_users = '" & TxtPassword.Text & "' , nom_users ='" & txt_Nom.Text & "' , prenom_user ='" & txt_Prenom.Text & "' , tele_user ='" & txt_tele.Text & "'  , type_user ='" & ComboType.Text & "' , note ='" & TxtNote.Text & "' where id_users = '" & txt_id_Admin.Text & " ' "
                cmd.ExecuteNonQuery()
                MsgBox("modifier avec succes")
                cn.Close()


                affiche()
            End If
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("selectionner un admin ou users  !")
        Else

            cn.Open()
            cmd.CommandText = "select *from users where id_users = '" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read Then

                Me.txt_id_Admin.Text = dr.Item(0).ToString
                Me.txt_Login.Text = dr.Item(1).ToString
                Me.TxtPassword.Text = dr.Item(2).ToString
                Me.txt_Nom.Text = dr.Item(3).ToString
                Me.txt_Prenom.Text = dr.Item(4).ToString
                Me.txt_tele.Text = dr.Item(5).ToString
                Me.ComboType.Text = dr.Item(6).ToString
                Me.TxtNote.Text = dr.Item(7).ToString


                dr.Close()

            End If
            cn.Close()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_id_Admin.Text = Nothing Or txt_Login.Text = Nothing Or txt_Nom.Text = Nothing Or txt_Prenom.Text = Nothing Or txt_tele.Text = Nothing Or ComboType.Text = Nothing Or TxtNote.Text = Nothing Or TxtPassword.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            If MsgBox("vous voulez vraiment supprimer? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from users where id_users = '" & txt_id_Admin.Text & " '"
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Aucceil.Show()
        Me.Hide()

    End Sub
End Class