Imports System.Data.SqlClient
Public Class BackUp
    Dim membre As New ClassMembre
    Dim getcon As New connectCls
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'FolderBrowserDialog dlg = New FolderBrowserDialog
        Dim dlg As New FolderBrowserDialog
        If dlg.ShowDialog = DialogResult.OK Then
            cheminTxt.Text = dlg.SelectedPath
            backupBtn.Enabled = True
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "SQL SERVER database backup files|*.bak"
        dlg.Title = "Database restore"

        If dlg.ShowDialog = DialogResult.OK Then
            TextBox1.Text = dlg.FileName
            restoreBtn.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles restoreBtn.Click
        membre.Restore(TextBox1.Text)
    End Sub

    Private Sub backupBtn_Click(sender As Object, e As EventArgs) Handles backupBtn.Click
        membre.BackUp(cheminTxt.Text)

    End Sub

    Private Sub BackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        restoreBtn.Enabled = False
        backupBtn.Enabled = False
    End Sub
End Class
