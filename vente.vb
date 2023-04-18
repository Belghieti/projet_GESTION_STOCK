Imports System.Data.SqlClient


Public Class vente



    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand



    Private Sub affiche()
        cn.Close()

        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from vente"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_vente"))
            listems.SubItems.Add(dr("date_vente"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("pu_achat"))
            listems.SubItems.Add(dr("pu_vente"))
            listems.SubItems.Add(dr("mouvement"))
            listems.SubItems.Add(dr("m_vente"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_client"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_vente"))



        End While
        dr.Close()


        Dim str2 As String = "select count(*) , SUM(qte_achat)  ,SUM(m_vente) ,COUNT(distinct id_prod)   from vente  "
        cmd2 = New SqlCommand(str2, cn)
        '' cmd2.Parameters.AddWithValue("@1", TextBox1.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.LblTotal.Text = "total de  vente :" & dr2.Item(0).ToString
        Me.LblTotalQte.Text = "Total Qte  :" & dr2.Item(1).ToString
        Me.Lbl.Text = "Revenue :" & dr2.Item(2).ToString
        Me.LabProdui.Text = "Total produit :" & dr2.Item(3).ToString
        dr2.Close()

        cn.Close()

    End Sub


    Private Sub vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        affiche()

        Dim str3 As String = "select max(id_vente)  from vente "

        cn.Open()
        cmd = New SqlCommand(str3, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txt_idVente.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()



        '###########################################################################

        '###########################################################################


        '' txt_id_Client.ReadOnly = True





        '' Txt_id_users.Text = connection.id

        '=============================================================
        Dim str2 As String = "select *from users where login_users = '" & password.TxtLogin.Text & "' and    password_users =  '" & password.TxtPassword.Text & "'  "

        cn.Open()
        cmd = New SqlCommand(str2, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            connection.id = dr.Item("id_users").ToString
            connection.nom = dr.Item("nom_users").ToString
            connection.prenom = dr.Item("prenom_user").ToString
        End If
        dr.Read()
        cn.Close()
        '###############################################################################################################


        '###############################################################################################################


        Txt_id_users.Text = connection.id

        '=========================================
        Label16.Text = connection.nom & " " & connection.prenom

        cn.Open()

        ''Dim listems As ListViewItem
        Dim str As String = "select  libelle from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ComboVent.Items.Clear()
        While (dr.Read)
            Me.ComboVent.Items.Add(dr("libelle"))
            '' Me.ComboProd.Items.Add(dr("libelle"))





        End While
        dr.Close()
        cn.Close()




    End Sub
    ''=================================================================================================================================
    Private Sub txt_idFourn_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Produit.KeyUp
        cn.Open()
        Dim str2 As String = "select pu_prod , prix_vente from produits where libelle = '" & ComboVent.Text & "'"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        If (dr2.Read) Then
            txtPrixAchat.Text = dr2.Item(0)
            TxtPrixVent.Text = dr2.Item(1)
            '' Me.txt_idProd.Text = Replace(txtPrixAchat.Text, ",", ".")
            '' Me.txt_id_user.Text = Replace(TxtPrixVent.Text, ",", ".")
        Else
            txtPrixAchat.Text = 0
            TxtPrixVent.Text = 0
        End If
        dr.Close()
        cn.Close()
    End Sub
    ''================================================================================================================================================

    ''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    Private Sub txt_qteAcha_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_qteVent.KeyUp
        If (txtPrixAchat.Text = Nothing Or TxtPrixVent.Text = Nothing Or txt_qteVent.Text = Nothing) Then
            txt_Vent_Rendu.Text = ""
        Else
            txt_Vent_Rendu.Text = (TxtPrixVent.Text) * (txt_qteVent.Text)

            '' txt_Vent_Rendu.Text = ((TxtPrixVent.Text) - (txtPrixAchat.Text)) * (txt_qteVent.Text)
            ''LblTotalJour.Text = (txt_qteVent.Text) * (TxtPrixVent.Text)
        End If




    End Sub

    Private Function GetV() As Integer
        Return cmd.ExecuteNonQuery()
    End Function
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click


        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("selectionner un produit !")
        Else

            ''###############################################################


            ''##############################################################


            cn.Open()
            cmd.CommandText = "select *from vente where id_vente = '" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read Then

                Me.txt_idVente.Text = dr.Item(0).ToString
                Me.DateVente.Text = dr.Item(1).ToString
                Me.txt_qteVent.Text = dr.Item(2).ToString
                Me.txtPrixAchat.Text = dr.Item(3).ToString
                Me.TxtPrixVent.Text = dr.Item(4).ToString
                '' Me.txtPrixAchat.Text = Replace(txtPrixAchat.Text, ",", ".")
                ''   Me.TxtPrixVent.Text = Replace(TxtPrixVent.Text, ",", ".")
                Me.Combo_Mouvement.Text = dr.Item(5).ToString
                ''  Me.txt_id_user.Text = Replace(txt_prixVent.Text, ",", ".")
                Me.txt_Vent_Rendu.Text = dr.Item(6).ToString
                Me.txt_Produit.Text = dr.Item(7).ToString
                Me.txt_id_Client.Text = dr.Item(8).ToString
                ''  Me.Txt_id_users.Text = dr.Item(9).ToString
                Me.Txt_Note_vente.Text = dr.Item(9).ToString

                dr.Close()

            End If

            cn.Close()


            ''##########################################################################
            cn.Open()
            Dim str As String = "select id_prod, libelle from produits where id_prod ='" & txt_Produit.Text & "'"
            ''select libelle from produits where id_prod = 3
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            txt_Produit.Text = Nothing
            ''ListView1.Items.Clear()
            While (dr.Read)
                txt_Produit.Text = dr.Item("id_prod").ToString
                TxtNomProduit.Text = dr.Item("libelle").ToString

            End While
            dr.Close()
            cn.Close()



            ''##########################################################################

        End If

        ''##########################################################################################





        ''#############################################################################################

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str3 As String = "select max(id_vente)  from vente "

        cn.Open()
        cmd = New SqlCommand(str3, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txt_idVente.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()


        ''txt_idVente.Text = Nothing
        TextBox2.Text = Nothing
        DateVente.Text = Nothing
        TxtNomProduit.Text = Nothing
        txt_qteVent.Text = Nothing
        txtPrixAchat.Text = Nothing
        TxtPrixVent.Text = Nothing
        Combo_Mouvement.Text = Nothing
        txt_Vent_Rendu.Text = Nothing
        txt_Produit.Text = Nothing
        ''txt_id_Client.Text = Nothing
        ''  Txt_id_users.Text = Nothing
        Txt_Note_vente.Text = Nothing
        ComboVent.Text = Nothing
        txt_idVente.Focus()
        affiche()



    End Sub

    Private Sub key(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select *from vente  where  " & Comboresach.Text & "   like  @2 + '%' "
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@2", TextBox1.Text)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)

            listems = Me.ListView1.Items.Add(dr("id_vente"))
            listems.SubItems.Add(dr("date_vente"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("pu_achat"))
            listems.SubItems.Add(dr("pu_vente"))
            listems.SubItems.Add(dr("mouvement"))
            listems.SubItems.Add(dr("m_vente"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_client"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_vente"))

        End While
        dr.Close()


        Dim str2 As String = "select count(*) as nbr_vente , SUM(qte_achat) as Qte_vent ,SUM(m_vente) as Revenue,COUNT(distinct id_prod) as total_produit  from vente where  " & Comboresach.Text & "   like '%' + @1 + '%' "
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", TextBox1.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.LblTotal.Text = "total de  vente :" & dr2.Item(0).ToString
        Me.LblTotalQte.Text = "Total Qte  :" & dr2.Item(1).ToString
        Me.Lbl.Text = "Revenue :" & dr2.Item(2).ToString
        Me.LabProdui.Text = "Total produit :" & dr2.Item(3).ToString


        dr2.Close()


        cn.Close()


        ''####################################################################
        If (Comboresach.Text = "id_prod") Then
            cn.Open()
            Dim str1 As String = "select id_prod, libelle from produits where id_prod ='" & TextBox1.Text & "'"
            ''select libelle from produits where id_prod = 3
            cmd = New SqlCommand(str1, cn)
            dr = cmd.ExecuteReader
            txt_Produit.Text = Nothing
            '' ListView1.Items.Clear()
            While (dr.Read)
                txt_Produit.Text = dr.Item("id_prod").ToString
                TxtNomProduit.Text = dr.Item("libelle").ToString

            End While
            dr.Close()
            cn.Close()
        End If


        ''##################################################################
        If (Comboresach.Text = "id_users") Then
            cn.Open()
            Dim str3 As String = "select nom_users ,prenom_user from users where id_users ='" & TextBox1.Text & "'"
            ''select libelle from produits where id_prod = 3
            cmd = New SqlCommand(str3, cn)
            dr = cmd.ExecuteReader
            txt_Produit.Text = Nothing
            '' ListView1.Items.Clear()
            While (dr.Read)
                TxtNomProduit.Text = dr.Item(0).ToString
                TextBox2.Text = dr.Item(1).ToString
                ''TxtNomProduit.Text = dr.Item("libelle").ToString

            End While
            dr.Close()
            cn.Close()
        End If

        ''##################################################################

        txt_idVente.Text = Nothing
        DateVente.Text = Nothing
        '' TxtNomProduit.Text = Nothing
        txt_qteVent.Text = Nothing
        txtPrixAchat.Text = Nothing
        TxtPrixVent.Text = Nothing
        Combo_Mouvement.Text = Nothing
        txt_Vent_Rendu.Text = Nothing
        txt_Produit.Text = Nothing
        ''txt_id_Client.Text = Nothing
        ''  Txt_id_users.Text = Nothing
        Txt_Note_vente.Text = Nothing
        ComboVent.Text = Nothing
        txt_idVente.Focus()

        ''####################################################################
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnFerm.Click
        Aucceil.Show()
        Me.Hide()

    End Sub
    ''=========================================================================================================================================
    Private Sub ComboVent_TextChanged(sender As Object, e As EventArgs) Handles ComboVent.TextChanged

        cn.Open()
        Dim str As String = "select id_prod  , libelle from produits where libelle ='" & ComboVent.Text & "'"
        ''select libelle from produits where id_prod = 3
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        txt_Produit.Text = Nothing
        '' ListView1.Items.Clear()
        While (dr.Read)
            txt_Produit.Text = dr.Item("id_prod").ToString
            TxtNomProduit.Text = dr.Item("libelle").ToString

        End While
        dr.Close()
        cn.Close()

        ''|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        cn.Open()
        Dim str2 As String = "select pu_prod , prix_vente from produits where libelle = '" & ComboVent.Text & "'"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        If (dr2.Read) Then
            txtPrixAchat.Text = dr2.Item(0)
            TxtPrixVent.Text = dr2.Item(1)
            '' Me.txt_idProd.Text = Replace(txtPrixAchat.Text, ",", ".")
            '' Me.txt_id_user.Text = Replace(TxtPrixVent.Text, ",", ".")
            txt_qteVent.Text = Nothing
            txt_Vent_Rendu.Text = Nothing

        Else
            txtPrixAchat.Text = 0
            TxtPrixVent.Text = 0
        End If
        dr.Close()
        cn.Close()
        ''||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        ''######################################################################################

        Dim str3 As String = "select sum (qte_achat)  from vente where id_prod = '" & txt_Produit.Text & "' "

        cn.Open()
        cmd = New SqlCommand(str3, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            Me.Label17.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()

        ''######################################################################################
        Dim str4 As String = "select sum (qte_achat)  from achat where id_prod = '" & txt_Produit.Text & "' "

        cn.Open()
        cmd = New SqlCommand(str4, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            Me.Label18.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()

        ''###################################################################################

        ''######################################################################################
        If (Me.Label18.Text > Me.Label17.Text) Then
            ''   TextBox3.Text = Me.Label18.Text - Me.Label17.Text
            Me.Label19.Text = "en stock"
        Else
            Me.Label19.Text = "Inssufisant"

            ''            TextBox3.Text = Me.Label18.Text - Me.Label17.Text
        End If



    End Sub
    ''====================================================================================================================================================


    Private Sub lab(sender As Object, e As EventArgs) Handles Label15.Click
        Achat.Show()
        Me.Hide()
        Achat.BtnFerAchat.Enabled = False
        Achat.Button3.Enabled = False
        Achat.Button4.Enabled = False
    End Sub

    Private Sub B(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_idVente.Text = Nothing Or DateVente.Text = Nothing Or txt_qteVent.Text = Nothing Or txt_qteVent.Text = Nothing Or txtPrixAchat.Text = Nothing Or TxtPrixVent.Text = Nothing Or Combo_Mouvement.Text = Nothing Or txt_Vent_Rendu.Text = Nothing Or txt_Produit.Text = Nothing Or txt_id_Client.Text = Nothing Or txt_id_Client.Text = Nothing Or Txt_Note_vente.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else

            txt_idVente.Text = txt_idVente.Text + 1
            If MsgBox("vous voulez vraiment ajoutez? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) <> Windows.Forms.DialogResult.Yes Then
                Return
            End If
            cn.Open()
            cmd.CommandText = "insert into vente values ('" & txt_idVente.Text & "' ,'" & DateVente.Text & "' , '" & txt_qteVent.Text & "','" & Replace(txtPrixAchat.Text, ",", ".") & "' , '" & Replace(TxtPrixVent.Text, ",", ".") & "','" & Combo_Mouvement.Text & "' , '" & txt_Vent_Rendu.Text & "' ,'" & txt_Produit.Text & "' , '" & txt_id_Client.Text & "' , '" & Txt_id_users.Text & "' ,'" & Txt_Note_vente.Text & "') "
            cmd.ExecuteNonQuery()
            MsgBox("ajouter avec succes")
            cn.Close()
            affiche()
        End If
    End Sub

    Private Sub S(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_idVente.Text = Nothing Or DateVente.Text = Nothing Or txt_qteVent.Text = Nothing Or txt_qteVent.Text = Nothing Or txtPrixAchat.Text = Nothing Or TxtPrixVent.Text = Nothing Or Combo_Mouvement.Text = Nothing Or txt_Vent_Rendu.Text = Nothing Or txt_Produit.Text = Nothing Or txt_id_Client.Text = Nothing Or txt_id_Client.Text = Nothing Or Txt_Note_vente.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !")
        Else
            '' txt_idVente.Text = txt_idVente.Text - 1


            If MsgBox("vous voulez vraiment supprimer? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from vente where id_vente = '" & txt_idVente.Text & " '"
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succes")
                cn.Close()
                affiche()
                Dim str3 As String = "select max(id_vente)  from vente "

                cn.Open()
                cmd = New SqlCommand(str3, cn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txt_idVente.Text = dr.Item(0).ToString

                End If
                dr.Read()
                cn.Close()


            End If
        End If
    End Sub

    Private Sub U(sender As Object, e As EventArgs) Handles Button3.Click
        If txt_idVente.Text = Nothing Or DateVente.Text = Nothing Or txt_qteVent.Text = Nothing Or txt_qteVent.Text = Nothing Or txtPrixAchat.Text = Nothing Or TxtPrixVent.Text = Nothing Or Combo_Mouvement.Text = Nothing Or txt_Vent_Rendu.Text = Nothing Or txt_Produit.Text = Nothing Or txt_id_Client.Text = Nothing Or txt_id_Client.Text = Nothing Or Txt_Note_vente.Text = Nothing Then
            MsgBox("Remplir toutes les champs svp !!!!!")
        Else


            If MsgBox("vous voulez vraiment ajoutez? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) <> Windows.Forms.DialogResult.Yes Then
                Return
            End If
            cn.Open()
            cmd.CommandText = "update vente set id_vente = '" & txt_idVente.Text & "' ,date_vente ='" & DateVente.Text & "' , qte_achat ='" & txt_qteVent.Text & "',pu_achat ='" & Replace(txtPrixAchat.Text, ",", ".") & "' ,pu_vente= '" & Replace(TxtPrixVent.Text, ",", ".") & "',mouvement='" & Combo_Mouvement.Text & "' , m_vente ='" & txt_Vent_Rendu.Text & "' ,id_prod ='" & txt_Produit.Text & "' , id_client ='" & txt_id_Client.Text & "' ,id_users = '" & Txt_id_users.Text & "' ,note_vente ='" & Txt_Note_vente.Text & "'where id_vente ='" & txt_idVente.Text & "' "
            cmd.ExecuteNonQuery()
            MsgBox("modifier avec succes")
            cn.Close()
            affiche()
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        Dim str3 As String = "select max(id_vente)  from vente "

        cn.Open()
        cmd = New SqlCommand(str3, cn)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txt_idVente.Text = dr.Item(0).ToString

        End If
        dr.Read()
        cn.Close()
        Button2.Enabled = True
    End Sub


End Class