Imports System.Data.SqlClient
Imports System.IO

Public Class ClassMembre
    Dim getCon As New connectCls
    Dim insert As New SqlCommand
    Public ds As DataSet
    Dim adpt1 As New SqlDataAdapter
    Public clientExists As Boolean = False
    Public loginExist As Boolean = False
    Public isAdmin As Boolean = False, isManager As Boolean = False


    Public Sub insererMembre(ByVal codeMbr As String, ByVal nomMbr As String, ByVal postnomMbr As String, ByVal sexe As String, ByVal profession As String, ByVal adresse As String, ByVal photo As Byte(), ByVal telephone As String, ByVal mandataire As String, ByVal tel_mand As String, ByVal lien As String, ByVal numC As String, ByVal photo_Man As Byte(), ByVal email As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "INSERT INTO Membre (codeMbr, nomMbr, postnomMbr, Sexe, Profession, Adresse, Photo, Telephone, Mandataire, telephone_Mandataire, Lien, Numero_Carte, Email, Photo_Mandataire) VALUES (@codeMbr, @nomMbr, @postnomMbr, @Sexe, @Profession, @Adresse, @Photo, @Telephone, @Mandataire, @telephone_Mandataire, @Lien, @Numero_Carte, @Email, @Photo_Mandataire)"
            insert.Parameters.AddWithValue("@codeMbr", codeMbr.Trim)
            insert.Parameters.AddWithValue("@nomMbr", nomMbr.Trim)
            insert.Parameters.AddWithValue("@postnomMbr", postnomMbr.Trim)
            insert.Parameters.AddWithValue("@Sexe", sexe.Trim)
            insert.Parameters.AddWithValue("@Profession", profession.Trim)
            insert.Parameters.AddWithValue("@Adresse", adresse.Trim)
            insert.Parameters.AddWithValue("@Photo", photo)
            insert.Parameters.AddWithValue("@Telephone", telephone.Trim)
            insert.Parameters.AddWithValue("@Mandataire", mandataire.Trim)
            insert.Parameters.AddWithValue("@telephone_Mandataire", tel_mand.Trim)
            insert.Parameters.AddWithValue("@Lien", lien.Trim)
            insert.Parameters.AddWithValue("@Numero_Carte", numC.Trim)
            insert.Parameters.AddWithValue("@Photo_Mandataire", photo_Man)
            insert.Parameters.AddWithValue("Email", email.Trim)
            Dim result = MessageBox.Show("Voulez-vous enregistrer?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                insert.ExecuteNonQuery()
                MessageBox.Show("Enregistrement réussi avec succès!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            getCon.con.Close()
        End Try

    End Sub

    Public Sub insererCotisation(ByVal codeMbr As String, ByVal montant As String, ByVal fonction As String, ByVal dateCo As Date)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "INSERT INTO Cotisation (codeMbr, Montant, Fonction, Date_de_Cotisation) VALUES (@codeMbr, @Montant, @Fonction, @Date_de_Cotisation)"

            insert.Parameters.AddWithValue("@codeMbr", codeMbr.Trim)
            insert.Parameters.AddWithValue("@Montant", montant.Trim)
            insert.Parameters.AddWithValue("@Fonction", fonction.Trim)
            insert.Parameters.AddWithValue("@Date_de_Cotisation", dateCo)

            Dim result = MessageBox.Show("Voulez-vous enregistrer?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                insert.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Sub insererCotisation2(ByVal codeMbr As String, ByVal montant As String, ByVal fonction As String, ByVal dateCo As Date, ByVal amende As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "INSERT INTO Cotisation (codeMbr, Montant, Fonction, Date_de_Cotisation, Amende) VALUES (@codeMbr, @Montant, @Fonction, @Date_de_Cotisation, @Amende)"

            insert.Parameters.AddWithValue("@codeMbr", codeMbr.Trim)
            insert.Parameters.AddWithValue("@Montant", montant.Trim)
            insert.Parameters.AddWithValue("@Fonction", fonction.Trim)
            insert.Parameters.AddWithValue("@Date_de_Cotisation", dateCo)
            insert.Parameters.AddWithValue("@Amende", amende.Trim)
            Dim result = MessageBox.Show("Voulez-vous enregistrer?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                insert.ExecuteNonQuery()
                'MessageBox.Show("Enregistrement réussi avec succès!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Sub insererMembre2(ByVal codeMbr As String, ByVal nomMbr As String, ByVal postnomMbr As String, ByVal sexe As String, ByVal profession As String, ByVal adresse As String, ByVal photo As Byte(), ByVal telephone As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "INSERT INTO Membre (codeMbr, nomMbr, postnomMbr, Sexe, Profession, Adresse, Photo, Telephone) VALUES (@codeMbr, @nomMbr, @postnomMbr, @Sexe, @Profession, @Adresse, @Photo, @Telephone)"
            insert.Parameters.AddWithValue("@codeMbr", codeMbr.Trim)
            insert.Parameters.AddWithValue("@nomMbr", nomMbr.Trim)
            insert.Parameters.AddWithValue("@postnomMbr", postnomMbr.Trim)
            insert.Parameters.AddWithValue("@Sexe", sexe.Trim)
            insert.Parameters.AddWithValue("@Profession", profession.Trim)
            insert.Parameters.AddWithValue("@Adresse", adresse.Trim)
            insert.Parameters.AddWithValue("@Photo", photo)
            insert.Parameters.AddWithValue("@Telephone", telephone.Trim)

            Dim result = MessageBox.Show("Voulez-vous enregistrer ce membre Sans Mandataire?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                insert.ExecuteNonQuery()
                MessageBox.Show("Enregistrement réussi avec succès!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        getCon.con.Close()
    End Sub

    Public Sub clientList(ByVal grid As DataGridView, ByVal nomTable As String)
        Try
            getCon.con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = getCon.con
            cmd.CommandText = "SELECT * FROM " + nomTable + ""
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "listeMembre")
            grid.DataSource = ds.Tables("listeMembre")
            grid.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        getCon.con.Close()
    End Sub
    Public Sub Inserer_Tirage(ByVal num As Integer, ByVal code As String, ByVal Date_Remb As Date)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "INSERT INTO Tirage (numTire, codeMbr, date_paiement) VALUES (@numTire, @codeMbr, @date_paiement)"
            insert.Parameters.AddWithValue("numTire", num)
            insert.Parameters.AddWithValue("@codeMbr", code.Trim)
            insert.Parameters.AddWithValue("@date_paiement", Date_Remb)

            Dim result = MessageBox.Show("Voulez-vous enregistrer ce membre Sans Mandataire?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                insert.ExecuteNonQuery()
                MessageBox.Show("Enregistrement réussi avec succès!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            getCon.con.Close()
        End Try
    End Sub
    Public Sub Inserer_Remboursement(ByVal num As Integer, ByVal montant As Integer, ByVal Date_Remb As Date)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "INSERT INTO Remboursement(numTire,Montant,Date_de_Remb) VALUES (@numTire,@Montant,@Date_de_Remb)"

            insert.Parameters.AddWithValue("@numTire", num)
            insert.Parameters.AddWithValue("@Montant", montant)
            insert.Parameters.AddWithValue("@Date_de_Remb", Date_Remb)

            Dim result = MessageBox.Show("Voulez-vous enregistrer ce remboursement?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                insert.ExecuteNonQuery()
                MessageBox.Show("Remboursement effectuer avec succès!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            getCon.con.Close()
        End Try
    End Sub
    Public Sub searchCotisation(ByVal grid As DataGridView, ByVal searchName As String)
        Try
            getCon.con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = getCon.con
            cmd.CommandText = "SELECT * FROM Cotisation where codeMbr like '%" & searchName & "%' or Montant like '%" & searchName & "%' or Date_de_Cotisation like '%" & searchName & "%' or Amende like '%" & searchName & "%'"
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "listeClient")
            grid.DataSource = ds.Tables("listeClient")
            grid.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        getCon.con.Close()
    End Sub
    Sub chargement_combo(ByVal field As String, ByVal nomTable As String, ByVal cmb As ComboBox)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "select " + field + "  from " + nomTable + ""
            Dim dr As SqlDataReader
            dr = insert.ExecuteReader
            While (dr.Read)
                cmb.Items.Add(dr(field).ToString())

            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            getCon.con.Close()
            insert.Dispose()

        End Try

    End Sub
    Public Sub updateMembre(ByVal codeMbr As String, ByVal nomMbr As String, ByVal postnomMbr As String, ByVal sexe As String, ByVal profession As String, ByVal adresse As String, ByVal photo As Byte(), ByVal telephone As String, ByVal mandataire As String, ByVal tel_mand As String, ByVal lien As String, ByVal numC As String, ByVal photo_Man As Byte(), ByVal email As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "UPDATE Membre SET nomMbr=@nomMbr, postnomMbr=@postnomMbr, Sexe=@Sexe, Profession=@Profession, Adresse=@Adresse, Photo=@Photo, Telephone=@Telephone, Mandataire=@Mandataire, telephone_Mandataire=@telephone_Mandataire, Lien=@Lien, Numero_Carte=@Numero_Carte, Email=@Email, Photo_Mandataire=@Photo_Mandataire WHERE codeMbr='" + codeMbr.Trim + "'"

            insert.Parameters.AddWithValue("@nomMbr", nomMbr.Trim)
            insert.Parameters.AddWithValue("@postnomMbr", postnomMbr.Trim)
            insert.Parameters.AddWithValue("@Sexe", sexe.Trim)
            insert.Parameters.AddWithValue("@Profession", profession.Trim)
            insert.Parameters.AddWithValue("@Adresse", adresse.Trim)
            insert.Parameters.AddWithValue("@Photo", photo)
            insert.Parameters.AddWithValue("@Telephone", telephone.Trim)
            insert.Parameters.AddWithValue("@Mandataire", mandataire.Trim)
            insert.Parameters.AddWithValue("@telephone_Mandataire", tel_mand.Trim)
            insert.Parameters.AddWithValue("@Lien", lien.Trim)
            insert.Parameters.AddWithValue("@Numero_Carte", numC.Trim)
            insert.Parameters.AddWithValue("@Photo_Mandataire", photo_Man)
            insert.Parameters.AddWithValue("Email", email.Trim)
            'insert.Parameters.AddWithValue("@codeMbr", codeMbr.Trim)

            Dim result = MessageBox.Show("Voulez-vous Modifier?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                insert.ExecuteNonQuery()
                MessageBox.Show("Modification effectuée!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Sub deleteMembre(ByVal codeMbr As String, ByVal membre As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "DELETE FROM Membre WHERE codeMbr='" + codeMbr.Trim + "'"
            Dim result = MessageBox.Show("Voulez-vous Vraiment Supprimer le Membre " + membre.Trim + "?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                insert.ExecuteNonQuery()
                MessageBox.Show("Membre supprimé!")
            End If
        Catch ex As Exception
            MessageBox.Show("Vous ne pouvez pas Supprimer le Membre " + membre.Trim + " cr il est utilisé dans plusieurs autres Tables", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            getCon.con.Close()
        End Try
    End Sub
    Public Sub Chargement_Field(ByRef cmb As String, ByRef identite As String, ByRef mandataire As String, ByRef phone As String, ByRef phoneM As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "select nomMbr as NOM, Mandataire as MANDATAIRE,Telephone as TELEPHONE, telephone_Mandataire as TELEPHONE_M FROM Membre where codeMbr='" + cmb + "'"
            Dim dr As SqlDataReader
            dr = insert.ExecuteReader
            While (dr.Read())

                identite = dr("NOM").ToString
                mandataire = dr("MANDATAIRE").ToString
                phone = dr("TELEPHONE").ToString
                phoneM = dr("TELEPHONE_M").ToString
                'photo = dr("PHOTO")
                'photo_Man = dr("PHOTO_M")
                'convertByteToImage(photo)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Sub Chargement_FieldCo(ByRef cmb As String, ByRef identite As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "select codeMbr FROM Membre where nomMbr='" + cmb + "'"
            Dim dr As SqlDataReader
            dr = insert.ExecuteReader
            While (dr.Read())

                identite = dr("codeMbr").ToString

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Sub Chargement_VerificationCotisation(ByRef cmb As String, ByRef code As String, ByRef montant As String, ByRef fonction As String, ByRef dateCo As String, ByRef amende As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "select code_cotisation, Montant, Fonction, Date_de_Cotisation, Amende FROM Cotisation where codeMbr='" + cmb + "' ORDER BY code_cotisation DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY"
            Dim dr As SqlDataReader
            dr = insert.ExecuteReader
            While (dr.Read())

                code = dr("code_cotisation").ToString
                montant = dr("Montant").ToString
                fonction = dr("Fonction").ToString
                dateCo = dr("Date_de_Cotisation").ToString
                amende = dr("Amende").ToString

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Sub Chargement_FieldRemb(ByRef cmb As String, ByRef identite As String, ByRef mandataire As String, ByRef phone As String, ByRef phoneM As String)
        Try
            If (getCon.con.State.Equals("Opened")) Then
                getCon.con.Close()

            End If
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "select date_paiement, codeMbr,nomMbr, Montant FROM A_REMBOURSER where numTire='" + cmb + "'"
            Dim dr As SqlDataReader
            dr = insert.ExecuteReader
            While (dr.Read())

                identite = dr("date_paiement").ToString
                mandataire = dr("codeMbr").ToString
                phone = dr("nomMbr").ToString
                phoneM = dr("Montant").ToString



            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Shared Function convertByteToImage(ByVal tableau As Byte) As Image
        Try
            Dim ms As New MemoryStream()

            'Image.Save(ms, Imaging.ImageFormat.Jpeg)

            Return Image.FromStream(New MemoryStream(tableau))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Shared Function FormatModify(ByVal champ As Byte()) As String
        Dim ret As String

        If champ Is Nothing Then
            ret = "NULL"

        Else
            ret = String.Concat("CONVERT(varbinary(max),@img,1")
        End If

        Return ret
    End Function
    Public Sub Verification_Co(ByRef cmb As String, ByRef ver As String)
        Try
            Dim identite As Date
            Dim dateT As Date = Date.Now
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "SELECT Date_de_Cotisation as DATET FROM Cotisation WHERE codeMbr = '" + cmb + "' ORDER BY code_cotisation DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY"
            Dim dr As SqlDataReader
            dr = insert.ExecuteReader
            While (dr.Read())

                identite = dr("DATET").ToString()
                'identite = Double.Parse(identite)

                If dateT > identite Then
                    ver = "Membre " + cmb + " en ordre avec les cotisations"

                ElseIf dateT < identite Then
                    ver = "Membre " + cmb + " en ordre avec les cotisations"

                    'Else
                    '    ver = "Non reconnus par le système"

                End If

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try

    End Sub
    Public Sub login(ByVal username As String, ByVal pwd As String)
        Try
            getCon.con.Open()
            insert = New SqlCommand
            insert.Connection = getCon.con
            insert.CommandText = "select * from Utilisateur where Nom=@Nom and motPass=@motPass"
            insert.Parameters.AddWithValue("@Nom", username.Trim)
            insert.Parameters.AddWithValue("@motPass", pwd.Trim)
            Dim da As New SqlDataAdapter(insert)
            Dim ds As New DataSet
            da.Fill(ds, "login")
            Dim rowCount As Integer
            rowCount = ds.Tables("login").Rows.Count
            If rowCount = 1 Then
                loginExist = True
                If ds.Tables("login").Rows(0)("Poste").ToString = "ADMIN" Then
                    isAdmin = True
                ElseIf ds.Tables("login").Rows(0)("Poste").ToString = "TRESORIER" Then
                    isManager = True
                End If
            ElseIf rowCount = 0 Then
                loginExist = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            getCon.con.Close()
        End Try
    End Sub
    'Sub rechercher(ByVal recherche As String)
    '    Try
    '        If (getCon.con.State.Equals("Opened")) Then
    '            getCon.con.Close()

    '        End If
    '        getCon.con.Open()
    '        insert.Connection = getCon.con
    '        insert.CommandText = "select * FROM Membre_View where Matricule LIKE '%" + recherche + "%' OR Matricule LIKE '%" + recherche + "%' OR Nom LIKE '%" + recherche + "%'"
    '        adpt1 = New SqlDataAdapter(insert)
    '        Dim ds As New DataSet
    '        adpt1.Fill(ds, "Membre_View")
    '        DataGridView1.DataSource = ds.Tables("Membre_View")

    '    Catch ex As SqlException
    '        MsgBox(ex.Message)

    '    Finally
    '        getCon.con.Close()
    '    End Try
    'End Sub
    Public Sub BackUp(ByVal text As String)
        Try
            getCon.con.Open()
            Dim database As String = getCon.con.Database.ToString
            MsgBox(database)

            If text = "" Then
                MessageBox.Show("please enter backup file location")

            Else
                Dim cmd As String = "BACKUP DATABASE " + database + " TO DISK='" + text.Trim + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak' WITH FORMAT"

                Dim command As SqlCommand = New SqlCommand(cmd, getCon.con)
                command.ExecuteNonQuery()
                MessageBox.Show("database backup done successefully")



            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            getCon.con.Close()

        End Try
    End Sub
    Public Sub Restore(ByVal text As String)
        Try
            getCon.con.Open()
            Dim database As String = getCon.con.Database.ToString
            MsgBox(database)

            If text = "" Then
                MessageBox.Show("please enter backup file location")

            Else
                Dim sqlStmt2 As String = String.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE")
                Dim bu2 As SqlCommand = New SqlCommand(sqlStmt2, getCon.con)
                bu2.ExecuteNonQuery()

                Dim sqlStmt3 As String = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + text.Trim + "'WITH REPLACE;"
                Dim bu3 As SqlCommand = New SqlCommand(sqlStmt3, getCon.con)
                bu3.ExecuteNonQuery()

                Dim sqlStmt4 As String = String.Format("ALTER DATABASE [" + database + "] SET MULTI_USER")
                Dim bu4 As SqlCommand = New SqlCommand(sqlStmt4, getCon.con)
                bu4.ExecuteNonQuery()

                MessageBox.Show("database restoration done successefully")




            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            getCon.con.Close()

        End Try
    End Sub

End Class
