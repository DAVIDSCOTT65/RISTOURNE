Public Class Form1
    Public test As Boolean
    Dim membre As New ClassMembre
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Sub change(ByRef userc As UserControl)
        Try
            userc.Dock = DockStyle.Fill
            Container.Controls.Clear()
            Container.Controls.Add(userc)
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("Acces Limite", "Vous ne disposez pas le niveau necessaire", 0)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As New Membre
        change(m)
    End Sub

    Private Sub dateNow_Click(sender As Object, e As EventArgs) Handles dateNow.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As New Cotisation
        change(m)
    End Sub

    Private Sub tirageBtn_Click(sender As Object, e As EventArgs) Handles tirageBtn.Click
        Dim m As New Tirage
        change(m)

    End Sub

    Private Sub rembBtn_Click(sender As Object, e As EventArgs) Handles rembBtn.Click
        Dim m As New Remboursement
        change(m)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateNow.Text = Date.Now
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Function Dialogue(ByRef titre As String, ByRef message As String) As Boolean
        test = False
        Dim dialog As New DialogResult
        dialog = MessageBox.Show(message, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dialog = DialogResult.Yes) Then
            test = True
        End If
        Return test
    End Function
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (Dialogue("Quitter", "Voulez vous quitter l'application ?")) Then
            membre.BackUp("C:\BACK")
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If (Me.WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub parametreBtn_Click(sender As Object, e As EventArgs) Handles parametreBtn.Click
        'Parametre.ShowDialog()
        Dim m As New BackUp
        change(m)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
