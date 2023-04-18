

Imports System.Data.SqlClient

Public Class Client

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Private Sub affiche()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from client"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_client"))
            listems.SubItems.Add(dr("nom_client"))
            listems.SubItems.Add(dr("adresse_client"))
            listems.SubItems.Add(dr("tele_client"))
            listems.SubItems.Add(dr("note_client"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_id_Client.Text = Nothing Or txt_Adres_Client.Text = Nothing Or txt_Nom_Client.Text = Nothing Or txt_Note_Client.Text = Nothing Or txt_tele_Client.Text = Nothing Or txt_Note_Client.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else


            If MsgBox("vous voulez vraiment ajoutez? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into client values ('" & txt_id_Client.Text & "' , '" & txt_Nom_Client.Text & "' , '" & txt_Adres_Client.Text & "','" & txt_tele_Client.Text & "','" & txt_Note_Client.Text & "')
"
                cmd.ExecuteNonQuery()
                MsgBox("ajouter avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_id_Client.Text = Nothing
        txt_Nom_Client.Text = Nothing
        txt_Adres_Client.Text = Nothing
        txt_tele_Client.Text = Nothing
        txt_Note_Client.Text = Nothing
        txt_id_Client.Focus()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("selectionner un Fournisseur !")
        Else

            cn.Open()
            cmd.CommandText = "select *from client where id_client = '" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read Then

                Me.txt_id_Client.Text = dr.Item(0).ToString
                Me.txt_Nom_Client.Text = dr.Item(1).ToString
                Me.txt_Adres_Client.Text = dr.Item(2).ToString
                Me.txt_tele_Client.Text = dr.Item(3).ToString
                Me.txt_Note_Client.Text = dr.Item(4).ToString


                dr.Close()

            End If
            cn.Close()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txt_id_Client.Text = Nothing Or txt_Adres_Client.Text = Nothing Or txt_Nom_Client.Text = Nothing Or txt_Note_Client.Text = Nothing Or txt_tele_Client.Text = Nothing Or txt_Note_Client.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else
            If MsgBox("vous voulez vraiment modifier? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " update client set nom_client = ' " & txt_Nom_Client.Text & "' ,adresse_client = '" & txt_Adres_Client.Text & "' , tele_client ='" & txt_tele_Client.Text & "' , note_client ='" & txt_Note_Client.Text & "'  where id_client = '" & txt_id_Client.Text & " ' "
                cmd.ExecuteNonQuery()
                MsgBox("modifier avec succes")
                cn.Close()


                affiche()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_id_Client.Text = Nothing Or txt_Adres_Client.Text = Nothing Or txt_Nom_Client.Text = Nothing Or txt_Note_Client.Text = Nothing Or txt_tele_Client.Text = Nothing Or txt_Note_Client.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            If MsgBox("vous voulez vraiment supprimer? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from client where id_client = '" & txt_id_Client.Text & " '"
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Aucceil.Show()
        Me.Hide()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class