Imports System.IO
Public Class ProgressBar
    Public InitialDirectory As String = "C:\CTB"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = ProgressBar1.Value + 1
        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            createDirectory()

        ElseIf (ProgressBar1.Value = 1) Then
            Label1.ForeColor = Color.Black
            Label1.Text = "Chargement ..."

        ElseIf (ProgressBar1.Value = 45) Then
            Label1.ForeColor = Color.Blue
            Label1.Text = "Nous préparons votre espace de travail ..."

        ElseIf (ProgressBar1.Value = 95) Then
            Label1.ForeColor = Color.Black
            Label1.Text = "Lancez-vous !!!"
        End If
    End Sub
    Private Sub createDirectory()
        Try
            Dim dirinfo As DirectoryInfo
            dirinfo = New DirectoryInfo(Me.InitialDirectory)
            If (Not Directory.Exists(Me.InitialDirectory)) Then
                'Directory.CreateDirectory(Me.InitialDirectory)
                'dirinfo.Attributes = FileAttributes.Hidden
                Me.Hide()
                'Form1.Show()
                Parametre.Show()
            Else
                Me.Hide()
                'Parametre.Show()
                User.Show()

            End If
        Catch ex As Exception
            Throw New Exception("Erreur de creation" + ex.Message)
        End Try
    End Sub

    Private Sub ProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class