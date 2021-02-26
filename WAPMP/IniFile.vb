Imports System.Runtime.InteropServices

Public Class IniFile
    Private ReadOnly MyINIFile As String
    Public Sub New(inifile As String)
        MyINIFile = inifile
    End Sub
    <DllImport("KERNEL32.DLL")>
    Private Shared Function WritePrivateProfileString(
        ByVal lpAppName As String,
        ByVal lpKeyName As String,
        ByVal lpString As String,
        ByVal lpFileName As String) As Integer
    End Function
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileString(
        ByVal lpAppName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As System.Text.StringBuilder,
        ByVal nSize As Integer,
        ByVal lpFileName As String) As Integer
    End Function
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileInt(
      ByVal lpAppName As String,
      ByVal lpKeyName As String, ByVal nDefault As Integer,
      ByVal lpFileName As String) As Integer
    End Function

    Public Function GET_String(ByVal mName As String, ByVal mKey As String, ByVal mDefault As String) As String
        Dim strSb As New System.Text.StringBuilder
        strSb.Capacity = 255
        GetPrivateProfileString(mName, mKey, mDefault, strSb, strSb.Capacity, MyINIFile)
        Return strSb.ToString()
    End Function
    Public Function GET_Integer(ByVal mName As String, ByVal mKey As String, ByVal mDefault As Integer) As Integer
        Return GetPrivateProfileInt(mName, mKey, mDefault, MyINIFile)
    End Function
    Public Sub SET_INIValue(ByVal mName As String, ByVal mKey As String, ByVal value As String)
        WritePrivateProfileString(mName, mKey, value.ToString, MyINIFile)
    End Sub

    Public Property Drive() As String
        Get
            Return GET_String("MAIN", "drive", "w")
        End Get
        Set(ByVal value As String)
            SET_INIValue("MAIN", "drive", value)
        End Set
    End Property
    Public Property WAITTIME() As Integer
        Get
            Return GET_Integer("MAIN", "WAITTIME", "1000")
        End Get
        Set(ByVal value As Integer)
            SET_INIValue("MAIN", "WAITTIME", value)
        End Set
    End Property
    Public Property OPEN_URL() As Integer
        Get
            Return GET_Integer("MAIN", "OPEN", "1")
        End Get
        Set(ByVal value As Integer)
            SET_INIValue("MAIN", "OPEN", value)
        End Set
    End Property
    Public Property TOPPAGE_URL() As String
        Get
            Return GET_String("MAIN", "TOPPAGE", "http://localhost/")
        End Get
        Set(ByVal value As String)
            SET_INIValue("MAIN", "TOPPAGE", value)
        End Set
    End Property

    Public Property ADD_PATH() As String
        Get
            Return GET_String("MAIN", "PATH", "")
        End Get
        Set(value As String)
            SET_INIValue("MAIN", "PATH", value)
        End Set
    End Property

    Public Property APACHE() As Integer
        Get
            Return GET_Integer("APACHE", "START", "0")
        End Get
        Set(ByVal value As Integer)
            SET_INIValue("APACHE", "START", value)
        End Set
    End Property
    Public Property APACHE_EXE() As String
        Get
            Return GET_String("APACHE", "EXE", "EXE\Apache2\bin\Apache.exe")
        End Get
        Set(ByVal value As String)
            SET_INIValue("APACHE", "EXE", value)
        End Set
    End Property

    Public Property MYSQL() As Integer
        Get
            Return GET_Integer("MYSQL", "START", "0")
        End Get
        Set(ByVal value As Integer)
            SET_INIValue("MYSQL", "START", value)
        End Set
    End Property
    Public Property MYSQL_SARTEXE() As String
        Get
            Return GET_String("MYSQL", "SARTEXE", "EXE\mysql\bin\mysqld-max.exe")
        End Get
        Set(ByVal value As String)
            SET_INIValue("MYSQL", "SARTEXE", value)
        End Set
    End Property

    Public Property MYSQL_STOPEXE() As String
        Get
            Return GET_String("MYSQL", "STOPEXE", "EXE\mysql\bin\mysqladmin.exe")
        End Get
        Set(ByVal value As String)
            SET_INIValue("MYSQL", "STOPEXE", value)
        End Set
    End Property
    Public Property POSTGRESQL() As Integer
        Get
            Return GET_Integer("POSTGRESQL", "START", "0")
        End Get
        Set(ByVal value As Integer)
            SET_INIValue("POSTGRESQL", "START", value)
        End Set
    End Property
    Public Property POSTGRE_EXE() As String
        Get
            Return GET_String("POSTGRESQL", "EXE", "EXE\PostgreSQL\bin\pg_ctl.exe")
        End Get
        Set(ByVal value As String)
            SET_INIValue("POSTGRESQL", "EXE", value)
        End Set
    End Property
End Class
