Imports System.IO
Public Class ClassFile
    Dim director As String = "C:\TP\DB"
    Public fullfile As String = director + "\db.group"
    Dim first As String = director + "\first.group"
    Public code As String
    Shared Function GetInstance() As ClassFile
        Static Dim objet As ClassFile
        If (IsNothing(objet)) Then
            objet = New ClassFile()
        End If
        Return objet
    End Function

    Sub Chekfiles()
        Try
            If Not (Directory.Exists(director)) Then
                Directory.CreateDirectory(director)
            End If
            If Not (File.Exists(fullfile)) Then
                File.Create(fullfile)
            End If
            If Not (File.Exists(first)) Then
                File.Create(first)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Sub SetFirst()

        Try
            Dim sw As New StreamWriter(first)
            sw.Write("false")
            sw.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Sub ESSAIE()

    End Sub



End Class
