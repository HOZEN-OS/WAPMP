Public Class Class_PostgreSQL
    Inherits Abstract
    Protected ShutDownCmd As New StartCmd
    Protected ReStartCmd As New StartCmd

    Public Sub New(ByRef INI As IniFile)
        Dim fi As New IO.FileInfo(INI.Drive & ":\" & INI.POSTGRE_EXE)

        StartUpCmd.Path = fi.DirectoryName
        StartUpCmd.Exe = fi.Name
        StartUpCmd.Args = "start -D " & """" & fi.Directory.Parent.FullName & "\data\"""

        ShutDownCmd.Path = fi.DirectoryName
        ShutDownCmd.Exe = fi.Name
        ShutDownCmd.Args = "stop -D " & """" & fi.Directory.Parent.FullName & "\data\"""

        ReStartCmd.Path = fi.DirectoryName
        ReStartCmd.Exe = fi.Name
        ReStartCmd.Args = "reload -D " & """" & fi.Directory.Parent.FullName & "\data\"""

        If Not String.IsNullOrEmpty(INI.ADD_PATH) Then
            StartUpCmd.AddPath.Add(INI.ADD_PATH)
            ShutDownCmd.AddPath.Add(INI.ADD_PATH)
            ReStartCmd.AddPath.Add(INI.ADD_PATH)
        End If

        pName = "postgres"
    End Sub

    Public Function StartUp() As Boolean
        If Check() = False Then
            Try
                MyProcess = StartExe(StartUpCmd)
                MyProcess.WaitForExit(5000)
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

    Public Function ReStart() As Boolean
        If Check() = True Then
            Try
                MyProcess = StartExe(ReStartCmd)
                MyProcess.WaitForExit(3000)
                MyProcess.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "postgres再起動エラー")
                Return False
            End Try
        End If

        Return True
    End Function
End Class
