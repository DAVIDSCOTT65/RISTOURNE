Public Class Cotisation

    Dim membre As New ClassMembre

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cotisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If matCombo.Text = "" Then
        '    suiviBtn.Enabled = False
        'Else
        '    suiviBtn.Enabled = True
        'End If
        membre.chargement_combo("codeMbr", "Membre", matCombo)
        membre.clientList(dgCotisation, "Cotisation")
    End Sub

    Private Sub matCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles matCombo.SelectedIndexChanged
        membre.Chargement_FieldCo(matCombo.Text, identiteTxt.Text)

    End Sub

    Private Sub postnomTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles arriereTxt.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MsgBox("Valeur numerique uniquement")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub adresseTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles montantTxt.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MsgBox("Valeur numerique uniquement")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub telephoneTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fonctionTxt.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MsgBox("Valeur numerique uniquement")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim etat As New Impression
            If arriereTxt.Text = "" Then
                membre.insererCotisation(matCombo.Text, montantTxt.Text, fonctionTxt.Text, dateTxt.Text)
                etat.Sortie_Recu(matCombo.Text)
                etat.ShowDialog()
            Else
                membre.insererCotisation2(matCombo.Text, montantTxt.Text, fonctionTxt.Text, dateTxt.Text, arriereTxt.Text)
                etat.Sortie_Recu(matCombo.Text)
                etat.ShowDialog()
            End If


        Catch ex As Exception

        Finally
            membre.clientList(dgCotisation, "Cotisation")
        End Try
    End Sub

    Private Sub suiviBtn_Click(sender As Object, e As EventArgs) Handles suiviBtn.Click
        Try
            Dim etat As New Impression
            If matCombo.Text = "" Then
                MsgBox("Choisisez un matricule avant de cliqué ici")
            Else
                etat.Sortie_FicheSuivi(matCombo.Text)
                etat.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles searchTxt.TextChanged
        membre.searchCotisation(dgCotisation, searchTxt.Text)
    End Sub
End Class
