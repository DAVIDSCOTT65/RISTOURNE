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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.codeCo = New System.Windows.Forms.Label()
        Me.montantCo = New System.Windows.Forms.Label()
        Me.socialCo = New System.Windows.Forms.Label()
        Me.dateCo = New System.Windows.Forms.Label()
        Me.amendeCo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgCotisation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.dgCotisation.AllowUserToAddRows = False
        Me.dgCotisation.AllowUserToDeleteRows = False
        Me.dgCotisation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCotisation.BackgroundColor = System.Drawing.Color.White
        Me.dgCotisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCotisation.GridColor = System.Drawing.Color.White
        Me.dgCotisation.Location = New System.Drawing.Point(28, 428)
        Me.dgCotisation.Name = "dgCotisation"
        Me.dgCotisation.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCotisation.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCotisation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 280)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nouvelle cotisation"
        '
        'suiviBtn
        '
        Me.suiviBtn.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.suiviBtn.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suiviBtn.ForeColor = System.Drawing.Color.Black
        Me.suiviBtn.Location = New System.Drawing.Point(200, 208)
        Me.suiviBtn.Name = "suiviBtn"
        Me.suiviBtn.Size = New System.Drawing.Size(198, 55)
        Me.suiviBtn.TabIndex = 48
        Me.suiviBtn.Text = "Fiche de suivi"
        Me.suiviBtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(571, 98)
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
        Me.Label9.Location = New System.Drawing.Point(571, 146)
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
        Me.Label7.Location = New System.Drawing.Point(571, 49)
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
        Me.identiteTxt.Location = New System.Drawing.Point(102, 94)
        Me.identiteTxt.Name = "identiteTxt"
        Me.identiteTxt.Size = New System.Drawing.Size(265, 32)
        Me.identiteTxt.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Identité"
        '
        'dateTxt
        '
        Me.dateTxt.Enabled = False
        Me.dateTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTxt.Location = New System.Drawing.Point(102, 144)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.Size = New System.Drawing.Size(265, 32)
        Me.dateTxt.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(57, 146)
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
        Me.Button4.Location = New System.Drawing.Point(423, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 55)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(216, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 55)
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
        Me.Button2.Size = New System.Drawing.Size(191, 55)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Enregistrer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'matCombo
        '
        Me.matCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matCombo.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matCombo.FormattingEnabled = True
        Me.matCombo.Location = New System.Drawing.Point(102, 44)
        Me.matCombo.Name = "matCombo"
        Me.matCombo.Size = New System.Drawing.Size(265, 33)
        Me.matCombo.TabIndex = 38
        '
        'fonctionTxt
        '
        Me.fonctionTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fonctionTxt.Location = New System.Drawing.Point(468, 142)
        Me.fonctionTxt.Name = "fonctionTxt"
        Me.fonctionTxt.Size = New System.Drawing.Size(108, 32)
        Me.fonctionTxt.TabIndex = 37
        Me.fonctionTxt.Text = "3"
        '
        'montantTxt
        '
        Me.montantTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montantTxt.Location = New System.Drawing.Point(468, 95)
        Me.montantTxt.Name = "montantTxt"
        Me.montantTxt.Size = New System.Drawing.Size(108, 32)
        Me.montantTxt.TabIndex = 36
        Me.montantTxt.Text = "0"
        '
        'arriereTxt
        '
        Me.arriereTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arriereTxt.ForeColor = System.Drawing.Color.Black
        Me.arriereTxt.Location = New System.Drawing.Point(468, 45)
        Me.arriereTxt.Name = "arriereTxt"
        Me.arriereTxt.Size = New System.Drawing.Size(108, 32)
        Me.arriereTxt.TabIndex = 35
        Me.arriereTxt.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Matricule"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(392, 48)
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
        Me.Label5.Location = New System.Drawing.Point(388, 98)
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
        Me.Label6.Location = New System.Drawing.Point(407, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Social"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.amendeCo)
        Me.GroupBox2.Controls.Add(Me.dateCo)
        Me.GroupBox2.Controls.Add(Me.socialCo)
        Me.GroupBox2.Controls.Add(Me.montantCo)
        Me.GroupBox2.Controls.Add(Me.codeCo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.suiviBtn)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(629, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(590, 280)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last Cotisation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(9, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 24)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Code"
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
        Me.Label17.Location = New System.Drawing.Point(252, 36)
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
        Me.Label18.Location = New System.Drawing.Point(239, 86)
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
        Me.Label19.Location = New System.Drawing.Point(239, 143)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 24)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Observation"
        '
        'codeCo
        '
        Me.codeCo.AutoSize = True
        Me.codeCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.codeCo.Location = New System.Drawing.Point(113, 40)
        Me.codeCo.Name = "codeCo"
        Me.codeCo.Size = New System.Drawing.Size(40, 24)
        Me.codeCo.TabIndex = 49
        Me.codeCo.Text = "xxx"
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
        'dateCo
        '
        Me.dateCo.AutoSize = True
        Me.dateCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dateCo.Location = New System.Drawing.Point(372, 40)
        Me.dateCo.Name = "dateCo"
        Me.dateCo.Size = New System.Drawing.Size(40, 24)
        Me.dateCo.TabIndex = 52
        Me.dateCo.Text = "xxx"
        '
        'amendeCo
        '
        Me.amendeCo.AutoSize = True
        Me.amendeCo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amendeCo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.amendeCo.Location = New System.Drawing.Point(372, 86)
        Me.amendeCo.Name = "amendeCo"
        Me.amendeCo.Size = New System.Drawing.Size(40, 24)
        Me.amendeCo.TabIndex = 53
        Me.amendeCo.Text = "xxx"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(372, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 24)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Code"
        '
        'Cotisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.GroupBox2)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents amendeCo As Label
    Friend WithEvents dateCo As Label
    Friend WithEvents socialCo As Label
    Friend WithEvents montantCo As Label
    Friend WithEvents codeCo As Label
End Class
