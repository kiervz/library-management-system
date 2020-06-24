
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBorrowers = New System.Windows.Forms.Button()
        Me.btnIssuedReturn = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnAuditLog = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnBookManagement = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.panelSelector = New System.Windows.Forms.Panel()
        Me.divider = New MaterialSkin.Controls.MaterialDivider()
        Me.panelCenter = New System.Windows.Forms.Panel()
        Me.UcIssuedReturn1 = New LibraryManagementSystemIETIVB.ucIssuedReturn()
        Me.UcRecords1 = New LibraryManagementSystemIETIVB.ucRecords()
        Me.UcBorrowers1 = New LibraryManagementSystemIETIVB.ucBorrowers()
        Me.UcAttendance1 = New LibraryManagementSystemIETIVB.ucAttendance()
        Me.UcUserManagement1 = New LibraryManagementSystemIETIVB.ucUserManagement()
        Me.UcSettings1 = New LibraryManagementSystemIETIVB.ucSettings()
        Me.UcReports1 = New LibraryManagementSystemIETIVB.ucReports()
        Me.UcDashboard1 = New LibraryManagementSystemIETIVB.ucDashboard()
        Me.UcBookManagement1 = New LibraryManagementSystemIETIVB.ucBookEntry()
        Me.UcActivityLog1 = New LibraryManagementSystemIETIVB.ucActivityLog()
        Me.UcAboutIETI1 = New LibraryManagementSystemIETIVB.ucAboutIETI()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PopupNotifier1 = New Tulpep.NotificationWindow.PopupNotifier()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.txtUserType = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SystemIdleTimer1 = New LibraryManagementSystemIETIVB.SystemIdleTimer()
        Me.panelLeft.SuspendLayout()
        Me.panelCenter.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.panelLeft.Controls.Add(Me.btnLogout)
        Me.panelLeft.Controls.Add(Me.btnBorrowers)
        Me.panelLeft.Controls.Add(Me.btnIssuedReturn)
        Me.panelLeft.Controls.Add(Me.btnRecords)
        Me.panelLeft.Controls.Add(Me.btnSettings)
        Me.panelLeft.Controls.Add(Me.btnReports)
        Me.panelLeft.Controls.Add(Me.btnAuditLog)
        Me.panelLeft.Controls.Add(Me.btnUserManagement)
        Me.panelLeft.Controls.Add(Me.btnBookManagement)
        Me.panelLeft.Controls.Add(Me.btnAttendance)
        Me.panelLeft.Controls.Add(Me.btnDashboard)
        Me.panelLeft.Controls.Add(Me.panelSelector)
        Me.panelLeft.Location = New System.Drawing.Point(0, 220)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(234, 548)
        Me.panelLeft.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(4, 501)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(230, 45)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "   LOGOUT"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBorrowers
        '
        Me.btnBorrowers.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrowers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowers.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBorrowers.FlatAppearance.BorderSize = 0
        Me.btnBorrowers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowers.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnBorrowers.Image = CType(resources.GetObject("btnBorrowers.Image"), System.Drawing.Image)
        Me.btnBorrowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowers.Location = New System.Drawing.Point(4, 226)
        Me.btnBorrowers.Name = "btnBorrowers"
        Me.btnBorrowers.Size = New System.Drawing.Size(230, 45)
        Me.btnBorrowers.TabIndex = 13
        Me.btnBorrowers.Text = "   BORROWERS"
        Me.btnBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrowers.UseVisualStyleBackColor = False
        '
        'btnIssuedReturn
        '
        Me.btnIssuedReturn.BackColor = System.Drawing.SystemColors.Control
        Me.btnIssuedReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssuedReturn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnIssuedReturn.FlatAppearance.BorderSize = 0
        Me.btnIssuedReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnIssuedReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedReturn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuedReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnIssuedReturn.Image = CType(resources.GetObject("btnIssuedReturn.Image"), System.Drawing.Image)
        Me.btnIssuedReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuedReturn.Location = New System.Drawing.Point(4, 181)
        Me.btnIssuedReturn.Name = "btnIssuedReturn"
        Me.btnIssuedReturn.Size = New System.Drawing.Size(230, 45)
        Me.btnIssuedReturn.TabIndex = 12
        Me.btnIssuedReturn.Text = "   ISSUED && RETURN"
        Me.btnIssuedReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIssuedReturn.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.SystemColors.Control
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnRecords.Image = CType(resources.GetObject("btnRecords.Image"), System.Drawing.Image)
        Me.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.Location = New System.Drawing.Point(4, 136)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(230, 45)
        Me.btnRecords.TabIndex = 5
        Me.btnRecords.Text = "   BOOK RECORDS"
        Me.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(4, 406)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(230, 45)
        Me.btnSettings.TabIndex = 8
        Me.btnSettings.Text = "   SETTINGS"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.SystemColors.Control
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(4, 361)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(230, 45)
        Me.btnReports.TabIndex = 7
        Me.btnReports.Text = "   REPORTS"
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnAuditLog
        '
        Me.btnAuditLog.BackColor = System.Drawing.SystemColors.Control
        Me.btnAuditLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAuditLog.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAuditLog.FlatAppearance.BorderSize = 0
        Me.btnAuditLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditLog.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuditLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnAuditLog.Image = CType(resources.GetObject("btnAuditLog.Image"), System.Drawing.Image)
        Me.btnAuditLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuditLog.Location = New System.Drawing.Point(4, 316)
        Me.btnAuditLog.Name = "btnAuditLog"
        Me.btnAuditLog.Size = New System.Drawing.Size(230, 45)
        Me.btnAuditLog.TabIndex = 6
        Me.btnAuditLog.Text = "   AUDIT LOG"
        Me.btnAuditLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAuditLog.UseVisualStyleBackColor = False
        '
        'btnUserManagement
        '
        Me.btnUserManagement.BackColor = System.Drawing.SystemColors.Control
        Me.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserManagement.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUserManagement.FlatAppearance.BorderSize = 0
        Me.btnUserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserManagement.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUserManagement.Image = CType(resources.GetObject("btnUserManagement.Image"), System.Drawing.Image)
        Me.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserManagement.Location = New System.Drawing.Point(4, 271)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(230, 45)
        Me.btnUserManagement.TabIndex = 4
        Me.btnUserManagement.Text = "   USERS MANAGEMENT"
        Me.btnUserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserManagement.UseVisualStyleBackColor = False
        '
        'btnBookManagement
        '
        Me.btnBookManagement.BackColor = System.Drawing.SystemColors.Control
        Me.btnBookManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookManagement.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBookManagement.FlatAppearance.BorderSize = 0
        Me.btnBookManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookManagement.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnBookManagement.Image = CType(resources.GetObject("btnBookManagement.Image"), System.Drawing.Image)
        Me.btnBookManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookManagement.Location = New System.Drawing.Point(4, 91)
        Me.btnBookManagement.Name = "btnBookManagement"
        Me.btnBookManagement.Size = New System.Drawing.Size(230, 45)
        Me.btnBookManagement.TabIndex = 2
        Me.btnBookManagement.Text = "   BOOK ENTRY"
        Me.btnBookManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookManagement.UseVisualStyleBackColor = False
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.SystemColors.Control
        Me.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendance.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAttendance.FlatAppearance.BorderSize = 0
        Me.btnAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnAttendance.Image = CType(resources.GetObject("btnAttendance.Image"), System.Drawing.Image)
        Me.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAttendance.Location = New System.Drawing.Point(4, 46)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(230, 45)
        Me.btnAttendance.TabIndex = 1
        Me.btnAttendance.Text = "   ATTENDANCE"
        Me.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.SystemColors.Control
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(4, 1)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(230, 45)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "   DASHBOARD"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'panelSelector
        '
        Me.panelSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.panelSelector.Location = New System.Drawing.Point(0, 1)
        Me.panelSelector.Name = "panelSelector"
        Me.panelSelector.Size = New System.Drawing.Size(6, 45)
        Me.panelSelector.TabIndex = 10
        '
        'divider
        '
        Me.divider.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.divider.Depth = 0
        Me.divider.Location = New System.Drawing.Point(0, -5)
        Me.divider.MouseState = MaterialSkin.MouseState.HOVER
        Me.divider.Name = "divider"
        Me.divider.Size = New System.Drawing.Size(1126, 10)
        Me.divider.TabIndex = 8
        Me.divider.Text = "MaterialDivider1"
        '
        'panelCenter
        '
        Me.panelCenter.BackColor = System.Drawing.Color.White
        Me.panelCenter.Controls.Add(Me.UcIssuedReturn1)
        Me.panelCenter.Controls.Add(Me.UcRecords1)
        Me.panelCenter.Controls.Add(Me.UcBorrowers1)
        Me.panelCenter.Controls.Add(Me.UcAttendance1)
        Me.panelCenter.Controls.Add(Me.UcUserManagement1)
        Me.panelCenter.Controls.Add(Me.UcSettings1)
        Me.panelCenter.Controls.Add(Me.UcReports1)
        Me.panelCenter.Controls.Add(Me.UcDashboard1)
        Me.panelCenter.Controls.Add(Me.UcBookManagement1)
        Me.panelCenter.Controls.Add(Me.UcActivityLog1)
        Me.panelCenter.Controls.Add(Me.UcAboutIETI1)
        Me.panelCenter.Controls.Add(Me.Panel4)
        Me.panelCenter.Location = New System.Drawing.Point(240, 89)
        Me.panelCenter.Name = "panelCenter"
        Me.panelCenter.Size = New System.Drawing.Size(1126, 659)
        Me.panelCenter.TabIndex = 5
        '
        'UcIssuedReturn1
        '
        Me.UcIssuedReturn1.BackColor = System.Drawing.Color.White
        Me.UcIssuedReturn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcIssuedReturn1.Location = New System.Drawing.Point(0, 33)
        Me.UcIssuedReturn1.Name = "UcIssuedReturn1"
        Me.UcIssuedReturn1.Size = New System.Drawing.Size(1126, 626)
        Me.UcIssuedReturn1.TabIndex = 26
        '
        'UcRecords1
        '
        Me.UcRecords1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcRecords1.Location = New System.Drawing.Point(0, 33)
        Me.UcRecords1.Name = "UcRecords1"
        Me.UcRecords1.Size = New System.Drawing.Size(1126, 626)
        Me.UcRecords1.TabIndex = 25
        '
        'UcBorrowers1
        '
        Me.UcBorrowers1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBorrowers1.Location = New System.Drawing.Point(0, 33)
        Me.UcBorrowers1.Name = "UcBorrowers1"
        Me.UcBorrowers1.Size = New System.Drawing.Size(1126, 626)
        Me.UcBorrowers1.TabIndex = 24
        '
        'UcAttendance1
        '
        Me.UcAttendance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAttendance1.Location = New System.Drawing.Point(0, 33)
        Me.UcAttendance1.Name = "UcAttendance1"
        Me.UcAttendance1.Size = New System.Drawing.Size(1126, 626)
        Me.UcAttendance1.TabIndex = 21
        '
        'UcUserManagement1
        '
        Me.UcUserManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcUserManagement1.Location = New System.Drawing.Point(0, 33)
        Me.UcUserManagement1.Name = "UcUserManagement1"
        Me.UcUserManagement1.Size = New System.Drawing.Size(1126, 626)
        Me.UcUserManagement1.TabIndex = 20
        '
        'UcSettings1
        '
        Me.UcSettings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcSettings1.Location = New System.Drawing.Point(0, 33)
        Me.UcSettings1.Name = "UcSettings1"
        Me.UcSettings1.Size = New System.Drawing.Size(1126, 626)
        Me.UcSettings1.TabIndex = 18
        '
        'UcReports1
        '
        Me.UcReports1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcReports1.Location = New System.Drawing.Point(0, 33)
        Me.UcReports1.Name = "UcReports1"
        Me.UcReports1.Size = New System.Drawing.Size(1126, 626)
        Me.UcReports1.TabIndex = 17
        '
        'UcDashboard1
        '
        Me.UcDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDashboard1.Location = New System.Drawing.Point(0, 33)
        Me.UcDashboard1.Name = "UcDashboard1"
        Me.UcDashboard1.Size = New System.Drawing.Size(1126, 626)
        Me.UcDashboard1.TabIndex = 15
        '
        'UcBookManagement1
        '
        Me.UcBookManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBookManagement1.Location = New System.Drawing.Point(0, 33)
        Me.UcBookManagement1.Name = "UcBookManagement1"
        Me.UcBookManagement1.Size = New System.Drawing.Size(1126, 626)
        Me.UcBookManagement1.TabIndex = 13
        '
        'UcActivityLog1
        '
        Me.UcActivityLog1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcActivityLog1.Location = New System.Drawing.Point(0, 33)
        Me.UcActivityLog1.Name = "UcActivityLog1"
        Me.UcActivityLog1.Size = New System.Drawing.Size(1126, 626)
        Me.UcActivityLog1.TabIndex = 12
        '
        'UcAboutIETI1
        '
        Me.UcAboutIETI1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAboutIETI1.Location = New System.Drawing.Point(0, 33)
        Me.UcAboutIETI1.Name = "UcAboutIETI1"
        Me.UcAboutIETI1.Size = New System.Drawing.Size(1126, 626)
        Me.UcAboutIETI1.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblTitle)
        Me.Panel4.Controls.Add(Me.divider)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1126, 33)
        Me.Panel4.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(3, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(595, 26)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Library Management System"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblDuration)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(240, 748)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1126, 20)
        Me.Panel1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Version: 1.8.9 - Copyright 2020"
        '
        'lblDuration
        '
        Me.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDuration.AutoSize = True
        Me.lblDuration.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lblDuration.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.Black
        Me.lblDuration.Location = New System.Drawing.Point(613, 2)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(15, 17)
        Me.lblDuration.TabIndex = 22
        Me.lblDuration.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(546, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Duration:"
        '
        'PopupNotifier1
        '
        Me.PopupNotifier1.ContentFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupNotifier1.ContentText = Nothing
        Me.PopupNotifier1.HeaderColor = System.Drawing.Color.Teal
        Me.PopupNotifier1.HeaderHeight = 15
        Me.PopupNotifier1.Image = Nothing
        Me.PopupNotifier1.IsRightToLeft = False
        Me.PopupNotifier1.OptionsMenu = Nothing
        Me.PopupNotifier1.Size = New System.Drawing.Size(400, 100)
        Me.PopupNotifier1.TitleFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupNotifier1.TitleText = Nothing
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(419, 3)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(135, 81)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 5
        Me.pictureBox3.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(1307, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(23, 23)
        Me.btnMinimize.TabIndex = 7
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(1336, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.panel2.Controls.Add(Me.lblDateTime)
        Me.panel2.Controls.Add(Me.txtUserType)
        Me.panel2.Controls.Add(Me.txtName)
        Me.panel2.Controls.Add(Me.pbProfile)
        Me.panel2.Controls.Add(Me.Label2)
        Me.panel2.Controls.Add(Me.btnClose)
        Me.panel2.Controls.Add(Me.btnMinimize)
        Me.panel2.Controls.Add(Me.pictureBox3)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1366, 220)
        Me.panel2.TabIndex = 2
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(1036, 48)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(284, 18)
        Me.lblDateTime.TabIndex = 28
        Me.lblDateTime.Text = "Monday, 22 January 2020  │  6:12:03 AM "
        '
        'txtUserType
        '
        Me.txtUserType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtUserType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserType.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtUserType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserType.ForeColor = System.Drawing.Color.White
        Me.txtUserType.Location = New System.Drawing.Point(11, 171)
        Me.txtUserType.Name = "txtUserType"
        Me.txtUserType.ReadOnly = True
        Me.txtUserType.Size = New System.Drawing.Size(222, 20)
        Me.txtUserType.TabIndex = 27
        Me.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(11, 145)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(222, 20)
        Me.txtName.TabIndex = 16
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbProfile
        '
        Me.pbProfile.Location = New System.Drawing.Point(83, 69)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(81, 70)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 0
        Me.pbProfile.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(532, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 60)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "International Electronics && Technical Institute Inc.,"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SystemIdleTimer1
        '
        Me.SystemIdleTimer1.MaxIdleTime = CType(300UI, UInteger)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelCenter)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelLeft.ResumeLayout(False)
        Me.panelCenter.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Private WithEvents btnSettings As System.Windows.Forms.Button
    Private WithEvents btnReports As System.Windows.Forms.Button
    Private WithEvents btnAuditLog As System.Windows.Forms.Button
    Private WithEvents panelSelector As System.Windows.Forms.Panel
    Private WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents divider As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents panelCenter As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel

    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcUserManagement1 As LibraryManagementSystemIETIVB.ucUserManagement
    Friend WithEvents UcSettings1 As LibraryManagementSystemIETIVB.ucSettings
    Friend WithEvents UcReports1 As LibraryManagementSystemIETIVB.ucReports
    Friend WithEvents UcDashboard1 As LibraryManagementSystemIETIVB.ucDashboard
    Friend WithEvents UcBookManagement1 As LibraryManagementSystemIETIVB.ucBookEntry
    Friend WithEvents UcActivityLog1 As LibraryManagementSystemIETIVB.ucActivityLog
    Friend WithEvents UcAboutIETI1 As LibraryManagementSystemIETIVB.ucAboutIETI
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents SystemIdleTimer1 As LibraryManagementSystemIETIVB.SystemIdleTimer
    Friend WithEvents PopupNotifier1 As Tulpep.NotificationWindow.PopupNotifier
    Friend WithEvents btnBookManagement As System.Windows.Forms.Button
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnUserManagement As System.Windows.Forms.Button
    Friend WithEvents UcAttendance1 As ucAttendance
    Friend WithEvents btnIssuedReturn As Button
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents btnBorrowers As Button
    Friend WithEvents UcBorrowers1 As ucBorrowers
    Friend WithEvents UcRecords1 As ucRecords
    Friend WithEvents btnRecords As Button
    Friend WithEvents UcIssuedReturn1 As ucIssuedReturn
    Private WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUserType As TextBox
    Private WithEvents btnLogout As Button
    Friend WithEvents lblDateTime As Label
End Class
