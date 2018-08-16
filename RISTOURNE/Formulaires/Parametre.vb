Imports System.IO
Imports System.Data.SqlClient
Public Class Parametre
    Public InitialDirectory As String = "C:\CTB"
    Public pass As New FileInfo(CreerDossier.pass)
    Public usernam As New FileInfo(CreerDossier.usernam)
    Public server As New FileInfo(CreerDossier.server)
    Public dbname As New FileInfo(CreerDossier.dbname)
    Public con As SqlConnection
    Public test As Boolean
    Private Sub createDirectory()
        Try
            Dim dirinfo As DirectoryInfo
            dirinfo = New DirectoryInfo(Me.InitialDirectory)
            If (Not Directory.Exists(Me.InitialDirectory)) Then
                Directory.CreateDirectory(Me.InitialDirectory)
                dirinfo.Attributes = FileAttributes.Hidden

            End If
        Catch ex As Exception
            Throw New Exception("Erreur de creation" + ex.Message)
        End Try
    End Sub
    Private Sub Parametre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.createDirectory()
    End Sub
    'Function check() As Boolean
    '    test = True
    '    If (txtServer.Text.Trim = "" Or txtDb.Text.Trim() = "" Or txtuser.Text.Trim() = "" Or txtpass.Text.Trim() = "") Then
    '        test = False
    '        Message("Champs", "Completer tous les champs", 0)
    '    End If
    '    Return test
    'End Function
    'Function database() As Boolean
    '    Try
    '        If (check()) Then
    '            If (Setconnexion(txtServer.Text.Trim(), txtDb.Text.Trim(), txtuser.Text.Trim(), txtpass.Text.Trim())) Then

    '                test = True
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Message("Erreur", "Erreur serveur :" + ex.Message, 0)
    '    End Try
    '    Return test
    'End Function

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.createDirectory()
            File.WriteAllText(server.FullName, txtServer.Text)
            File.WriteAllText(dbname.FullName, txtDb.Text)
            File.WriteAllText(usernam.FullName, txtuser.Text)
            File.WriteAllText(pass.FullName, txtpass.Text)
            MessageBox.Show(Me, "La base des données a été enregistrée avec succès. Vous pouvez à présent vous loger")
            con = New SqlConnection("Data Source='" + File.ReadAllText(CreerDossier.server) + "';Initial Catalog='" + File.ReadAllText(CreerDossier.dbname) + "';User ID='" + File.ReadAllText(CreerDossier.usernam) + "';Password='" + File.ReadAllText(CreerDossier.pass) + "'")
            Me.Hide()
            User.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (Dialogue("Quitter", "Voulez vous quitter l'application ?")) Then
            Application.Exit()
        End If
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

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub
End Class