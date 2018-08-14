<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Membre
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMembre = New System.Windows.Forms.DataGridView()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.photoBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.professionCombo = New System.Windows.Forms.ComboBox()
        Me.sexeCombo = New System.Windows.Forms.ComboBox()
        Me.telephoneTxt = New System.Windows.Forms.TextBox()
        Me.adresseTxt = New System.Windows.Forms.TextBox()
        Me.postnomTxt = New System.Windows.Forms.TextBox()
        Me.nomTxt = New System.Windows.Forms.TextBox()
        Me.codeTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mailTxt = New System.Windows.Forms.TextBox()
        Me.carteTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lienCombo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.telephoneMand = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mandataireTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgMembre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Membres"
        '
        'dgMembre
        '
        Me.dgMembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMembre.BackgroundColor = System.Drawing.Color.White
        Me.dgMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMembre.Location = New System.Drawing.Point(17, 413)
        Me.dgMembre.Name = "dgMembre"
        Me.dgMembre.Size = New System.Drawing.Size(1197, 205)
        Me.dgMembre.TabIndex = 24
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(160, 368)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(215, 39)
        Me.saveBtn.TabIndex = 25
        Me.saveBtn.Text = "Enregistrer"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.White
        Me.updateBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(483, 368)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(215, 39)
        Me.updateBtn.TabIndex = 26
        Me.updateBtn.Text = "Modifier"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.White
        Me.deleteBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(821, 368)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(215, 39)
        Me.deleteBtn.TabIndex = 27
        Me.deleteBtn.Text = "Supprimer"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.photoBtn)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.professionCombo)
        Me.GroupBox1.Controls.Add(Me.sexeCombo)
        Me.GroupBox1.Controls.Add(Me.telephoneTxt)
        Me.GroupBox1.Controls.Add(Me.adresseTxt)
        Me.GroupBox1.Controls.Add(Me.postnomTxt)
        Me.GroupBox1.Controls.Add(Me.nomTxt)
        Me.GroupBox1.Controls.Add(Me.codeTxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 306)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Infos sur le Membre (Obligatoire)"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(334, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 33)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Camera"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'photoBtn
        '
        Me.photoBtn.BackColor = System.Drawing.Color.White
        Me.photoBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photoBtn.ForeColor = System.Drawing.Color.Black
        Me.photoBtn.Location = New System.Drawing.Point(418, 258)
        Me.photoBtn.Name = "photoBtn"
        Me.photoBtn.Size = New System.Drawing.Size(102, 33)
        Me.photoBtn.TabIndex = 33
        Me.photoBtn.Text = "Parcourir "
        Me.photoBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(334, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'professionCombo
        '
        Me.professionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.professionCombo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.professionCombo.FormattingEnabled = True
        Me.professionCombo.Items.AddRange(New Object() {"COMMERCANT", "TRAVAILLEUR"})
        Me.professionCombo.Location = New System.Drawing.Point(123, 184)
        Me.professionCombo.Name = "professionCombo"
        Me.professionCombo.Size = New System.Drawing.Size(205, 32)
        Me.professionCombo.TabIndex = 31
        '
        'sexeCombo
        '
        Me.sexeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexeCombo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexeCombo.FormattingEnabled = True
        Me.sexeCombo.Items.AddRange(New Object() {"M", "F"})
        Me.sexeCombo.Location = New System.Drawing.Point(123, 146)
        Me.sexeCombo.Name = "sexeCombo"
        Me.sexeCombo.Size = New System.Drawing.Size(205, 32)
        Me.sexeCombo.TabIndex = 30
        '
        'telephoneTxt
        '
        Me.telephoneTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephoneTxt.Location = New System.Drawing.Point(123, 258)
        Me.telephoneTxt.Name = "telephoneTxt"
        Me.telephoneTxt.Size = New System.Drawing.Size(205, 32)
        Me.telephoneTxt.TabIndex = 29
        '
        'adresseTxt
        '
        Me.adresseTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.adresseTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresseTxt.Location = New System.Drawing.Point(123, 222)
        Me.adresseTxt.Name = "adresseTxt"
        Me.adresseTxt.Size = New System.Drawing.Size(205, 32)
        Me.adresseTxt.TabIndex = 28
        '
        'postnomTxt
        '
        Me.postnomTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.postnomTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postnomTxt.Location = New System.Drawing.Point(123, 110)
        Me.postnomTxt.Name = "postnomTxt"
        Me.postnomTxt.Size = New System.Drawing.Size(205, 32)
        Me.postnomTxt.TabIndex = 27
        '
        'nomTxt
        '
        Me.nomTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nomTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomTxt.Location = New System.Drawing.Point(123, 74)
        Me.nomTxt.Name = "nomTxt"
        Me.nomTxt.Size = New System.Drawing.Size(205, 32)
        Me.nomTxt.TabIndex = 26
        '
        'codeTxt
        '
        Me.codeTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeTxt.Location = New System.Drawing.Point(123, 38)
        Me.codeTxt.Name = "codeTxt"
        Me.codeTxt.Size = New System.Drawing.Size(205, 32)
        Me.codeTxt.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(22, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Téléphone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Matricule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nom, Pnom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Prénom"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(46, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Adresse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(72, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Sexe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Profession"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.mailTxt)
        Me.GroupBox2.Controls.Add(Me.carteTxt)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lienCombo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.telephoneMand)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.mandataireTxt)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(563, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 305)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Infos sur le Mandataire (Faculcatifs)"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(412, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 36)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Camera"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(43, 190)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 24)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Adresse mail"
        '
        'mailTxt
        '
        Me.mailTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailTxt.Location = New System.Drawing.Point(159, 187)
        Me.mailTxt.Name = "mailTxt"
        Me.mailTxt.Size = New System.Drawing.Size(247, 32)
        Me.mailTxt.TabIndex = 40
        '
        'carteTxt
        '
        Me.carteTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carteTxt.Location = New System.Drawing.Point(159, 151)
        Me.carteTxt.Name = "carteTxt"
        Me.carteTxt.Size = New System.Drawing.Size(247, 32)
        Me.carteTxt.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(23, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 24)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Carte d'electeur"
        '
        'lienCombo
        '
        Me.lienCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lienCombo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lienCombo.FormattingEnabled = True
        Me.lienCombo.Items.AddRange(New Object() {"Mari (e)", "Frère", "Soeur", "Femme", "Enfant", "Cousin", "Cousinne", "Ami(e)"})
        Me.lienCombo.Location = New System.Drawing.Point(159, 113)
        Me.lienCombo.Name = "lienCombo"
        Me.lienCombo.Size = New System.Drawing.Size(247, 32)
        Me.lienCombo.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(103, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 24)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Lien"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(502, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 36)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Parcourir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(412, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 208)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'telephoneMand
        '
        Me.telephoneMand.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephoneMand.Location = New System.Drawing.Point(159, 77)
        Me.telephoneMand.Name = "telephoneMand"
        Me.telephoneMand.Size = New System.Drawing.Size(247, 32)
        Me.telephoneMand.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(45, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Mandataire"
        '
        'mandataireTxt
        '
        Me.mandataireTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mandataireTxt.Location = New System.Drawing.Point(159, 41)
        Me.mandataireTxt.Name = "mandataireTxt"
        Me.mandataireTxt.Size = New System.Drawing.Size(247, 32)
        Me.mandataireTxt.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(57, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Téléphone"
        '
        'Membre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.dgMembre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Membre"
        Me.Size = New System.Drawing.Size(1231, 631)
        CType(Me.dgMembre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMembre As System.Windows.Forms.DataGridView
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents photoBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents professionCombo As ComboBox
    Friend WithEvents sexeCombo As ComboBox
    Friend WithEvents telephoneTxt As TextBox
    Friend WithEvents adresseTxt As TextBox
    Friend WithEvents postnomTxt As TextBox
    Friend WithEvents nomTxt As TextBox
    Friend WithEvents codeTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents mailTxt As TextBox
    Friend WithEvents carteTxt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lienCombo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents telephoneMand As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mandataireTxt As TextBox
    Friend WithEvents Label10 As Label
End Class
