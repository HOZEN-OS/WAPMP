Public Class Class_Apache
    Inherits Abstract

    Public Sub New(ByRef INI As IniFile)
        Dim fi As New IO.FileInfo(INI.Drive & ":\" & INI.APACHE_EXE)
        StartUpCmd.Path = fi.DirectoryName
        StartUpCmd.Exe = fi.Name
        StartUpCmd.Args = "-f " & INI.Drive & ":\conf\httpd.conf"
        If INI.MYSQL = 1 Then
            StartUpCmd.AddPath.Add(INI.Drive & ":\" & New IO.FileInfo(INI.Drive & ":\" & INI.MYSQL_SARTEXE).DirectoryName)
        End If
        If Not String.IsNullOrEmpty(INI.ADD_PATH) Then
            StartUpCmd.AddPath.Add(INI.ADD_PATH)
        End If
    End Sub

    Public Function StartUp() As Boolean
        If Check() = False Then
            Try
                MyProcess = StartExe(StartUpCmd)
                pName = MyProcess.ProcessName
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, StartUpCmd.Exe & "ãNìÆÉGÉâÅ[")
                Return False
            End Try
        End If

        Return True
    End Function

    Public Function ShutDown() As Boolean
        If Check() = True Then
            Dim ps As Process() = Process.GetProcessesByName(pName)
            Dim p As Process
            For Each p In ps
                Try
                    p.Kill()
                Catch
                End Try
            Next p

            Try
                MyProcess.WaitForExit(5000)
                MyProcess.Kill()
                MyProcess.Close()
            Catch
            End Try
        End If

        Return True
    End Function
End Class
