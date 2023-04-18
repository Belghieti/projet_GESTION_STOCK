<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vente
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vente))
        Me.DateVente = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtNomProduit = New System.Windows.Forms.TextBox()
        Me.txt_idVente = New System.Windows.Forms.TextBox()
        Me.ComboVent = New System.Windows.Forms.ComboBox()
        Me.Combo_Mouvement = New System.Windows.Forms.ComboBox()
        Me.Txt_Note_vente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_id_users = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrixVent = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrixAchat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id_Client = New System.Windows.Forms.TextBox()
        Me.txt_Produit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_qteVent = New System.Windows.Forms.TextBox()
        Me.txt_Vent_Rendu = New System.Windows.Forms.TextBox()
        Me.Comboresach = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblTotalJour = New System.Windows.Forms.Label()
        Me.LabProdui = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblTotalQte = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnFerm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateVente
        '
        Me.DateVente.CustomFormat = "yyyy/MM/dd"
        Me.DateVente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateVente.Location = New System.Drawing.Point(497, 99)
        Me.DateVente.Name = "DateVente"
        Me.DateVente.Size = New System.Drawing.Size(174, 20)
        Me.DateVente.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TxtNomProduit)
        Me.Panel1.Controls.Add(Me.txt_idVente)
        Me.Panel1.Controls.Add(Me.ComboVent)
        Me.Panel1.Controls.Add(Me.Combo_Mouvement)
        Me.Panel1.Controls.Add(Me.Txt_Note_vente)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Txt_id_users)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtPrixVent)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DateVente)
        Me.Panel1.Controls.Add(Me.txtPrixAchat)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_id_Client)
        Me.Panel1.Controls.Add(Me.txt_Produit)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_qteVent)
        Me.Panel1.Controls.Add(Me.txt_Vent_Rendu)
        Me.Panel1.Location = New System.Drawing.Point(7, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 321)
        Me.Panel1.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(368, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 15)
        Me.Label19.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(309, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Label18"
        Me.Label18.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(309, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Label17"
        Me.Label17.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(181, 292)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(174, 26)
        Me.TextBox2.TabIndex = 34
        '
        'TxtNomProduit
        '
        Me.TxtNomProduit.BackColor = System.Drawing.Color.White
        Me.TxtNomProduit.Enabled = False
        Me.TxtNomProduit.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProduit.ForeColor = System.Drawing.Color.Black
        Me.TxtNomProduit.Location = New System.Drawing.Point(13, 292)
        Me.TxtNomProduit.Name = "TxtNomProduit"
        Me.TxtNomProduit.Size = New System.Drawing.Size(174, 26)
        Me.TxtNomProduit.TabIndex = 33
        '
        'txt_idVente
        '
        Me.txt_idVente.Enabled = False
        Me.txt_idVente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idVente.Location = New System.Drawing.Point(132, 51)
        Me.txt_idVente.Name = "txt_idVente"
        Me.txt_idVente.Size = New System.Drawing.Size(174, 26)
        Me.txt_idVente.TabIndex = 31
        '
        'ComboVent
        '
        Me.ComboVent.FormattingEnabled = True
        Me.ComboVent.Location = New System.Drawing.Point(168, 94)
        Me.ComboVent.Name = "ComboVent"
        Me.ComboVent.Size = New System.Drawing.Size(186, 21)
        Me.ComboVent.TabIndex = 30
        '
        'Combo_Mouvement
        '
        Me.Combo_Mouvement.FormattingEnabled = True
        Me.Combo_Mouvement.Items.AddRange(New Object() {"paye ", "nonpaye"})
        Me.Combo_Mouvement.Location = New System.Drawing.Point(499, 54)
        Me.Combo_Mouvement.Name = "Combo_Mouvement"
        Me.Combo_Mouvement.Size = New System.Drawing.Size(174, 21)
        Me.Combo_Mouvement.TabIndex = 29
        Me.Combo_Mouvement.Text = "paye"
        '
        'Txt_Note_vente
        '
        Me.Txt_Note_vente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Note_vente.Location = New System.Drawing.Point(498, 228)
        Me.Txt_Note_vente.Name = "Txt_Note_vente"
        Me.Txt_Note_vente.Size = New System.Drawing.Size(174, 26)
        Me.Txt_Note_vente.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.CadetBlue
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(399, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 22)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Note_vente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.CadetBlue
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(397, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 22)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Mouvement"
        '
        'Txt_id_users
        '
        Me.Txt_id_users.Enabled = False
        Me.Txt_id_users.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_id_users.Location = New System.Drawing.Point(498, 184)
        Me.Txt_id_users.Name = "Txt_id_users"
        Me.Txt_id_users.Size = New System.Drawing.Size(174, 26)
        Me.Txt_id_users.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.CadetBlue
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(399, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "id_users"
        '
        'TxtPrixVent
        '
        Me.TxtPrixVent.Enabled = False
        Me.TxtPrixVent.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrixVent.Location = New System.Drawing.Point(131, 161)
        Me.TxtPrixVent.Name = "TxtPrixVent"
        Me.TxtPrixVent.Size = New System.Drawing.Size(174, 26)
        Me.TxtPrixVent.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CadetBlue
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(9, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 22)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "prix vente"
        '
        'txtPrixAchat
        '
        Me.txtPrixAchat.Enabled = False
        Me.txtPrixAchat.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrixAchat.Location = New System.Drawing.Point(131, 128)
        Me.txtPrixAchat.Name = "txtPrixAchat"
        Me.txtPrixAchat.Size = New System.Drawing.Size(174, 26)
        Me.txtPrixAchat.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.CadetBlue
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(9, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "prix achat"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CadetBlue
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(291, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 34)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "supprimer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CadetBlue
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(191, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 34)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "modifier"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CadetBlue
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(88, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "enrgistrer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(7, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "NV"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_Vente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(399, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "date_Vente"
        '
        'txt_id_Client
        '
        Me.txt_id_Client.BackColor = System.Drawing.Color.White
        Me.txt_id_Client.Enabled = False
        Me.txt_id_Client.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Client.Location = New System.Drawing.Point(498, 145)
        Me.txt_id_Client.Name = "txt_id_Client"
        Me.txt_id_Client.Size = New System.Drawing.Size(174, 26)
        Me.txt_id_Client.TabIndex = 11
        Me.txt_id_Client.Text = "1"
        '
        'txt_Produit
        '
        Me.txt_Produit.Enabled = False
        Me.txt_Produit.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Produit.Location = New System.Drawing.Point(133, 93)
        Me.txt_Produit.Name = "txt_Produit"
        Me.txt_Produit.Size = New System.Drawing.Size(29, 26)
        Me.txt_Produit.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Qte_Vente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(399, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "id_Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CadetBlue
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(10, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "M_vente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.CadetBlue
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(7, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "id_produit"
        '
        'txt_qteVent
        '
        Me.txt_qteVent.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qteVent.Location = New System.Drawing.Point(135, 202)
        Me.txt_qteVent.Name = "txt_qteVent"
        Me.txt_qteVent.Size = New System.Drawing.Size(174, 26)
        Me.txt_qteVent.TabIndex = 6
        '
        'txt_Vent_Rendu
        '
        Me.txt_Vent_Rendu.Enabled = False
        Me.txt_Vent_Rendu.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vent_Rendu.Location = New System.Drawing.Point(136, 245)
        Me.txt_Vent_Rendu.Name = "txt_Vent_Rendu"
        Me.txt_Vent_Rendu.Size = New System.Drawing.Size(174, 26)
        Me.txt_Vent_Rendu.TabIndex = 7
        '
        'Comboresach
        '
        Me.Comboresach.FormattingEnabled = True
        Me.Comboresach.Items.AddRange(New Object() {"id_vente", "date_vente", "id_prod", "id_users", "id_client"})
        Me.Comboresach.Location = New System.Drawing.Point(120, 20)
        Me.Comboresach.Name = "Comboresach"
        Me.Comboresach.Size = New System.Drawing.Size(147, 21)
        Me.Comboresach.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "rechercher par "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Comboresach)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(12, 367)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(411, 46)
        Me.Panel4.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(273, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.CadetBlue
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(228, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(227, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Developper par MOHAMED BELGHIETI"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.LblTotalJour)
        Me.Panel3.Controls.Add(Me.LabProdui)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Lbl)
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.LblTotalQte)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 557)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 36)
        Me.Panel3.TabIndex = 30
        '
        'LblTotalJour
        '
        Me.LblTotalJour.AutoSize = True
        Me.LblTotalJour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalJour.ForeColor = System.Drawing.Color.Transparent
        Me.LblTotalJour.Location = New System.Drawing.Point(602, 12)
        Me.LblTotalJour.Name = "LblTotalJour"
        Me.LblTotalJour.Size = New System.Drawing.Size(62, 16)
        Me.LblTotalJour.TabIndex = 38
        Me.LblTotalJour.Text = "Label15"
        '
        'LabProdui
        '
        Me.LabProdui.AutoSize = True
        Me.LabProdui.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabProdui.ForeColor = System.Drawing.Color.Transparent
        Me.LabProdui.Location = New System.Drawing.Point(471, 12)
        Me.LabProdui.Name = "LabProdui"
        Me.LabProdui.Size = New System.Drawing.Size(62, 16)
        Me.LabProdui.TabIndex = 37
        Me.LabProdui.Text = "Label15"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl.Location = New System.Drawing.Point(313, 12)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(62, 16)
        Me.Lbl.TabIndex = 36
        Me.Lbl.Text = "Label15"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Transparent
        Me.LblTotal.Location = New System.Drawing.Point(3, 12)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(62, 16)
        Me.LblTotal.TabIndex = 34
        Me.LblTotal.Text = "Label15"
        '
        'LblTotalQte
        '
        Me.LblTotalQte.AutoSize = True
        Me.LblTotalQte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalQte.ForeColor = System.Drawing.Color.Transparent
        Me.LblTotalQte.Location = New System.Drawing.Point(152, 12)
        Me.LblTotalQte.Name = "LblTotalQte"
        Me.LblTotalQte.Size = New System.Drawing.Size(62, 16)
        Me.LblTotalQte.TabIndex = 35
        Me.LblTotalQte.Text = "Label15"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Silver
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(7, 428)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(781, 165)
        Me.ListView1.TabIndex = 28
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id_Vente"
        Me.ColumnHeader1.Width = 79
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date_vente"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qte_vente"
        Me.ColumnHeader3.Width = 44
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "prix_achat"
        Me.ColumnHeader4.Width = 35
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "prix_vente"
        Me.ColumnHeader5.Width = 67
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mouvement"
        Me.ColumnHeader6.Width = 45
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "M_vente"
        Me.ColumnHeader7.Width = 62
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Id_produit"
        Me.ColumnHeader8.Width = 52
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Id_client"
        Me.ColumnHeader9.Width = 68
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Id_users"
        Me.ColumnHeader10.Width = 89
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Note_vent"
        Me.ColumnHeader11.Width = 120
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.CadetBlue
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(297, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 22)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Gestion de Vente"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.BtnFerm)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 34)
        Me.Panel2.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(504, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 18)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.CadetBlue
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(36, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 22)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "GO TO ACHAT"
        '
        'BtnFerm
        '
        Me.BtnFerm.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnFerm.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFerm.ForeColor = System.Drawing.Color.Transparent
        Me.BtnFerm.Location = New System.Drawing.Point(725, 0)
        Me.BtnFerm.Name = "BtnFerm"
        Me.BtnFerm.Size = New System.Drawing.Size(75, 34)
        Me.BtnFerm.TabIndex = 20
        Me.BtnFerm.Text = "Fermer"
        Me.BtnFerm.UseVisualStyleBackColor = False
        '
        'vente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.G_Stock.My.Resources.Resources._4
        Me.ClientSize = New System.Drawing.Size(800, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "vente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "vente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateVente As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPrixAchat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id_Client As TextBox
    Friend WithEvents txt_Produit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_qteVent As TextBox
    Friend WithEvents txt_Vent_Rendu As TextBox
    Friend WithEvents Comboresach As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtPrixVent As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_id_users As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_Note_vente As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Combo_Mouvement As ComboBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblTotalQte As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents LabProdui As Label
    Friend WithEvents BtnFerm As Button
    Friend WithEvents ComboVent As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblTotalJour As Label
    Friend WithEvents txt_idVente As TextBox
    Friend WithEvents TxtNomProduit As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
