Imports System.Data.SqlClient
Imports System.IO
Public Class connectCls
    Public con As SqlConnection = New SqlConnection("Data Source='" + File.ReadAllText(CreerDossier.server) + "';Initial Catalog='" + File.ReadAllText(CreerDossier.dbname) + "';User ID='" + File.ReadAllText(CreerDossier.usernam) + "';Password='" + File.ReadAllText(CreerDossier.pass) + "'")
End Class
