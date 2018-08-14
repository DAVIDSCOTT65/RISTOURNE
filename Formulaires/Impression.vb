Imports System.Data.SqlClient
Public Class Impression
    Dim getCon As New connectCls
    Dim adpt1 As New SqlDataAdapter
    Dim cmd As SqlCommand
    Private Sub CrystalReportViewer2_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer2.Load

    End Sub

    Private Sub Impression_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sortie_Recu("MEDEEKBU0838")
    End Sub
    Sub Sortie_Engagement(ByVal matricul As String)
        Try

            Dim ad As New Engagement
            If (getCon.con.State.Equals("Opened")) Then
                getCon.con.Close()
            End If
            getCon.con.Open()
            cmd = New SqlCommand("select * From Membre WHERE codeMbr ='" + matricul + "'", getCon.con)
            Dim da6 As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds6 As DataSet = New DataSet()
            da6.Fill(ds6, "doc")
            ad.SetDataSource(ds6.Tables("doc"))
            CrystalReportViewer2.ReportSource = ad
            CrystalReportViewer2.Refresh()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try
    End Sub
    Sub Sortie_Recu(ByVal matricul As String)
        Try

            Dim ad As New Recu_Cotisation
            If (getCon.con.State.Equals("Opened")) Then
                getCon.con.Close()
            End If
            getCon.con.Open()
            cmd = New SqlCommand("select * From RECU_COTISATION WHERE codeMbr ='" + matricul + "' AND Date_de_Cotisation = cast(Convert(char(8), GETDATE(), 112) AS date)", getCon.con)
            Dim da6 As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds6 As DataSet = New DataSet()
            da6.Fill(ds6, "doc")
            ad.SetDataSource(ds6.Tables("doc"))
            CrystalReportViewer2.ReportSource = ad
            CrystalReportViewer2.Refresh()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try
    End Sub
    Sub Sortie_Reconnaissance(ByVal matricul As String)
        Try

            Dim ad As New Reconnaissance
            If (getCon.con.State.Equals("Opened")) Then
                getCon.con.Close()
            End If
            getCon.con.Open()
            cmd = New SqlCommand("select * From REMBOURSEMENT_M WHERE codeMbr ='" + matricul + "'", getCon.con)
            Dim da6 As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds6 As DataSet = New DataSet()
            da6.Fill(ds6, "doc")
            ad.SetDataSource(ds6.Tables("doc"))
            CrystalReportViewer2.ReportSource = ad
            CrystalReportViewer2.Refresh()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try
    End Sub
    Sub Sortie_FicheSuivi(ByVal matricul As String)
        Try

            Dim ad As New Fiche_Suivi
            If (getCon.con.State.Equals("Opened")) Then
                getCon.con.Close()
            End If
            getCon.con.Open()
            cmd = New SqlCommand("select * From SUIVI_COTISATION WHERE codeMbr ='" + matricul + "'", getCon.con)
            Dim da6 As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds6 As DataSet = New DataSet()
            da6.Fill(ds6, "doc")
            ad.SetDataSource(ds6.Tables("doc"))
            CrystalReportViewer2.ReportSource = ad
            CrystalReportViewer2.Refresh()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try
    End Sub
    Sub Sortie_FicheSuiviRemb()
        Try

            Dim ad As New Suivi_Remboursement
            If (getCon.con.State.Equals("Opened")) Then
                getCon.con.Close()
            End If
            getCon.con.Open()
            cmd = New SqlCommand("select * From SUIVI_REMBOURSEMENT", getCon.con)
            Dim da6 As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds6 As DataSet = New DataSet()
            da6.Fill(ds6, "doc")
            ad.SetDataSource(ds6.Tables("doc"))
            CrystalReportViewer2.ReportSource = ad
            CrystalReportViewer2.Refresh()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            getCon.con.Close()
        End Try
    End Sub
End Class