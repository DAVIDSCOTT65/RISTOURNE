Imports System.IO
Imports System.Data.SqlClient
Public Class Membre
    Dim membre As New ClassMembre
    Dim photo As Byte()
    Dim photo_Man As Byte()
    Dim index As Integer
    Dim modif As Boolean

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Dim open As New OpenFileDialog
        open.Filter = "Toutes|*.*|Photos|*.jpg;*.png;*.jpeg"
        open.Title = "Choissez une image"
        If (open.ShowDialog() = DialogResult.OK) Then
            PictureBox2.Image = Image.FromFile(open.FileName)
        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub telephoneMand_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Membre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        membre.clientList(dgMembre, "Membre")
        codeTxt.ReadOnly = True
    End Sub
    Private Sub nomTxt_Personne_KeyPress(KeyAscii As Integer)
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
    End Sub
    Private Sub postnomTxt_Personne_KeyPress(KeyAscii As Integer)
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
    End Sub
    Private Sub adresseTxt_Personne_KeyPress(KeyAscii As Integer)
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        convertImageToBinnary(PictureBox1.Image)
        convertImageToBinnary2(PictureBox2.Image)
        membre.updateMembre(codeTxt.Text.Trim, nomTxt.Text.Trim, postnomTxt.Text.Trim, sexeCombo.SelectedItem.ToString, professionCombo.SelectedItem.ToString, adresseTxt.Text.Trim, photo, Integer.Parse(telephoneTxt.Text.Trim), mandataireTxt.Text.Trim, Integer.Parse(telephoneMand.Text.Trim), lienCombo.SelectedItem.ToString, Integer.Parse(carteTxt.Text.Trim), photo_Man, mailTxt.Text.Trim)
        membre.clientList(dgMembre, "Membre")
    End Sub
    'Function verification() As Boolean
    '    test = True
    '    If (codeTxt.Text.Trim = "" Or nomTxt.Text.Trim = "" Or postnomTxt.Text.Trim = "" Or IsNothing(PictureBox1.Image) Or sexeCombo.SelectedItem.Trim = "" Or professionCombo.SelectedItem.Trim = "" Or adresseTxt.Text.Trim = "" Or telephoneTxt.Text.Trim = "" Or telephoneMand.Text.Trim = "" Or lienCombo.SelectedItem.Text.Trim = "" Or carteTxt.Text.Trim = "" Or mailTxt.Text.Trim = "" Or IsNothing(PictureBox2.Image)) Then
    '        test = False
    '    End If
    '    Return test
    'End Function
    Function convertImageToBinnary(ByVal image As Image) As Byte()

        Dim ms As New MemoryStream()
        image.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
        photo = ms.ToArray()
        Return ms.ToArray()
    End Function
    Function convertImageToBinnary2(ByVal image As Image) As Byte()

        Dim ms As New MemoryStream()
        image.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
        photo_Man = ms.ToArray()
        Return ms.ToArray()
    End Function
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Try
            Dim etat As New Impression
            MatriculeAbonne()
            convertImageToBinnary(PictureBox1.Image)


            If mandataireTxt.Text = "" Then

                membre.insererMembre2(codeTxt.Text.Trim, nomTxt.Text.Trim, postnomTxt.Text.Trim, sexeCombo.SelectedItem.ToString, professionCombo.SelectedItem.ToString, adresseTxt.Text.Trim, photo, Integer.Parse(telephoneTxt.Text.Trim))
                membre.clientList(dgMembre, "Membre")
                etat.Sortie_Engagement(codeTxt.Text)
                etat.ShowDialog()

            Else
                convertImageToBinnary2(PictureBox2.Image)
                membre.insererMembre(codeTxt.Text.Trim, nomTxt.Text.Trim, postnomTxt.Text.Trim, sexeCombo.SelectedItem.ToString, professionCombo.SelectedItem.ToString, adresseTxt.Text.Trim, photo, Integer.Parse(telephoneTxt.Text.Trim), mandataireTxt.Text.Trim, Integer.Parse(telephoneMand.Text.Trim), lienCombo.SelectedItem.ToString, Integer.Parse(carteTxt.Text.Trim), photo_Man, mailTxt.Text.Trim)
                membre.clientList(dgMembre, "Membre")
                etat.Sortie_Engagement(codeTxt.Text)
                etat.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub MatriculeAbonne()
        Try
            Dim signe, nom, post, pre, prod, matricule As String
            signe = "ME"
            nom = nomTxt.Text.Substring(0, 2)
            post = postnomTxt.Text.Substring(0, 2)
            pre = adresseTxt.Text.Substring(0, 2)
            prod = telephoneTxt.Text.Substring(0, 4)

            matricule = signe + "" + nom + "" + post + "" + pre + "" + prod
            codeTxt.Text = matricule
        Catch ex As Exception
            'My.Application.Log.WriteException(ex, TraceEventType.Error, )
            MessageBox.Show(ex.Message, "Matricule", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub photoBtn_Click(sender As Object, e As EventArgs)
        Dim open As New OpenFileDialog
        open.Filter = "Toutes|*.*|Photos|*.jpg;*.png;*.jpeg"
        open.Title = "Choissez une image"
        If (open.ShowDialog() = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dim dialog As New DevExpress.XtraEditors.Camera.TakePictureDialog
        'If (dialog.ShowDialog() = DialogResult.OK) Then
        '    PictureBox1.Image = dialog.Image
        'End If

    End Sub

    Private Sub dgMembre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMembre.CellContentClick
        Try
            codeTxt.Text = dgMembre.CurrentRow.Cells("codeMbr").Value.ToString
            nomTxt.Text = dgMembre.CurrentRow.Cells("nomMbr").Value.ToString
            postnomTxt.Text = dgMembre.CurrentRow.Cells("postnomMbr").Value.ToString
            sexeCombo.Text = dgMembre.CurrentRow.Cells("Sexe").Value.ToString
            professionCombo.Text = dgMembre.CurrentRow.Cells("Profession").Value.ToString
            adresseTxt.Text = dgMembre.CurrentRow.Cells("Adresse").Value.ToString
            telephoneTxt.Text = dgMembre.CurrentRow.Cells("Telephone").Value.ToString
            mandataireTxt.Text = dgMembre.CurrentRow.Cells("Mandataire").Value.ToString
            telephoneMand.Text = dgMembre.CurrentRow.Cells("telephone_Mandataire").Value.ToString
            lienCombo.Text = dgMembre.CurrentRow.Cells("Lien").Value.ToString
            carteTxt.Text = dgMembre.CurrentRow.Cells("Numero_Carte").Value.ToString
            mailTxt.Text = dgMembre.CurrentRow.Cells("Email").Value.ToString
            PictureBox2.Image = dgMembre.CurrentRow.Cells("Photo_Mandataire").FormattedValue
            PictureBox1.Image = dgMembre.CurrentRow.Cells("Photo").FormattedValue

            codeTxt.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub photoBtn_Click_1(sender As Object, e As EventArgs) Handles photoBtn.Click
        Dim open As New OpenFileDialog
        open.Filter = "Toutes|*.*|Photos|*.jpg;*.png;*.jpeg"
        open.Title = "Choissez une image"
        If (open.ShowDialog() = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Filter = "Toutes|*.*|Photos|*.jpg;*.png;*.jpeg"
        open.Title = "Choissez une image"
        If (open.ShowDialog() = DialogResult.OK) Then
            PictureBox2.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub telephoneTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telephoneTxt.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MsgBox("Valeur numerique uniquement")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub telephoneMand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telephoneMand.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MsgBox("Valeur numerique uniquement")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub carteTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles carteTxt.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MsgBox("Valeur numerique uniquement")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If codeTxt.Text = "" Or nomTxt.Text = "" Then
            MsgBox("Veuillez selectionné une ligne dans le Table avant de supprimer")

        Else
            membre.deleteMembre(codeTxt.Text, nomTxt.Text)
            membre.clientList(dgMembre, "Membre")
        End If

    End Sub
End Class
