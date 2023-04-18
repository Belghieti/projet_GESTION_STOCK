Imports System.Data.SqlClient

Public Class Achat
    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand




    Private Sub Affiche()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from achat"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_achat"))
            listems.SubItems.Add(dr("date_achat"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_fournisseur"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_achat"))


        End While
        dr.Close()

        Dim str2 As String = " select count(*),SUM(qte_achat) as somme ,COUNT(distinct id_prod) as total_produit from achat"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader

        dr2.Read()
        Me.LblTotal_prod.Text = "Total achat :" & dr2.Item(0).ToString
        Me.LblTotalQte.Text = "Total Qte :" & dr2.Item(1).ToString
        Me.Lbl.Text = "Total produit :" & dr2.Item(2).ToString


        dr2.Close()

        cn.Close()

    End Sub

    Private Sub Achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Affiche()
        '######################################################################################

        Dim str3 As String = "select max(id_achat)  from achat "

        cn.Open()
        cmd = New SqlCommand(str3, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txt_idachat.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()
        '################################################################################

        txt_id_user.Text = connection.id
        Label7.Text = connection.nom & " " & connection.prenom



        cn.Open()

        ''Dim listems As ListViewItem
        Dim str As String = "select  libelle from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ComboProd.Items.Clear()
        While (dr.Read)
            Me.ComboProd.Items.Add(dr("libelle"))
            '' Me.ComboProd.Items.Add(dr("libelle"))





        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txt_idachat.Text = Nothing Or DateAchat.Text = Nothing Or txt_qteAcha.Text = Nothing Or txt_idFourn.Text = Nothing Or txt_idProd.Text = Nothing Or txt_id_user.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            txt_idachat.Text = txt_idachat.Text + 1

            If MsgBox("vous voulez vraiment ajoutez? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into achat values ('" & txt_idachat.Text & "', '" & DateAchat.Text & "' , '" & txt_qteAcha.Text & "','" & txt_idProd.Text & "','" & txt_idFourn.Text & "','" & txt_id_user.Text & "','" & TxtNotAcha.Text & "' )"
                cmd.ExecuteNonQuery()
                Dim msgBoxResult = MsgBox("ajouter avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str3 As String = "select max(id_achat)  from achat "

        cn.Open()
        cmd = New SqlCommand(str3, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txt_idachat.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()

        txt_idProd.Text = Nothing
        ''  txt_idachat.Text = Nothing
        txt_idFourn.Text = Nothing
        '' txt_id_user.Text = Nothing
        DateAchat.Text = Nothing
        txt_idFourn.Text = Nothing
        TxtNotAcha.Text = Nothing
        txt_qteAcha.Text = Nothing
        ComboProd.Text = Nothing
        txt_idachat.Focus()
        affiche()


    End Sub

    Private Sub List(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("selectionner un produit !")
        Else

            cn.Open()
            cmd.CommandText = "select *from achat where id_achat = '" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read Then

                Me.txt_idachat.Text = dr.Item(0).ToString
                Me.DateAchat.Text = dr.Item(1).ToString
                Me.txt_qteAcha.Text = dr.Item(2).ToString
                ''  Me.txt_idProd.Text = Replace(txt_pu_prod.Text, ",", ".")
                Me.txt_idProd.Text = dr.Item(3).ToString
                ''  Me.txt_id_user.Text = Replace(txt_prixVent.Text, ",", ".")
                Me.txt_idFourn.Text = dr.Item(4).ToString
                '' Me.txt_id_user.Text = dr.Item(5).ToString
                Me.TxtNotAcha.Text = dr.Item(5).ToString

                dr.Close()

            End If
            cn.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If txt_idProd.Text = Nothing Or txt_idachat.Text = Nothing Or txt_idFourn.Text = Nothing Or txt_idProd.Text = Nothing Or txt_id_user.Text = Nothing Or txt_qteAcha.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else
            If MsgBox("vous voulez vraiment modifier? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " update achat set id_achat = ' " & txt_idachat.Text & "' , date_achat = ' " & DateAchat.Text & "' ,  qte_achat = ' " & txt_qteAcha.Text & "'  , id_prod = ' " & txt_idProd.Text & "' , id_fournisseur = ' " & txt_idFourn.Text & "'   , id_users = ' " & txt_id_user.Text & "' ,note_achat ='" & TxtNotAcha.Text & "' where id_achat = '" & txt_idachat.Text & " ' "
                cmd.ExecuteNonQuery()
                MsgBox("modifier avec succes")
                cn.Close()
                affiche()

            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_idProd.Text = Nothing Or txt_idachat.Text = Nothing Or txt_idFourn.Text = Nothing Or txt_idProd.Text = Nothing Or txt_id_user.Text = Nothing Or txt_qteAcha.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            If MsgBox("vous voulez vraiment supprimer? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from achat where id_achat = '" & txt_idachat.Text & " '"
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succes")
                cn.Close()
                Affiche()
                '###########################################################################
                Dim str3 As String = "select max(id_achat)  from achat "

                cn.Open()
                cmd = New SqlCommand(str3, cn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txt_idachat.Text = dr.Item(0).ToString

                End If
                dr.Read()
                cn.Close()
                '###################################################################

            End If
        End If
    End Sub

    Private Sub Key(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from achat where  " & Comboresach.Text & "   like '%' + @1 + '%' "
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", TextBox1.Text)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_achat"))
            listems.SubItems.Add(dr("date_achat"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_fournisseur"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_achat"))



        End While
        dr.Close()


        Dim str2 As String = "select count(*),SUM(qte_achat)  ,COUNT(distinct id_prod)  from achat where  " & Comboresach.Text & "   like '%' + @1 + '%' "
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", TextBox1.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.LblTotal_prod.Text = "Total achat :" & dr2.Item(0).ToString
        Me.LblTotalQte.Text = "Total Qte :" & dr2.Item(1).ToString
        Me.Lbl.Text = "Total produit :" & dr2.Item(2).ToString


        dr2.Close()




        cn.Close()
    End Sub

    Private Sub Chang(sender As Object, e As EventArgs) Handles Comboresach.TextChanged
        TextBox1.Text = Nothing
        TextBox1.Focus()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnFerAchat.Click
        Aucceil.Show()
        Me.Hide()

    End Sub
    ''===============================================================================================================
    Private Sub ComboProd_TextChanged(sender As Object, e As EventArgs) Handles ComboProd.TextChanged

        cn.Open()
        Dim str As String = "select id_prod from produits where libelle ='" & ComboProd.Text & "'"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ''txt_idachat.Text = Nothing
        ListView1.Items.Clear()
        While (dr.Read)
            txt_idProd.Text = dr.Item("id_prod").ToString
            txt_qteAcha.Text = Nothing
            TxtNotAcha.Text = Nothing
        End While
        dr.Close()
        cn.Close()

        ''####################################################################################################################



        ''|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        cn.Open()
        Dim str2 As String = "select pu_prod  from produits where libelle = '" & ComboProd.Text & "'"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        If (dr2.Read) Then
            TxtPrixAchat.Text = (dr2.Item(0).ToString)

            '' Me.txt_idProd.Text = Replace(txtPrixAchat.Text, ",", ".")
            '' Me.txt_id_user.Text = Replace(TxtPrixVent.Text, ",", ".")
        Else
            TxtPrixAchat.Text = 0

        End If
        dr.Close()
        cn.Close()

        ''#####################################################################################################################

    End Sub
    ''====================================================================================================================
    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        vente.Show()
        Me.Hide()

    End Sub

    Private Sub Txt_qteAcha_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_qteAcha.KeyUp
        If (TxtPrixAchat.Text = Nothing Or txt_qteAcha.Text = Nothing) Then
            TxtNotAcha.Text = ""
        Else
            TxtNotAcha.Text = (TxtPrixAchat.Text) * (txt_qteAcha.Text)

            '' txt_Vent_Rendu.Text = ((TxtPrixVent.Text) - (txtPrixAchat.Text)) * (txt_qteVent.Text)
            ''LblTotalJour.Text = (txt_qteVent.Text) * (TxtPrixVent.Text)
        End If
    End Sub


End Class