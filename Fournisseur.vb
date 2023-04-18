Imports System.Data.SqlClient

Public Class Fournisseur

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Private Sub affiche()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from fournisseurs"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_fourn"))
            listems.SubItems.Add(dr("nom_fourn"))
            listems.SubItems.Add(dr("adresse_fourn"))
            listems.SubItems.Add(dr("tele_fourn"))
            listems.SubItems.Add(dr("note_fourn"))
        End While
        dr.Close()
        cn.Close()
    End Sub



    Private Sub Fournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_id_Fourn.Text = Nothing Or txt_id_Fourn.Text = Nothing Or txt_Nom_Fourn.Text = Nothing Or txt_Note_Fourn.Text = Nothing Or txt_tele_Fourn.Text = Nothing Or txt_Adres_Fourn.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else


            If MsgBox("vous voulez vraiment ajoutez? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into fournisseurs values ('" & txt_id_Fourn.Text & "' , '" & txt_Nom_Fourn.Text & "' , '" & txt_Adres_Fourn.Text & "','" & txt_tele_Fourn.Text & "','" & txt_Note_Fourn.Text & "')
"
                cmd.ExecuteNonQuery()
                MsgBox("ajouter avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_id_Fourn.Text = Nothing
        txt_Nom_Fourn.Text = Nothing
        txt_Adres_Fourn.Text = Nothing
        txt_tele_Fourn.Text = Nothing
        txt_Note_Fourn.Text = Nothing
        txt_id_Fourn.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If txt_id_Fourn.Text = Nothing Or txt_id_Fourn.Text = Nothing Or txt_Nom_Fourn.Text = Nothing Or txt_Note_Fourn.Text = Nothing Or txt_tele_Fourn.Text = Nothing Or txt_Adres_Fourn.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else
            If MsgBox("vous voulez vraiment modifier? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " update fournisseurs set nom_fourn = ' " & txt_Nom_Fourn.Text & "' ,adresse_fourn = '" & txt_Adres_Fourn.Text & "' , tele_fourn ='" & txt_tele_Fourn.Text & "' , note_fourn ='" & txt_Note_Fourn.Text & "'  where id_fourn = '" & txt_id_Fourn.Text & " ' "
                cmd.ExecuteNonQuery()
                MsgBox("modifier avec succes")
                cn.Close()


                affiche()
            End If
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("selectionner un Fournisseur !")
        Else

            cn.Open()
            cmd.CommandText = "select *from fournisseurs where id_fourn = '" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read Then

                Me.txt_id_Fourn.Text = dr.Item(0).ToString
                Me.txt_Nom_Fourn.Text = dr.Item(1).ToString
                Me.txt_Adres_Fourn.Text = dr.Item(2).ToString
                Me.txt_tele_Fourn.Text = dr.Item(3).ToString
                Me.txt_Note_Fourn.Text = dr.Item(4).ToString


                dr.Close()

            End If
            cn.Close()

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_id_Fourn.Text = Nothing Or txt_id_Fourn.Text = Nothing Or txt_Nom_Fourn.Text = Nothing Or txt_Note_Fourn.Text = Nothing Or txt_tele_Fourn.Text = Nothing Or txt_Adres_Fourn.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            If MsgBox("vous voulez vraiment supprimer? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from fournisseurs where id_fourn = '" & txt_id_Fourn.Text & " '"
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
End Class