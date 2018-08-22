<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tirage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.matriculTxt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateTxt = New System.Windows.Forms.DateTimePicker()
        Me.dgTirage = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.numTxt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.phoneTxt = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.mandTxt = New System.Windows.Forms.TextBox()
        Me.membreTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.photoPic = New System.Windows.Forms.PictureBox()
        CType(Me.dgTirage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Calendrier  des  Remboursements"
        '
        'matriculTxt
        '
        Me.matriculTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matriculTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matriculTxt.FormattingEnabled = True
        Me.matriculTxt.Location = New System.Drawing.Point(117, 119)
        Me.matriculTxt.Name = "matriculTxt"
        Me.matriculTxt.Size = New System.Drawing.Size(284, 32)
        Me.matriculTxt.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Matricule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(62, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date"
        '
        'dateTxt
        '
        Me.dateTxt.Enabled = False
        Me.dateTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTxt.Location = New System.Drawing.Point(117, 73)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.Size = New System.Drawing.Size(284, 30)
        Me.dateTxt.TabIndex = 17
        '
        'dgTirage
        '
        Me.dgTirage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTirage.BackgroundColor = System.Drawing.Color.White
        Me.dgTirage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTirage.Location = New System.Drawing.Point(9, 368)
        Me.dgTirage.Name = "dgTirage"
        Me.dgTirage.Size = New System.Drawing.Size(1206, 251)
        Me.dgTirage.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(232, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 44)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(512, 318)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 44)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(786, 318)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 44)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'numTxt
        '
        Me.numTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.numTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTxt.FormattingEnabled = True
        Me.numTxt.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.numTxt.Location = New System.Drawing.Point(117, 26)
        Me.numTxt.Name = "numTxt"
        Me.numTxt.Size = New System.Drawing.Size(284, 32)
        Me.numTxt.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Numero tiré"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dateTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.numTxt)
        Me.GroupBox1.Controls.Add(Me.matriculTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 176)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tirage"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.phoneTxt)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.photoPic)
        Me.GroupBox2.Controls.Add(Me.phone)
        Me.GroupBox2.Controls.Add(Me.mandTxt)
        Me.GroupBox2.Controls.Add(Me.membreTxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(483, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(732, 244)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informations sur le Membre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(106, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "2."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(106, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 17)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "1."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(616, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Mandataire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(455, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Membre"
        '
        'phoneTxt
        '
        Me.phoneTxt.Enabled = False
        Me.phoneTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTxt.Location = New System.Drawing.Point(130, 155)
        Me.phoneTxt.Name = "phoneTxt"
        Me.phoneTxt.Size = New System.Drawing.Size(205, 30)
        Me.phoneTxt.TabIndex = 32
        '
        'phone
        '
        Me.phone.Enabled = False
        Me.phone.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.Location = New System.Drawing.Point(130, 119)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(205, 30)
        Me.phone.TabIndex = 29
        '
        'mandTxt
        '
        Me.mandTxt.Enabled = False
        Me.mandTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mandTxt.Location = New System.Drawing.Point(130, 65)
        Me.mandTxt.Name = "mandTxt"
        Me.mandTxt.Size = New System.Drawing.Size(205, 30)
        Me.mandTxt.TabIndex = 28
        '
        'membreTxt
        '
        Me.membreTxt.Enabled = False
        Me.membreTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.membreTxt.Location = New System.Drawing.Point(130, 29)
        Me.membreTxt.Name = "membreTxt"
        Me.membreTxt.Size = New System.Drawing.Size(205, 30)
        Me.membreTxt.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Contact"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Mandataire"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(46, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Membre"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.RISTOURNE.My.Resources.Resources._5
        Me.PictureBox2.Location = New System.Drawing.Point(583, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 192)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'photoPic
        '
        Me.photoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.photoPic.Image = Global.RISTOURNE.My.Resources.Resources._2_512
        Me.photoPic.Location = New System.Drawing.Point(415, 32)
        Me.photoPic.Name = "photoPic"
        Me.photoPic.Size = New System.Drawing.Size(143, 192)
        Me.photoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photoPic.TabIndex = 30
        Me.photoPic.TabStop = False
        '
        'Tirage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgTirage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tirage"
        Me.Size = New System.Drawing.Size(1231, 631)
        CType(Me.dgTirage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents matriculTxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dateTxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgTirage As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents numTxt As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents phoneTxt As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents photoPic As PictureBox
    Friend WithEvents phone As TextBox
    Friend WithEvents mandTxt As TextBox
    Friend WithEvents membreTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
