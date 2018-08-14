Public Class Remboursement
    Dim membre As New ClassMembre
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Remboursement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        membre.chargement_combo("numTire", "Tirage", numTxt)
        membre.clientList(dgRemb, "Remboursement")
        observTxt.ReadOnly = True
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles observTxt.KeyPress
        'Try
        '    If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
        '        e.Handled = True
        '        MsgBox("Valeur numerique uniquement")
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub numTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numTxt.SelectedIndexChanged
        membre.Chargement_FieldRemb(numTxt.Text, dateRemb.Text, matriculTxt.Text, identiteTxt.Text, montantTxt.Text)
        membre.Verification_Co(matriculTxt.Text, observTxt.Text)
        observTxt.ForeColor = Color.Red
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles observTxt.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        membre.Verification_Co(matriculTxt.Text, observTxt.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim etat As New Impression
        If observTxt.Text = "Membre " + matriculTxt.Text + " en Retard" Then

            MessageBox.Show("Le membre " + identiteTxt.Text + " est en retard de cotisation. Enregistré sa cotisation hebdomadaire avant de continuer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf dateRemb.Text = Date.Today Then
            membre.Inserer_Remboursement(numTxt.Text, montantTxt.Text, dateRemb.Text)
            membre.clientList(dgRemb, "Remboursement")
            etat.Sortie_Reconnaissance(matriculTxt.Text)
            etat.ShowDialog()
        Else
            MessageBox.Show("La date : " + dateRemb.Text + " ne pas encore arrivé ou est déjà passée.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim etat As New Impression
        etat.Sortie_FicheSuiviRemb()
        etat.ShowDialog()
    End Sub
End Class
