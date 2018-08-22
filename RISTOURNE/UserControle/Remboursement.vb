Public Class Remboursement
    Dim membre As New ClassMembre
    Dim var As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Remboursement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        membre.chargement_combo("numTire", "Tirage", numTxt)
        membre.clientList(dgRemb, "Remboursement")
        membre.Chargement_Somme(caisseLab.Text)
        'observTxt.ReadOnly = True
        Label8.Visible = False
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles montantTxt.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MsgBox("Valeur numerique uniquement")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub numTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numTxt.SelectedIndexChanged
        membre.Chargement_FieldRemb(numTxt.Text, dateRemb.Text, identiteTxt.Text)

        'membre.Verification_Co(matriculTxt.Text, observTxt.Text)
        'observTxt.ForeColor = Color.Red
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'membre.Verification_Co(matriculTxt.Text, observTxt.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim etat As New Impression
        If Label8.Visible = True Then

            MessageBox.Show("Désolé, ce Matricule n'est pas concerné par le remboursement de ce jour. Merci de vérifier s'il n'a pas encore percu son remoursement", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf dateRemb.Text = dateCo.Text And montantCo.Text < 200 And socialCo.Text < 3 Then

            MessageBox.Show("Désolé, ce Membre n'est pas en ordre avec toutes les cotisations", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            membre.Inserer_Remboursement(numTxt.Text, montantTxt.Text, dateRemb.Text)
            membre.clientList(dgRemb, "Remboursement")
            etat.Sortie_Reconnaissance(codeCo.Text)
            etat.ShowDialog()
            membre.Chargement_Somme(caisseLab.Text)

            'MessageBox.Show("La date : " + dateRemb.Text + " ne pas encore arrivé ou est déjà passée.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim etat As New Impression
        etat.Sortie_FicheSuiviRemb()
        etat.ShowDialog()
    End Sub

    Private Sub dateRemb_ValueChanged(sender As Object, e As EventArgs) Handles dateRemb.ValueChanged
        If dateRemb.Text <> Date.Today Then
            'dateRemb.CalendarForeColor = Color.Red
            Label8.Visible = True

        Else
            Label8.Visible = False
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub codeCo_Click(sender As Object, e As EventArgs) Handles codeCo.Click

    End Sub

    Private Sub identiteTxt_TextChanged(sender As Object, e As EventArgs) Handles identiteTxt.TextChanged
        membre.Chargement_VerificationCotisation(identiteTxt.Text, codeCotisation.Text, montantCo.Text, socialCo.Text, dateCo.Text, amendeCo.Text)
    End Sub
End Class
