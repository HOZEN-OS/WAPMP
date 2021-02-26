Imports System.Diagnostics
Public Class Abstract
    Protected MyProcess As Diagnostics.Process
    Protected pName As String = ""

    Protected Class StartCmd
        Public Path As String
        Public Exe As String
        Public Args As String
        Public AddPath As New ArrayList
    End Class
    Protected StartUpCmd As New StartCmd

    Protected Overridable Function Check() As Boolean
        If pName = "" Then
            Return False
        End If

        Dim ps As Process()
        Try
            ps = Process.GetProcessesByName(pName)
        Catch ex As Exception
            Return False
        End Try

        If ps.GetLength(0) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Protected Overridable Function StartExe(ByVal sc As StartCmd) As Process
        Dim psi As New ProcessStartInfo()
        With psi
            .FileName = sc.Path & "\" & sc.Exe
            .WorkingDirectory = sc.Path
            .RedirectStandardInput = False
            .RedirectStandardOutput = False
            .UseShellExecute = False
            .CreateNoWindow = True
            .Arguments = sc.Args
            If sc.AddPath.Count > 0 Then
                .EnvironmentVariables("PATH") &= (IO.Path.PathSeparator & String.Join(IO.Path.PathSeparator, sc.AddPath.ToArray))
            End If
        End With
        Return Process.Start(psi)
    End Function
End Class
