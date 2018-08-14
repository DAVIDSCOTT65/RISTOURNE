<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cotisation
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgCotisation = New System.Windows.Forms.DataGridView()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.suiviBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.identiteTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateTxt = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.matCombo = New System.Windows.Forms.ComboBox()
        Me.fonctionTxt = New System.Windows.Forms.TextBox()
        Me.montantTxt = New System.Windows.Forms.TextBox()
        Me.arriereTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgCotisation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cotisation"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1005, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Rechercher"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgCotisation
        '
        Me.dgCotisation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCotisation.BackgroundColor = System.Drawing.Color.White
        Me.dgCotisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCotisation.GridColor = System.Drawing.Color.White
        Me.dgCotisation.Location = New System.Drawing.Point(39, 426)
        Me.dgCotisation.Name = "dgCotisation"
        Me.dgCotisation.Size = New System.Drawing.Size(1171, 189)
        Me.dgCotisation.TabIndex = 15
        '
        'searchTxt
        '
        Me.searchTxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTxt.Location = New System.Drawing.Point(111, 381)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(888, 30)
        Me.searchTxt.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.suiviBtn)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.identiteTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dateTxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.matCombo)
        Me.GroupBox1.Controls.Add(Me.fonctionTxt)
        Me.GroupBox1.Controls.Add(Me.montantTxt)
        Me.GroupBox1.Controls.Add(Me.arriereTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(39, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1171, 280)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotisation"
        '
        'suiviBtn
        '
        Me.suiviBtn.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.suiviBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suiviBtn.ForeColor = System.Drawing.Color.Black
        Me.suiviBtn.Location = New System.Drawing.Point(878, 208)
        Me.suiviBtn.Name = "suiviBtn"
        Me.suiviBtn.Size = New System.Drawing.Size(265, 55)
        Me.suiviBtn.TabIndex = 48
        Me.suiviBtn.Text = "Fiche de suivi"
        Me.suiviBtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(1037, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 24)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(1037, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 24)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1037, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 24)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "$"
        '
        'identiteTxt
        '
        Me.identiteTxt.Enabled = False
        Me.identiteTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identiteTxt.ForeColor = System.Drawing.Color.Black
        Me.identiteTxt.Location = New System.Drawing.Point(197, 90)
        Me.identiteTxt.Name = "identiteTxt"
        Me.identiteTxt.Size = New System.Drawing.Size(316, 32)
        Me.identiteTxt.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(103, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Matricul"
        '
        'dateTxt
        '
        Me.dateTxt.Enabled = False
        Me.dateTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTxt.Location = New System.Drawing.Point(197, 140)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.Size = New System.Drawing.Size(316, 32)
        Me.dateTxt.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(142, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 24)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Date"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(600, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(262, 55)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(312, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(265, 55)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(19, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(262, 55)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Enregistrer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'matCombo
        '
        Me.matCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matCombo.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matCombo.FormattingEnabled = True
        Me.matCombo.Location = New System.Drawing.Point(197, 40)
        Me.matCombo.Name = "matCombo"
        Me.matCombo.Size = New System.Drawing.Size(316, 33)
        Me.matCombo.TabIndex = 38
        '
        'fonctionTxt
        '
        Me.fonctionTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fonctionTxt.Location = New System.Drawing.Point(715, 139)
        Me.fonctionTxt.Name = "fonctionTxt"
        Me.fonctionTxt.Size = New System.Drawing.Size(316, 32)
        Me.fonctionTxt.TabIndex = 37
        Me.fonctionTxt.Text = "3"
        '
        'montantTxt
        '
        Me.montantTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montantTxt.Location = New System.Drawing.Point(715, 92)
        Me.montantTxt.Name = "montantTxt"
        Me.montantTxt.Size = New System.Drawing.Size(316, 32)
        Me.montantTxt.TabIndex = 36
        Me.montantTxt.Text = "0"
        '
        'arriereTxt
        '
        Me.arriereTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arriereTxt.ForeColor = System.Drawing.Color.Black
        Me.arriereTxt.Location = New System.Drawing.Point(715, 42)
        Me.arriereTxt.Name = "arriereTxt"
        Me.arriereTxt.Size = New System.Drawing.Size(316, 32)
        Me.arriereTxt.TabIndex = 35
        Me.arriereTxt.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(108, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Identité"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(635, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Amende"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(626, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 24)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Montant"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(555, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Fonctionnement"
        '
        'Cotisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.dgCotisation)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cotisation"
        Me.Size = New System.Drawing.Size(1231, 631)
        CType(Me.dgCotisation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgCotisation As System.Windows.Forms.DataGridView
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents identiteTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dateTxt As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents matCombo As ComboBox
    Friend WithEvents fonctionTxt As TextBox
    Friend WithEvents montantTxt As TextBox
    Friend WithEvents arriereTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents suiviBtn As Button
End Class
