Imports System.Data.SqlClient

Public Class Form1
    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand

    Private Sub affiche()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_prod"))
            listems.SubItems.Add(dr("libelle"))
            listems.SubItems.Add(dr("pu_prod"))
            listems.SubItems.Add(dr("prix_vente"))
            listems.SubItems.Add(dr("note_prod"))
            listems.SubItems.Add(dr("code_bare"))
            listems.SubItems.Add(dr("type_prod"))


        End While
        dr.Close()

        Dim str2 As String = " select COUNT(*) as Total  from produits"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader

        dr2.Read()
        Me.LblTotal.Text = "nombres des produits " & dr2.Item(0).ToString




        dr2.Close()



        cn.Close()
    End Sub

    Private Sub type()
        cn.Open()
        'Dim listems As ListViewItem
        Dim str As String = "select distinct type_prod from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader


        While (dr.Read)

            Me.combo_Produit.Items.Add(dr("type_prod")).ToString()

        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche()
        type()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txt_idprod.Text = Nothing Or txt_codeBar.Text = Nothing Or txt_lebelle.Text = Nothing Or txt_NoteProd.Text = Nothing Or txt_prixVent.Text = Nothing Or txt_pu_prod.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            txt_idprod.Text = txt_idprod.Text + 1

            If MsgBox("vous voulez vraiment ajoutez? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into produits values ('" & txt_idprod.Text & "' , '" & txt_lebelle.Text & "' , '" & txt_pu_prod.Text & "','" & txt_prixVent.Text & "','" & txt_NoteProd.Text & "','" & txt_codeBar.Text & "','" & combo_Produit.Text & "')
"
                cmd.ExecuteNonQuery()
                MsgBox("ajouter avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    '  Private Sub list(sender As Object, e As EventArgs) Handles ListView1.Click


    ' End Sub

    Private Sub List(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("selectionner un produit !")
        Else

            cn.Open()
            cmd.CommandText = "select *from produits where id_prod = '" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read Then

                Me.txt_idprod.Text = dr.Item(0).ToString
                Me.txt_lebelle.Text = dr.Item(1).ToString
                Me.txt_pu_prod.Text = dr.Item(2).ToString
                Me.txt_pu_prod.Text = Replace(txt_pu_prod.Text, ",", ".")
                Me.txt_prixVent.Text = dr.Item(3).ToString
                Me.txt_prixVent.Text = Replace(txt_prixVent.Text, ",", ".")
                Me.txt_NoteProd.Text = dr.Item(4).ToString
                Me.txt_codeBar.Text = dr.Item(5).ToString
                Me.combo_Produit.Text = dr.Item(6).ToString

                dr.Close()

            End If
            cn.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If txt_idprod.Text = Nothing Or txt_codeBar.Text = Nothing Or txt_lebelle.Text = Nothing Or txt_NoteProd.Text = Nothing Or txt_prixVent.Text = Nothing Or txt_pu_prod.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else
            If MsgBox("vous voulez vraiment modifier? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " update produits set libelle = ' " & txt_lebelle.Text & "' , pu_prod = ' " & txt_pu_prod.Text & "' ,  prix_vente = ' " & txt_prixVent.Text & "'  , note_prod = ' " & txt_NoteProd.Text & "' , code_bare = ' " & txt_codeBar.Text & "'   , type_prod = ' " & combo_Produit.Text & "' where id_prod = '" & txt_idprod.Text & " ' "
                cmd.ExecuteNonQuery()
                MsgBox("modifier avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If txt_idprod.Text = Nothing Or txt_codeBar.Text = Nothing Or txt_lebelle.Text = Nothing Or txt_NoteProd.Text = Nothing Or txt_prixVent.Text = Nothing Or txt_pu_prod.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            If MsgBox("vous voulez vraiment supprimer? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from produits where id_prod = '" & txt_idprod.Text & " '"
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succes")
                cn.Close()
                affiche()

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = "select max(id_prod)  from produits "

        cn.Open()
        cmd = New SqlCommand(str1, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txt_idprod.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()



        '' txt_idprod.Text = Nothing
        txt_codeBar.Text = Nothing
        txt_lebelle.Text = Nothing
        txt_NoteProd.Text = Nothing
        txt_prixVent.Text = Nothing
        txt_pu_prod.Text = Nothing
        combo_Produit.Text = Nothing
        txt_idprod.Focus()



    End Sub

    Private Sub textBox(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from produits where  " & Comboresach.Text & "   like '%' + @1 + '%' "
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", TextBox1.Text)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_prod"))
            listems.SubItems.Add(dr("libelle"))
            listems.SubItems.Add(dr("pu_prod"))
            listems.SubItems.Add(dr("prix_vente"))
            listems.SubItems.Add(dr("note_prod"))
            listems.SubItems.Add(dr("code_bare"))
            listems.SubItems.Add(dr("type_prod"))


        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Aucceil.Show()
        Me.Hide()

    End Sub
End Class
