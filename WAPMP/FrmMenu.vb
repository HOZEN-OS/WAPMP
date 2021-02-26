Imports System.Security.Permissions
Public Class FrmMenu
    Public INI As New IniFile(Application.StartupPath & "\WAPMP.ini")

    Private WithEvents NIcon As New NotifyIcon()
    Private ReadOnly MySQL As New Class_MySQL(INI)
    Private ReadOnly Apache As New Class_Apache(INI)
    Private ReadOnly PostgreSQL As New Class_PostgreSQL(INI)

    <SecurityPermission(SecurityAction.Demand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_CLOSE As Long = &HF060L

        If m.Msg = WM_SYSCOMMAND AndAlso (m.WParam.ToInt64() And &HFFF0L) = SC_CLOSE Then
            Hide()
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NIcon.Icon = My.Resources.Deactive
        NIcon.Visible = True
        NIcon.Text = "WAPMP"
        NIcon.ContextMenuStrip = CtxtMenu
        PostgreSQLToolStripMenuItem.Visible = False
        Menu_Home.Enabled = False
        ApacheToolStripMenuItem.Enabled = False
        MySQLToolStripMenuItem.Enabled = False
        ToolStripMenuItem1.Enabled = False
        WindowState = FormWindowState.Minimized
        Hide()
        StartUp()
    End Sub

    Public Sub StartUp()
        If IO.Directory.Exists(Application.StartupPath & "\diskw") Then
            If VirtualDrive.Make_Drive(INI.Drive & ":", Application.StartupPath & "\diskw") = False Then
                MsgBox("仮想ドライブの作成に失敗しました")
                ShutDown()
                Close()
            End If

            ClearLog()

            If INI.MYSQL = 1 Then
                If MySQL.StartUp() Then
                    MySQLStartSuccess()
                End If
            End If

            If INI.POSTGRESQL = 1 Then
                If PostgreSQL.StartUp() Then
                    PgSQLStartSuccess()
                End If
            End If

            If INI.APACHE = 1 Then
                If Apache.StartUp() Then
                    ApacheStartSuccess()
                End If
            End If

            If INI.APACHE = 1 AndAlso INI.OPEN_URL = "1" Then
                Threading.Thread.Sleep(INI.WAITTIME)
                Process.Start(INI.TOPPAGE_URL)
            End If

            ToolStripMenuItem1.Enabled = True
        Else
            DefIni()
            MakeDir()
            ShutDown()
            Close()
        End If
        NIcon.Icon = My.Resources.Active
    End Sub

    Private Sub MakeDir()
        IO.Directory.CreateDirectory(Application.StartupPath & "\diskw")
        IO.Directory.CreateDirectory(Application.StartupPath & "\diskw\conf")
        IO.Directory.CreateDirectory(Application.StartupPath & "\diskw\EXE")
        IO.Directory.CreateDirectory(Application.StartupPath & "\diskw\tmp")
        IO.Directory.CreateDirectory(Application.StartupPath & "\diskw\www")
    End Sub

    Private Sub MySQLStartSuccess()
        Menu_MySQLStart.Enabled = False
        Menu_MySQLStop.Enabled = True
        Menu_MySQLRestart.Enabled = True
    End Sub

    Private Sub MySQLStoptSuccess()
        Menu_MySQLStart.Enabled = True
        Menu_MySQLStop.Enabled = False
        Menu_MySQLRestart.Enabled = False
    End Sub

    Private Sub PgSQLStartSuccess()
        PostgreSQLToolStripMenuItem.Visible = True
        Menu_PgSQLStart.Enabled = False
        Menu_PgSQLStop.Enabled = True
        Menu_PgSQLRestart.Enabled = True
    End Sub

    Private Sub PgSQLStopSuccess()
        Menu_PgSQLStart.Enabled = True
        Menu_PgSQLStop.Enabled = False
        Menu_PgSQLRestart.Enabled = False
    End Sub

    Private Sub ApacheStartSuccess()
        Menu_ApacheStart.Enabled = False
        Menu_ApacheStop.Enabled = True
        Menu_ApacheRestart.Enabled = True
    End Sub

    Private Sub ApacheStopSuccess()
        Menu_ApacheStart.Enabled = True
        Menu_ApacheStop.Enabled = False
        Menu_ApacheRestart.Enabled = False
    End Sub

    Public Sub ShutDown()
        NIcon.Icon = My.Resources.Deactive

        If INI.APACHE = 1 Then
            Apache.ShutDown()
        End If

        If INI.MYSQL = 1 Then
            MySQL.ShutDown()
        End If

        If INI.POSTGRESQL = 1 Then
            PostgreSQL.ShutDown()
        End If

        If IO.Directory.Exists(INI.Drive & ":") Then
            Threading.Thread.Sleep(1000)
            VirtualDrive.Delete_Drive(INI.Drive & ":")
        End If

        NIcon.Visible = False
    End Sub

    Public Sub ClearLog()
        Dim di As New IO.DirectoryInfo(INI.Drive & ":\tmp")
        If di.GetFiles("*.*").Length > 0 Then
            Kill(INI.Drive & ":\tmp\*.*")
        End If

        IO.File.Create(INI.Drive & ":\tmp\access.log").Close()
        IO.File.Create(INI.Drive & ":\tmp\error.log").Close()
    End Sub

    Private Sub Menu_Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Home.Click
        Process.Start(INI.TOPPAGE_URL)
    End Sub

    Private Sub Menu_ApacheStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_ApacheStart.Click
        If Apache.StartUp() Then
            ApacheStartSuccess()
        End If
    End Sub

    Private Sub Menu_ApacheStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_ApacheStop.Click
        If Apache.ShutDown() Then
            ApacheStopSuccess()
        End If
    End Sub

    Private Sub Menu_ApacheRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_ApacheRestart.Click
        If Apache.ShutDown() Then
            ApacheStopSuccess()
            Threading.Thread.Sleep(INI.WAITTIME)
            If Apache.StartUp() Then
                ApacheStartSuccess()
            End If
        End If
    End Sub
    Private Sub Menu_MySQLStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_MySQLStart.Click
        If MySQL.StartUp() Then
            MySQLStartSuccess()
        End If
    End Sub

    Private Sub Menu_MySQLStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_MySQLStop.Click
        If MySQL.ShutDown() Then
            MySQLStoptSuccess()
        End If
    End Sub

    Private Sub Menu_MySQLRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_MySQLRestart.Click
        If MySQL.ShutDown() Then
            MySQLStoptSuccess()
            Threading.Thread.Sleep(INI.WAITTIME)
            If MySQL.StartUp() Then
                MySQLStartSuccess()
            End If
        End If
    End Sub
    Private Sub Menu_PgSQLStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_PgSQLStart.Click
        If PostgreSQL.StartUp() Then
            PgSQLStartSuccess()
        End If
    End Sub

    Private Sub Menu_PgSQLStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_PgSQLStop.Click
        If PostgreSQL.ShutDown() Then
            PgSQLStopSuccess()
        End If
    End Sub

    Private Sub Menu_PgSQLRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_PgSQLRestart.Click
        PostgreSQL.ReStart()
    End Sub

    Private Sub Menu_EXIT_Click(sender As Object, e As EventArgs) Handles Menu_EXIT.Click
        ShutDown()
        Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Open_Cmd()
    End Sub

    Private Sub Open_Cmd()
        Dim psi As New ProcessStartInfo()
        With psi
            .FileName = "cmd.exe"
            .WorkingDirectory = INI.Drive & ":\EXE"
            .RedirectStandardInput = False
            .RedirectStandardOutput = False
            .UseShellExecute = False
            .CreateNoWindow = False
            .EnvironmentVariables("PATH") &= (IO.Path.PathSeparator & INI.ADD_PATH)
        End With
        Process.Start(psi)
    End Sub

    Private Sub NIcon_DoubleClick(sender As Object, e As EventArgs) Handles NIcon.DoubleClick
        LoadIni()
        Show()
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub LoadIni()
        TxtDrive.Text = INI.Drive
        TxtWait.Text = INI.WAITTIME
        If INI.OPEN_URL = 1 Then
            RbBrOpen.Checked = True
        Else
            RbBrNotOpen.Checked = True
        End If
        TxtTopPage.Text = INI.TOPPAGE_URL
        TxtPath.Text = INI.ADD_PATH

        If INI.APACHE = 1 Then
            RbApacheEnable.Checked = True
        Else
            RbApacheDisable.Checked = True
        End If
        TxtApacheStart.Text = INI.APACHE_EXE

        If INI.MYSQL = 1 Then
            RbMySQLEnable.Checked = True
        Else
            RbMySQLDisable.Checked = True
        End If
        TxtMySQLStart.Text = INI.MYSQL_SARTEXE
        TxtMySQLStop.Text = INI.MYSQL_STOPEXE

        If INI.POSTGRESQL = 1 Then
            RbPostgreSQLEnable.Checked = True
        Else
            RbPostgreSQLDisable.Checked = True
        End If
        TxtPostgreSQLStart.Text = INI.POSTGRE_EXE
    End Sub

    Private Sub SaveIni()
        INI.Drive = TxtDrive.Text
        If RbBrOpen.Checked Then
            INI.OPEN_URL = 1
        Else
            INI.OPEN_URL = 0
        End If
        INI.TOPPAGE_URL = TxtTopPage.Text
        INI.ADD_PATH = TxtPath.Text

        If RbApacheEnable.Checked Then
            INI.APACHE = 1
        Else
            INI.APACHE = 0
        End If
        INI.APACHE_EXE = TxtApacheStart.Text

        If RbMySQLEnable.Checked Then
            INI.MYSQL = 1
        Else
            INI.MYSQL = 0
        End If
        INI.MYSQL_SARTEXE = TxtMySQLStart.Text
        INI.MYSQL_STOPEXE = TxtMySQLStop.Text

        If RbPostgreSQLEnable.Checked Then
            INI.POSTGRESQL = 1
        Else
            INI.POSTGRESQL = 0
        End If
        INI.POSTGRE_EXE = TxtPostgreSQLStart.Text
    End Sub
    Private Sub DefIni()
        INI.Drive = INI.Drive
        INI.OPEN_URL = INI.OPEN_URL
        INI.TOPPAGE_URL = INI.TOPPAGE_URL
        INI.ADD_PATH = INI.ADD_PATH
        INI.APACHE = INI.APACHE
        INI.APACHE_EXE = INI.APACHE_EXE
        INI.MYSQL = INI.MYSQL
        INI.MYSQL_SARTEXE = INI.MYSQL_SARTEXE
        INI.MYSQL_STOPEXE = INI.MYSQL_STOPEXE
        INI.POSTGRESQL = INI.POSTGRESQL
        INI.POSTGRE_EXE = INI.POSTGRE_EXE
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        SaveIni()
        Hide()
    End Sub
End Class
