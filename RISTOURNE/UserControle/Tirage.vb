Public Class Tirage
    Dim membre As New ClassMembre


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numTxt.SelectedIndexChanged
        Try
            Dim da As Date
            Dim add As Double
            da = Date.Today
            add = Double.Parse(numTxt.SelectedItem.ToString)
            If add = "1" Then

                dateTxt.Text = Date.Now

            Else

                add = (add * 7) - 7
                dateTxt.Text = DateAdd("d", add, Date.Now)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Tirage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        membre.chargement_combo("codeMbr", "Membre", matriculTxt)
        membre.clientList(dgTirage, "MEMBRE_TIRAGE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        membre.Inserer_Tirage(numTxt.Text, matriculTxt.Text.Trim, dateTxt.Text)
        membre.clientList(dgTirage, "MEMBRE_TIRAGE")
    End Sub

    Private Sub dgTirage_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTirage.CellContentClick

    End Sub

    Private Sub matriculTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles matriculTxt.SelectedIndexChanged
        membre.Chargement_Field(matriculTxt.Text, membreTxt.Text, mandTxt.Text, phoneTxt.Text, phone.Text)
    End Sub
End Class
