Imports System.Data.SqlClient
Imports System.IO
Public Class MdlDatabase
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public test As Boolean
    Public chemin As String

    Sub Dispose()
        con.Close()
        cmd.Dispose()
    End Sub

    Sub Message(ByRef titre As String, ByRef message As String, ByRef type As Integer)
        If (type = 0) Then
            MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Function Dialogue(ByRef titre As String, ByRef message As String) As Boolean
        test = False
        Dim dialog As New DialogResult
        dialog = MessageBox.Show(message, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dialog = DialogResult.Yes) Then
            test = True
        End If
        Return test
    End Function
End Class
