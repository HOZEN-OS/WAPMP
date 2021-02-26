Imports System.Runtime.InteropServices
Public Class VirtualDrive
    Private Declare Function DefineDosDevice Lib "kernel32" Alias "DefineDosDeviceA" (ByVal dwFlags As Integer, ByVal lpDeviceName As String, Optional ByVal lpTargetPath As String = vbNullString) As Integer
    Private Const DDD_REMOVE_DEFINITION As Integer = &H2S
    Private Const DDD_CREATE_DEFINITION As Integer = &H0S
    Public Shared Function Make_Drive(ByVal drv As String, ByVal dPath As String) As Boolean
        If DefineDosDevice(DDD_CREATE_DEFINITION, drv, dPath) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function Delete_Drive(ByVal drv As String) As Boolean
        If DefineDosDevice(DDD_REMOVE_DEFINITION, drv) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Sub ChVDrive(ByVal drv As String)
        ChDrive(drv)
    End Sub
End Class
