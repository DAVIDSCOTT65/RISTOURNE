<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Remboursement
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
        Me.numTxt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateRemb = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.montantTxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgRemb = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.codeCotisation = New System.Windows.Forms.Label()
        Me.amendeCo = New System.Windows.Forms.Label()
        Me.dateCo = New System.Windows.Forms.Label()
        Me.socialCo = New System.Windows.Forms.Label()
        Me.montantCo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.caisseLab = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.codeCo = New System.Windows.Forms.Label()
        Me.identiteTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgRemb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Remboursement"
        '
        'numTxt
        '
        Me.numTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.numTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTxt.FormattingEnabled = True
        Me.numTxt.Location = New System.Drawing.Point(130, 37)
        Me.numTxt.Name = "numTxt"
        Me.numTxt.Size = New System.Drawing.Size(270, 32)
        Me.numTxt.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Numero Tiré"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Date"
        '
        'dateRemb
        '
        Me.dateRemb.Enabled = False
        Me.dateRemb.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRemb.Location = New System.Drawing.Point(130, 90)
        Me.dateRemb.Name = "dateRemb"
        Me.dateRemb.Size = New System.Drawing.Size(270, 30)
        Me.dateRemb.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Montant"
        '
        'montantTxt
        '
        Me.montantTxt.Enabled = False
        Me.montantTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montantTxt.Location = New System.Drawing.Point(130, 136)
        Me.montantTxt.Name = "montantTxt"
        Me.montantTxt.Size = New System.Drawing.Size(270, 30)
        Me.montantTxt.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(143, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 36)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Rembourser"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgRemb
        '
        Me.dgRemb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRemb.BackgroundColor = System.Drawing.Color.White
        Me.dgRemb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRemb.Location = New System.Drawing.Point(29, 408)
        Me.dgRemb.Name = "dgRemb"
        Me.dgRemb.Size = New System.Drawing.Size(1180, 206)
        Me.dgRemb.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.identiteTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.montantTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.numTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dateRemb)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 280)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vérification du numéro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(406, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 24)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "$"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(86, 372)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(934, 30)
        Me.TextBox4.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1026, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 36)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(132, 212)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(275, 36)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Fiche des Remboursements"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(406, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Attention"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.codeCotisation)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.amendeCo)
        Me.GroupBox2.Controls.Add(Me.dateCo)
        Me.GroupBox2.Controls.Add(Me.socialCo)
        Me.GroupBox2.Controls.Add(Me.montantCo)
        Me.GroupBox2.Controls.Add(Me.codeCo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(506, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 280)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last Cotisation"
        '
        'codeCotisation
        '
        Me.codeCotisation.AutoSize = True
        Me.codeCotisation.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeCotisation.ForeColor = System.Drawing.Color.Blue
        Me.codeCotisation.Location = New System.Drawing.Point(113, 40)
        Me.codeCotisation.Name = "codeCotisation"
        Me.codeCotisation.Size = New System.Drawing.Size(40, 24)
        Me.codeCotisation.TabIndex = 54
        Me.codeCotisation.Text = "xxx"
        '
        'amendeCo
        '
        Me.amendeCo.AutoSize = True
        Me.amendeCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amendeCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.amendeCo.Location = New System.Drawing.Point(314, 90)
        Me.amendeCo.Name = "amendeCo"
        Me.amendeCo.Size = New System.Drawing.Size(40, 24)
        Me.amendeCo.TabIndex = 53
        Me.amendeCo.Text = "xxx"
        '
        'dateCo
        '
        Me.dateCo.AutoSize = True
        Me.dateCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dateCo.Location = New System.Drawing.Point(314, 37)
        Me.dateCo.Name = "dateCo"
        Me.dateCo.Size = New System.Drawing.Size(40, 24)
        Me.dateCo.TabIndex = 52
        Me.dateCo.Text = "xxx"
        '
        'socialCo
        '
        Me.socialCo.AutoSize = True
        Me.socialCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.socialCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.socialCo.Location = New System.Drawing.Point(113, 143)
        Me.socialCo.Name = "socialCo"
        Me.socialCo.Size = New System.Drawing.Size(40, 24)
        Me.socialCo.TabIndex = 51
        Me.socialCo.Text = "xxx"
        '
        'montantCo
        '
        Me.montantCo.AutoSize = True
        Me.montantCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montantCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.montantCo.Location = New System.Drawing.Point(113, 90)
        Me.montantCo.Name = "montantCo"
        Me.montantCo.Size = New System.Drawing.Size(40, 24)
        Me.montantCo.TabIndex = 50
        Me.montantCo.Text = "xxx"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(9, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 24)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Numero"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(14, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 24)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Social"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(14, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 24)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Montant"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(219, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 24)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(206, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 24)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Amende"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(200, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 24)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Observer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.caisseLab)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(1026, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 280)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tontine"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 27.75!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(148, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 44)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "$"
        '
        'caisseLab
        '
        Me.caisseLab.AutoSize = True
        Me.caisseLab.Font = New System.Drawing.Font("Poor Richard", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caisseLab.ForeColor = System.Drawing.Color.White
        Me.caisseLab.Location = New System.Drawing.Point(29, 113)
        Me.caisseLab.Name = "caisseLab"
        Me.caisseLab.Size = New System.Drawing.Size(39, 44)
        Me.caisseLab.TabIndex = 31
        Me.caisseLab.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(33, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 24)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "A remboursé :"
        '
        'codeCo
        '
        Me.codeCo.AutoSize = True
        Me.codeCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.codeCo.Location = New System.Drawing.Point(304, 143)
        Me.codeCo.Name = "codeCo"
        Me.codeCo.Size = New System.Drawing.Size(40, 24)
        Me.codeCo.TabIndex = 49
        Me.codeCo.Text = "xxx"
        '
        'identiteTxt
        '
        Me.identiteTxt.Enabled = False
        Me.identiteTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identiteTxt.ForeColor = System.Drawing.Color.Black
        Me.identiteTxt.Location = New System.Drawing.Point(130, 181)
        Me.identiteTxt.Name = "identiteTxt"
        Me.identiteTxt.Size = New System.Drawing.Size(265, 32)
        Me.identiteTxt.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(41, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Matricule"
        '
        'Remboursement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgRemb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Remboursement"
        Me.Size = New System.Drawing.Size(1231, 631)
        CType(Me.dgRemb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numTxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateRemb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents montantTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgRemb As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents codeCotisation As Label
    Friend WithEvents amendeCo As Label
    Friend WithEvents dateCo As Label
    Friend WithEvents socialCo As Label
    Friend WithEvents montantCo As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents caisseLab As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents codeCo As Label
    Friend WithEvents identiteTxt As TextBox
    Friend WithEvents Label6 As Label
End Class
