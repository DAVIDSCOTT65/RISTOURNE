Public Class User
    Dim membre As New ClassMembre
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            membre.login(userTxt.Text, passTxt.Text)
            If membre.loginExist = False Then
                MessageBox.Show("Incorrect username or password !", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If membre.isAdmin = True Then
                    Form1.parametreBtn.Enabled = True
                    'Form1.userBtn.Enabled = True
                ElseIf membre.isManager = True Then
                    Form1.parametreBtn.Enabled = False
                    'mainForm.userBtn.Enabled = False
                    'ElseIf membre.isManager = False And membre.isAdmin = False Then
                    Form1.parametreBtn.Enabled = False
                    'Form1.userBtn.Enabled = False
                End If
                Form1.userLabel.Text = userTxt.Text.Trim
                Me.Hide()
                Form1.Show()
                userTxt.Text = ""
                passTxt.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class