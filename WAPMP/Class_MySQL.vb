Partial Public Class Class_MySQL
    Inherits Abstract

    Protected ShutDownCmd As New StartCmd

    Public Sub New(ByRef INI As IniFile)
        Dim fi As New IO.FileInfo(INI.Drive & ":\" & INI.MYSQL_SARTEXE)
        StartUpCmd.Path = fi.DirectoryName
        StartUpCmd.Exe = fi.Name
        StartUpCmd.Args = "--defaults-file=" & INI.Drive & ":\conf\my.ini --standalone"

        fi = New IO.FileInfo(INI.Drive & ":\" & INI.MYSQL_STOPEXE)
        ShutDownCmd.Path = fi.DirectoryName
        ShutDownCmd.Exe = fi.Name
        ShutDownCmd.Args = "-u root shutd"

        If Not String.IsNullOrEmpty(INI.ADD_PATH) Then
            StartUpCmd.AddPath.Add(INI.ADD_PATH)
            ShutDownCmd.AddPath.Add(INI.ADD_PATH)
        End If
    End Sub

    Public Function StartUp() As Boolean
        If Check() = False Then
            Try
                MyProcess = StartExe(StartUpCmd)
                pName = MyProcess.ProcessName
                MyProcess.WaitForExit(3000)
                MyProcess.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, StartUpCmd.Exe & "起動エラー")
                Return False
            End Try
        End If

        Return True
    End Function

    Public Function ShutDown() As Boolean
        If Check() = True Then
            Try
                MyProcess = StartExe(ShutDownCmd)
                MyProcess.WaitForExit(3000)
                MyProcess.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ShutDownCmd.Exe & "終了エラー")
                Return False
            End Try
        End If

        Return True
    End Function
End Class
