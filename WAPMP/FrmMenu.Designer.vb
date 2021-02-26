<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTopPage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtWait = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbBrNotOpen = New System.Windows.Forms.RadioButton()
        Me.RbBrOpen = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDrive = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtMySQLStop = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMySQLStart = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RbMySQLDisable = New System.Windows.Forms.RadioButton()
        Me.RbMySQLEnable = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtApacheStart = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RbApacheDisable = New System.Windows.Forms.RadioButton()
        Me.RbApacheEnable = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtPostgreSQLStart = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RbPostgreSQLDisable = New System.Windows.Forms.RadioButton()
        Me.RbPostgreSQLEnable = New System.Windows.Forms.RadioButton()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.CtxtMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_Home = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ApacheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ApacheStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ApacheStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ApacheRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.MySQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_MySQLStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_MySQLStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_MySQLRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostgreSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_PgSQLStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_PgSQLStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_PgSQLRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_EXIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.CtxtMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtTopPage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtWait)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RbBrNotOpen)
        Me.GroupBox1.Controls.Add(Me.RbBrOpen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtDrive)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 145)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MAIN"
        '
        'TxtPath
        '
        Me.TxtPath.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtPath.Location = New System.Drawing.Point(71, 102)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(200, 19)
        Me.TxtPath.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PATH"
        '
        'TxtTopPage
        '
        Me.TxtTopPage.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtTopPage.Location = New System.Drawing.Point(71, 77)
        Me.TxtTopPage.Name = "TxtTopPage"
        Me.TxtTopPage.Size = New System.Drawing.Size(200, 19)
        Me.TxtTopPage.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "トップページ"
        '
        'TxtWait
        '
        Me.TxtWait.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtWait.Location = New System.Drawing.Point(164, 21)
        Me.TxtWait.MaxLength = 5
        Me.TxtWait.Name = "TxtWait"
        Me.TxtWait.Size = New System.Drawing.Size(39, 19)
        Me.TxtWait.TabIndex = 6
        Me.TxtWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "待機時間"
        '
        'RbBrNotOpen
        '
        Me.RbBrNotOpen.AutoSize = True
        Me.RbBrNotOpen.Location = New System.Drawing.Point(154, 50)
        Me.RbBrNotOpen.Name = "RbBrNotOpen"
        Me.RbBrNotOpen.Size = New System.Drawing.Size(65, 16)
        Me.RbBrNotOpen.TabIndex = 4
        Me.RbBrNotOpen.TabStop = True
        Me.RbBrNotOpen.Text = "開かない"
        Me.RbBrNotOpen.UseVisualStyleBackColor = True
        '
        'RbBrOpen
        '
        Me.RbBrOpen.AutoSize = True
        Me.RbBrOpen.Location = New System.Drawing.Point(107, 50)
        Me.RbBrOpen.Name = "RbBrOpen"
        Me.RbBrOpen.Size = New System.Drawing.Size(41, 16)
        Me.RbBrOpen.TabIndex = 3
        Me.RbBrOpen.TabStop = True
        Me.RbBrOpen.Text = "開く"
        Me.RbBrOpen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "起動時にブラウザを"
        '
        'TxtDrive
        '
        Me.TxtDrive.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtDrive.Location = New System.Drawing.Point(76, 21)
        Me.TxtDrive.MaxLength = 1
        Me.TxtDrive.Name = "TxtDrive"
        Me.TxtDrive.Size = New System.Drawing.Size(17, 19)
        Me.TxtDrive.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "仮想ドライブ"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtMySQLStop)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtMySQLStart)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.RbMySQLDisable)
        Me.GroupBox3.Controls.Add(Me.RbMySQLEnable)
        Me.GroupBox3.Location = New System.Drawing.Point(309, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 110)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MySQL"
        '
        'TxtMySQLStop
        '
        Me.TxtMySQLStop.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtMySQLStop.Location = New System.Drawing.Point(74, 77)
        Me.TxtMySQLStop.Name = "TxtMySQLStop"
        Me.TxtMySQLStop.Size = New System.Drawing.Size(196, 19)
        Me.TxtMySQLStop.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "MySQLAdm"
        '
        'TxtMySQLStart
        '
        Me.TxtMySQLStart.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtMySQLStart.Location = New System.Drawing.Point(74, 49)
        Me.TxtMySQLStart.Name = "TxtMySQLStart"
        Me.TxtMySQLStart.Size = New System.Drawing.Size(196, 19)
        Me.TxtMySQLStart.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "実行ファイル"
        '
        'RbMySQLDisable
        '
        Me.RbMySQLDisable.AutoSize = True
        Me.RbMySQLDisable.Location = New System.Drawing.Point(80, 23)
        Me.RbMySQLDisable.Name = "RbMySQLDisable"
        Me.RbMySQLDisable.Size = New System.Drawing.Size(76, 16)
        Me.RbMySQLDisable.TabIndex = 1
        Me.RbMySQLDisable.TabStop = True
        Me.RbMySQLDisable.Text = "起動しない"
        Me.RbMySQLDisable.UseVisualStyleBackColor = True
        '
        'RbMySQLEnable
        '
        Me.RbMySQLEnable.AutoSize = True
        Me.RbMySQLEnable.Location = New System.Drawing.Point(6, 24)
        Me.RbMySQLEnable.Name = "RbMySQLEnable"
        Me.RbMySQLEnable.Size = New System.Drawing.Size(66, 16)
        Me.RbMySQLEnable.TabIndex = 0
        Me.RbMySQLEnable.TabStop = True
        Me.RbMySQLEnable.Text = "起動する"
        Me.RbMySQLEnable.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtApacheStart)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.RbApacheDisable)
        Me.GroupBox2.Controls.Add(Me.RbApacheEnable)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 81)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apache"
        '
        'TxtApacheStart
        '
        Me.TxtApacheStart.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtApacheStart.Location = New System.Drawing.Point(75, 49)
        Me.TxtApacheStart.Name = "TxtApacheStart"
        Me.TxtApacheStart.Size = New System.Drawing.Size(196, 19)
        Me.TxtApacheStart.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "実行ファイル"
        '
        'RbApacheDisable
        '
        Me.RbApacheDisable.AutoSize = True
        Me.RbApacheDisable.Location = New System.Drawing.Point(80, 23)
        Me.RbApacheDisable.Name = "RbApacheDisable"
        Me.RbApacheDisable.Size = New System.Drawing.Size(76, 16)
        Me.RbApacheDisable.TabIndex = 1
        Me.RbApacheDisable.TabStop = True
        Me.RbApacheDisable.Text = "起動しない"
        Me.RbApacheDisable.UseVisualStyleBackColor = True
        '
        'RbApacheEnable
        '
        Me.RbApacheEnable.AutoSize = True
        Me.RbApacheEnable.Location = New System.Drawing.Point(6, 24)
        Me.RbApacheEnable.Name = "RbApacheEnable"
        Me.RbApacheEnable.Size = New System.Drawing.Size(66, 16)
        Me.RbApacheEnable.TabIndex = 0
        Me.RbApacheEnable.TabStop = True
        Me.RbApacheEnable.Text = "起動する"
        Me.RbApacheEnable.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtPostgreSQLStart)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.RbPostgreSQLDisable)
        Me.GroupBox4.Controls.Add(Me.RbPostgreSQLEnable)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 163)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 79)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PostgreSQL"
        '
        'TxtPostgreSQLStart
        '
        Me.TxtPostgreSQLStart.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtPostgreSQLStart.Location = New System.Drawing.Point(75, 49)
        Me.TxtPostgreSQLStart.Name = "TxtPostgreSQLStart"
        Me.TxtPostgreSQLStart.Size = New System.Drawing.Size(196, 19)
        Me.TxtPostgreSQLStart.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 12)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "実行ファイル"
        '
        'RbPostgreSQLDisable
        '
        Me.RbPostgreSQLDisable.AutoSize = True
        Me.RbPostgreSQLDisable.Location = New System.Drawing.Point(80, 23)
        Me.RbPostgreSQLDisable.Name = "RbPostgreSQLDisable"
        Me.RbPostgreSQLDisable.Size = New System.Drawing.Size(76, 16)
        Me.RbPostgreSQLDisable.TabIndex = 1
        Me.RbPostgreSQLDisable.TabStop = True
        Me.RbPostgreSQLDisable.Text = "起動しない"
        Me.RbPostgreSQLDisable.UseVisualStyleBackColor = True
        '
        'RbPostgreSQLEnable
        '
        Me.RbPostgreSQLEnable.AutoSize = True
        Me.RbPostgreSQLEnable.Location = New System.Drawing.Point(6, 24)
        Me.RbPostgreSQLEnable.Name = "RbPostgreSQLEnable"
        Me.RbPostgreSQLEnable.Size = New System.Drawing.Size(66, 16)
        Me.RbPostgreSQLEnable.TabIndex = 0
        Me.RbPostgreSQLEnable.TabStop = True
        Me.RbPostgreSQLEnable.Text = "起動する"
        Me.RbPostgreSQLEnable.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(528, 215)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(63, 30)
        Me.BtnOK.TabIndex = 7
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'CtxtMenu
        '
        Me.CtxtMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Home, Me.ToolStripMenuItem2, Me.ApacheToolStripMenuItem, Me.MySQLToolStripMenuItem, Me.PostgreSQLToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem4, Me.Menu_EXIT})
        Me.CtxtMenu.Name = "rMenu"
        Me.CtxtMenu.Size = New System.Drawing.Size(153, 148)
        '
        'Menu_Home
        '
        Me.Menu_Home.Name = "Menu_Home"
        Me.Menu_Home.Size = New System.Drawing.Size(152, 22)
        Me.Menu_Home.Text = "ホーム"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'ApacheToolStripMenuItem
        '
        Me.ApacheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_ApacheStart, Me.Menu_ApacheStop, Me.Menu_ApacheRestart})
        Me.ApacheToolStripMenuItem.Name = "ApacheToolStripMenuItem"
        Me.ApacheToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApacheToolStripMenuItem.Text = "Apache"
        '
        'Menu_ApacheStart
        '
        Me.Menu_ApacheStart.Name = "Menu_ApacheStart"
        Me.Menu_ApacheStart.Size = New System.Drawing.Size(110, 22)
        Me.Menu_ApacheStart.Text = "起動"
        '
        'Menu_ApacheStop
        '
        Me.Menu_ApacheStop.Name = "Menu_ApacheStop"
        Me.Menu_ApacheStop.Size = New System.Drawing.Size(110, 22)
        Me.Menu_ApacheStop.Text = "停止"
        '
        'Menu_ApacheRestart
        '
        Me.Menu_ApacheRestart.Name = "Menu_ApacheRestart"
        Me.Menu_ApacheRestart.Size = New System.Drawing.Size(110, 22)
        Me.Menu_ApacheRestart.Text = "再起動"
        '
        'MySQLToolStripMenuItem
        '
        Me.MySQLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_MySQLStart, Me.Menu_MySQLStop, Me.Menu_MySQLRestart})
        Me.MySQLToolStripMenuItem.Name = "MySQLToolStripMenuItem"
        Me.MySQLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MySQLToolStripMenuItem.Text = "MySQL"
        '
        'Menu_MySQLStart
        '
        Me.Menu_MySQLStart.Name = "Menu_MySQLStart"
        Me.Menu_MySQLStart.Size = New System.Drawing.Size(110, 22)
        Me.Menu_MySQLStart.Text = "起動"
        '
        'Menu_MySQLStop
        '
        Me.Menu_MySQLStop.Name = "Menu_MySQLStop"
        Me.Menu_MySQLStop.Size = New System.Drawing.Size(110, 22)
        Me.Menu_MySQLStop.Text = "停止"
        '
        'Menu_MySQLRestart
        '
        Me.Menu_MySQLRestart.Name = "Menu_MySQLRestart"
        Me.Menu_MySQLRestart.Size = New System.Drawing.Size(110, 22)
        Me.Menu_MySQLRestart.Text = "再起動"
        '
        'PostgreSQLToolStripMenuItem
        '
        Me.PostgreSQLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_PgSQLStart, Me.Menu_PgSQLStop, Me.Menu_PgSQLRestart})
        Me.PostgreSQLToolStripMenuItem.Name = "PostgreSQLToolStripMenuItem"
        Me.PostgreSQLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PostgreSQLToolStripMenuItem.Text = "PostgreSQL"
        Me.PostgreSQLToolStripMenuItem.Visible = False
        '
        'Menu_PgSQLStart
        '
        Me.Menu_PgSQLStart.Name = "Menu_PgSQLStart"
        Me.Menu_PgSQLStart.Size = New System.Drawing.Size(110, 22)
        Me.Menu_PgSQLStart.Text = "起動"
        '
        'Menu_PgSQLStop
        '
        Me.Menu_PgSQLStop.Name = "Menu_PgSQLStop"
        Me.Menu_PgSQLStop.Size = New System.Drawing.Size(110, 22)
        Me.Menu_PgSQLStop.Text = "停止"
        '
        'Menu_PgSQLRestart
        '
        Me.Menu_PgSQLRestart.Name = "Menu_PgSQLRestart"
        Me.Menu_PgSQLRestart.Size = New System.Drawing.Size(110, 22)
        Me.Menu_PgSQLRestart.Text = "再起動"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "コマンドプロンプト"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(149, 6)
        '
        'Menu_EXIT
        '
        Me.Menu_EXIT.Name = "Menu_EXIT"
        Me.Menu_EXIT.Size = New System.Drawing.Size(152, 22)
        Me.Menu_EXIT.Text = "終了"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 252)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WAPMP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.CtxtMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtTopPage As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtWait As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RbBrNotOpen As RadioButton
    Friend WithEvents RbBrOpen As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDrive As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtMySQLStop As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMySQLStart As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RbMySQLDisable As RadioButton
    Friend WithEvents RbMySQLEnable As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtApacheStart As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RbApacheDisable As RadioButton
    Friend WithEvents RbApacheEnable As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtPostgreSQLStart As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RbPostgreSQLDisable As RadioButton
    Friend WithEvents RbPostgreSQLEnable As RadioButton
    Friend WithEvents BtnOK As Button
    Friend WithEvents CtxtMenu As ContextMenuStrip
    Friend WithEvents Menu_Home As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ApacheToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_ApacheStart As ToolStripMenuItem
    Friend WithEvents Menu_ApacheStop As ToolStripMenuItem
    Friend WithEvents Menu_ApacheRestart As ToolStripMenuItem
    Friend WithEvents MySQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_MySQLStart As ToolStripMenuItem
    Friend WithEvents Menu_MySQLStop As ToolStripMenuItem
    Friend WithEvents Menu_MySQLRestart As ToolStripMenuItem
    Friend WithEvents PostgreSQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_PgSQLStart As ToolStripMenuItem
    Friend WithEvents Menu_PgSQLStop As ToolStripMenuItem
    Friend WithEvents Menu_PgSQLRestart As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents Menu_EXIT As ToolStripMenuItem
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents Label5 As Label
End Class
