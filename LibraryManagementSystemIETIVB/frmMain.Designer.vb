
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.btnIssuedReturn = New System.Windows.Forms.Button()
        Me.btnFacultyManagement = New System.Windows.Forms.Button()
        Me.btnMessages = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnAuditLog = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnStudentsMangement = New System.Windows.Forms.Button()
        Me.btnBookManagement = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.panelSelector = New System.Windows.Forms.Panel()
        Me.divider = New MaterialSkin.Controls.MaterialDivider()
        Me.panelCenter = New System.Windows.Forms.Panel()
        Me.UcIssuedReturn1 = New LibraryManagementSystemIETIVB.ucIssuedReturn()
        Me.UcFacultyManagement1 = New LibraryManagementSystemIETIVB.ucFacultyManagement()
        Me.UcAttendance1 = New LibraryManagementSystemIETIVB.ucAttendance()
        Me.UcUserManagement1 = New LibraryManagementSystemIETIVB.ucUserManagement()
        Me.UcStudentManagement1 = New LibraryManagementSystemIETIVB.ucStudentManagement()
        Me.UcSettings1 = New LibraryManagementSystemIETIVB.ucSettings()
        Me.UcReports1 = New LibraryManagementSystemIETIVB.ucReports()
        Me.UcMessages1 = New LibraryManagementSystemIETIVB.ucMessages()
        Me.UcDashboard1 = New LibraryManagementSystemIETIVB.ucDashboard()
        Me.UcBookManagement1 = New LibraryManagementSystemIETIVB.ucBookManagement()
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
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.tsSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.panelBgSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pbSearch = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnChevron = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panelAccount = New System.Windows.Forms.Panel()
        Me.SystemIdleTimer1 = New LibraryManagementSystemIETIVB.SystemIdleTimer()
        Me.panelLeft.SuspendLayout()
        Me.panelCenter.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MaterialContextMenuStrip1.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBgSearch.SuspendLayout()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.panelLeft.Controls.Add(Me.btnIssuedReturn)
        Me.panelLeft.Controls.Add(Me.btnFacultyManagement)
        Me.panelLeft.Controls.Add(Me.btnMessages)
        Me.panelLeft.Controls.Add(Me.btnSettings)
        Me.panelLeft.Controls.Add(Me.btnReports)
        Me.panelLeft.Controls.Add(Me.btnAuditLog)
        Me.panelLeft.Controls.Add(Me.btnUserManagement)
        Me.panelLeft.Controls.Add(Me.btnStudentsMangement)
        Me.panelLeft.Controls.Add(Me.btnBookManagement)
        Me.panelLeft.Controls.Add(Me.btnAttendance)
        Me.panelLeft.Controls.Add(Me.btnDashboard)
        Me.panelLeft.Controls.Add(Me.panelSelector)
        Me.panelLeft.Location = New System.Drawing.Point(0, 220)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(234, 548)
        Me.panelLeft.TabIndex = 0
        '
        'btnIssuedReturn
        '
        Me.btnIssuedReturn.BackColor = System.Drawing.SystemColors.Control
        Me.btnIssuedReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssuedReturn.FlatAppearance.BorderSize = 0
        Me.btnIssuedReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnIssuedReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedReturn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuedReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnIssuedReturn.Image = CType(resources.GetObject("btnIssuedReturn.Image"), System.Drawing.Image)
        Me.btnIssuedReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuedReturn.Location = New System.Drawing.Point(4, 156)
        Me.btnIssuedReturn.Name = "btnIssuedReturn"
        Me.btnIssuedReturn.Size = New System.Drawing.Size(230, 45)
        Me.btnIssuedReturn.TabIndex = 12
        Me.btnIssuedReturn.Text = "   ISSUED && RETURN"
        Me.btnIssuedReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIssuedReturn.UseVisualStyleBackColor = False
        '
        'btnFacultyManagement
        '
        Me.btnFacultyManagement.BackColor = System.Drawing.SystemColors.Control
        Me.btnFacultyManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacultyManagement.FlatAppearance.BorderSize = 0
        Me.btnFacultyManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnFacultyManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacultyManagement.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacultyManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnFacultyManagement.Image = CType(resources.GetObject("btnFacultyManagement.Image"), System.Drawing.Image)
        Me.btnFacultyManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacultyManagement.Location = New System.Drawing.Point(4, 246)
        Me.btnFacultyManagement.Name = "btnFacultyManagement"
        Me.btnFacultyManagement.Size = New System.Drawing.Size(230, 45)
        Me.btnFacultyManagement.TabIndex = 11
        Me.btnFacultyManagement.Text = "   FACULTY MANAGEMENT"
        Me.btnFacultyManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFacultyManagement.UseVisualStyleBackColor = False
        '
        'btnMessages
        '
        Me.btnMessages.BackColor = System.Drawing.SystemColors.Control
        Me.btnMessages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMessages.FlatAppearance.BorderSize = 0
        Me.btnMessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessages.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnMessages.Image = CType(resources.GetObject("btnMessages.Image"), System.Drawing.Image)
        Me.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMessages.Location = New System.Drawing.Point(4, 336)
        Me.btnMessages.Name = "btnMessages"
        Me.btnMessages.Size = New System.Drawing.Size(230, 45)
        Me.btnMessages.TabIndex = 5
        Me.btnMessages.Text = "   MESSAGES"
        Me.btnMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMessages.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(4, 471)
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
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(4, 426)
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
        Me.btnAuditLog.FlatAppearance.BorderSize = 0
        Me.btnAuditLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditLog.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuditLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnAuditLog.Image = CType(resources.GetObject("btnAuditLog.Image"), System.Drawing.Image)
        Me.btnAuditLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuditLog.Location = New System.Drawing.Point(4, 381)
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
        Me.btnUserManagement.FlatAppearance.BorderSize = 0
        Me.btnUserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserManagement.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUserManagement.Image = CType(resources.GetObject("btnUserManagement.Image"), System.Drawing.Image)
        Me.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserManagement.Location = New System.Drawing.Point(4, 291)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(230, 45)
        Me.btnUserManagement.TabIndex = 4
        Me.btnUserManagement.Text = "   USERS MANAGEMENT"
        Me.btnUserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserManagement.UseVisualStyleBackColor = False
        '
        'btnStudentsMangement
        '
        Me.btnStudentsMangement.BackColor = System.Drawing.SystemColors.Control
        Me.btnStudentsMangement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentsMangement.FlatAppearance.BorderSize = 0
        Me.btnStudentsMangement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnStudentsMangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentsMangement.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentsMangement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnStudentsMangement.Image = CType(resources.GetObject("btnStudentsMangement.Image"), System.Drawing.Image)
        Me.btnStudentsMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentsMangement.Location = New System.Drawing.Point(4, 201)
        Me.btnStudentsMangement.Name = "btnStudentsMangement"
        Me.btnStudentsMangement.Size = New System.Drawing.Size(230, 45)
        Me.btnStudentsMangement.TabIndex = 3
        Me.btnStudentsMangement.Text = "   STUDENTS MANAGEMENT"
        Me.btnStudentsMangement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudentsMangement.UseVisualStyleBackColor = False
        '
        'btnBookManagement
        '
        Me.btnBookManagement.BackColor = System.Drawing.SystemColors.Control
        Me.btnBookManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookManagement.FlatAppearance.BorderSize = 0
        Me.btnBookManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookManagement.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnBookManagement.Image = CType(resources.GetObject("btnBookManagement.Image"), System.Drawing.Image)
        Me.btnBookManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookManagement.Location = New System.Drawing.Point(4, 111)
        Me.btnBookManagement.Name = "btnBookManagement"
        Me.btnBookManagement.Size = New System.Drawing.Size(230, 45)
        Me.btnBookManagement.TabIndex = 2
        Me.btnBookManagement.Text = "   BOOKS MANAGEMENT"
        Me.btnBookManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookManagement.UseVisualStyleBackColor = False
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.SystemColors.Control
        Me.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendance.FlatAppearance.BorderSize = 0
        Me.btnAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnAttendance.Image = CType(resources.GetObject("btnAttendance.Image"), System.Drawing.Image)
        Me.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAttendance.Location = New System.Drawing.Point(4, 66)
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
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(4, 21)
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
        Me.panelSelector.Location = New System.Drawing.Point(0, 21)
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
        Me.panelCenter.Controls.Add(Me.UcFacultyManagement1)
        Me.panelCenter.Controls.Add(Me.UcAttendance1)
        Me.panelCenter.Controls.Add(Me.UcUserManagement1)
        Me.panelCenter.Controls.Add(Me.UcStudentManagement1)
        Me.panelCenter.Controls.Add(Me.UcSettings1)
        Me.panelCenter.Controls.Add(Me.UcReports1)
        Me.panelCenter.Controls.Add(Me.UcMessages1)
        Me.panelCenter.Controls.Add(Me.UcDashboard1)
        Me.panelCenter.Controls.Add(Me.UcBookManagement1)
        Me.panelCenter.Controls.Add(Me.UcActivityLog1)
        Me.panelCenter.Controls.Add(Me.UcAboutIETI1)
        Me.panelCenter.Controls.Add(Me.Panel4)
        Me.panelCenter.Location = New System.Drawing.Point(240, 124)
        Me.panelCenter.Name = "panelCenter"
        Me.panelCenter.Size = New System.Drawing.Size(1126, 632)
        Me.panelCenter.TabIndex = 5
        '
        'UcIssuedReturn1
        '
        Me.UcIssuedReturn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcIssuedReturn1.Location = New System.Drawing.Point(0, 33)
        Me.UcIssuedReturn1.Name = "UcIssuedReturn1"
        Me.UcIssuedReturn1.Size = New System.Drawing.Size(1126, 599)
        Me.UcIssuedReturn1.TabIndex = 23
        '
        'UcFacultyManagement1
        '
        Me.UcFacultyManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFacultyManagement1.Location = New System.Drawing.Point(0, 33)
        Me.UcFacultyManagement1.Name = "UcFacultyManagement1"
        Me.UcFacultyManagement1.Size = New System.Drawing.Size(1126, 599)
        Me.UcFacultyManagement1.TabIndex = 22
        '
        'UcAttendance1
        '
        Me.UcAttendance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAttendance1.Location = New System.Drawing.Point(0, 33)
        Me.UcAttendance1.Name = "UcAttendance1"
        Me.UcAttendance1.Size = New System.Drawing.Size(1126, 599)
        Me.UcAttendance1.TabIndex = 21
        '
        'UcUserManagement1
        '
        Me.UcUserManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcUserManagement1.Location = New System.Drawing.Point(0, 33)
        Me.UcUserManagement1.Name = "UcUserManagement1"
        Me.UcUserManagement1.Size = New System.Drawing.Size(1126, 599)
        Me.UcUserManagement1.TabIndex = 20
        '
        'UcStudentManagement1
        '
        Me.UcStudentManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcStudentManagement1.Location = New System.Drawing.Point(0, 33)
        Me.UcStudentManagement1.Name = "UcStudentManagement1"
        Me.UcStudentManagement1.Size = New System.Drawing.Size(1126, 599)
        Me.UcStudentManagement1.TabIndex = 19
        '
        'UcSettings1
        '
        Me.UcSettings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcSettings1.Location = New System.Drawing.Point(0, 33)
        Me.UcSettings1.Name = "UcSettings1"
        Me.UcSettings1.Size = New System.Drawing.Size(1126, 599)
        Me.UcSettings1.TabIndex = 18
        '
        'UcReports1
        '
        Me.UcReports1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcReports1.Location = New System.Drawing.Point(0, 33)
        Me.UcReports1.Name = "UcReports1"
        Me.UcReports1.Size = New System.Drawing.Size(1126, 599)
        Me.UcReports1.TabIndex = 17
        '
        'UcMessages1
        '
        Me.UcMessages1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMessages1.Location = New System.Drawing.Point(0, 33)
        Me.UcMessages1.Name = "UcMessages1"
        Me.UcMessages1.Size = New System.Drawing.Size(1126, 599)
        Me.UcMessages1.TabIndex = 16
        '
        'UcDashboard1
        '
        Me.UcDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDashboard1.Location = New System.Drawing.Point(0, 33)
        Me.UcDashboard1.Name = "UcDashboard1"
        Me.UcDashboard1.Size = New System.Drawing.Size(1126, 599)
        Me.UcDashboard1.TabIndex = 15
        '
        'UcBookManagement1
        '
        Me.UcBookManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBookManagement1.Location = New System.Drawing.Point(0, 33)
        Me.UcBookManagement1.Name = "UcBookManagement1"
        Me.UcBookManagement1.Size = New System.Drawing.Size(1126, 599)
        Me.UcBookManagement1.TabIndex = 13
        '
        'UcActivityLog1
        '
        Me.UcActivityLog1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcActivityLog1.Location = New System.Drawing.Point(0, 33)
        Me.UcActivityLog1.Name = "UcActivityLog1"
        Me.UcActivityLog1.Size = New System.Drawing.Size(1126, 599)
        Me.UcActivityLog1.TabIndex = 12
        '
        'UcAboutIETI1
        '
        Me.UcAboutIETI1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAboutIETI1.Location = New System.Drawing.Point(0, 33)
        Me.UcAboutIETI1.Name = "UcAboutIETI1"
        Me.UcAboutIETI1.Size = New System.Drawing.Size(1126, 599)
        Me.UcAboutIETI1.TabIndex = 11
        '
        'Panel4
        '
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
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
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
        Me.Panel1.BackColor = System.Drawing.Color.Silver
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
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Version: 1.8.9 - Copyright 2019"
        '
        'lblDuration
        '
        Me.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDuration.AutoSize = True
        Me.lblDuration.BackColor = System.Drawing.Color.Silver
        Me.lblDuration.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.Black
        Me.lblDuration.Location = New System.Drawing.Point(351, 3)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(15, 17)
        Me.lblDuration.TabIndex = 22
        Me.lblDuration.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(284, 2)
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
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.AutoSize = False
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSettings, Me.tsLogout})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(188, 80)
        '
        'tsSettings
        '
        Me.tsSettings.AutoSize = False
        Me.tsSettings.Image = CType(resources.GetObject("tsSettings.Image"), System.Drawing.Image)
        Me.tsSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsSettings.Name = "tsSettings"
        Me.tsSettings.Padding = New System.Windows.Forms.Padding(20, 1, 0, 1)
        Me.tsSettings.Size = New System.Drawing.Size(188, 38)
        Me.tsSettings.Text = "   SETTINGS"
        Me.tsSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsLogout
        '
        Me.tsLogout.AutoSize = False
        Me.tsLogout.Image = CType(resources.GetObject("tsLogout.Image"), System.Drawing.Image)
        Me.tsLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsLogout.Name = "tsLogout"
        Me.tsLogout.Padding = New System.Windows.Forms.Padding(20, 1, 0, 1)
        Me.tsLogout.Size = New System.Drawing.Size(188, 38)
        Me.tsLogout.Text = "   LOGOUT"
        Me.tsLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbProfile
        '
        Me.pbProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbProfile.Image = CType(resources.GetObject("pbProfile.Image"), System.Drawing.Image)
        Me.pbProfile.Location = New System.Drawing.Point(1118, 37)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(45, 41)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 3
        Me.pbProfile.TabStop = False
        '
        'panelBgSearch
        '
        Me.panelBgSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.panelBgSearch.Controls.Add(Me.lblSearch)
        Me.panelBgSearch.Controls.Add(Me.txtSearch)
        Me.panelBgSearch.Controls.Add(Me.pbSearch)
        Me.panelBgSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panelBgSearch.Location = New System.Drawing.Point(423, 35)
        Me.panelBgSearch.Name = "panelBgSearch"
        Me.panelBgSearch.Size = New System.Drawing.Size(610, 48)
        Me.panelBgSearch.TabIndex = 4
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic)
        Me.lblSearch.ForeColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(68, 13)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(161, 20)
        Me.lblSearch.TabIndex = 11
        Me.lblSearch.Text = "type words to search for"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.Location = New System.Drawing.Point(52, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(541, 20)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.TabStop = False
        '
        'pbSearch
        '
        Me.pbSearch.BackgroundImage = CType(resources.GetObject("pbSearch.BackgroundImage"), System.Drawing.Image)
        Me.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbSearch.ImageLocation = ""
        Me.pbSearch.Location = New System.Drawing.Point(12, 10)
        Me.pbSearch.Name = "pbSearch"
        Me.pbSearch.Size = New System.Drawing.Size(27, 24)
        Me.pbSearch.TabIndex = 4
        Me.pbSearch.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(22, 21)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(184, 125)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 5
        Me.pictureBox3.TabStop = False
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label1.Location = New System.Drawing.Point(10, 155)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(215, 60)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Library Management System"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnChevron
        '
        Me.btnChevron.BackgroundImage = CType(resources.GetObject("btnChevron.BackgroundImage"), System.Drawing.Image)
        Me.btnChevron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnChevron.ContextMenuStrip = Me.MaterialContextMenuStrip1
        Me.btnChevron.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChevron.FlatAppearance.BorderSize = 0
        Me.btnChevron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnChevron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChevron.Location = New System.Drawing.Point(1327, 51)
        Me.btnChevron.Name = "btnChevron"
        Me.btnChevron.Size = New System.Drawing.Size(24, 16)
        Me.btnChevron.TabIndex = 8
        Me.btnChevron.UseVisualStyleBackColor = True
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
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.Color.White
        Me.lblFname.Location = New System.Drawing.Point(1169, 37)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(62, 20)
        Me.lblFname.TabIndex = 12
        Me.lblFname.Text = "Kiervey"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUserType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(1169, 57)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(100, 20)
        Me.lblUserType.TabIndex = 13
        Me.lblUserType.Text = "Administrator"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.panel2.Controls.Add(Me.lblUserType)
        Me.panel2.Controls.Add(Me.lblFname)
        Me.panel2.Controls.Add(Me.btnClose)
        Me.panel2.Controls.Add(Me.btnChevron)
        Me.panel2.Controls.Add(Me.btnMinimize)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Controls.Add(Me.pictureBox3)
        Me.panel2.Controls.Add(Me.panelBgSearch)
        Me.panel2.Controls.Add(Me.pbProfile)
        Me.panel2.Controls.Add(Me.panelAccount)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1366, 220)
        Me.panel2.TabIndex = 2
        '
        'panelAccount
        '
        Me.panelAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelAccount.Location = New System.Drawing.Point(1117, 37)
        Me.panelAccount.Name = "panelAccount"
        Me.panelAccount.Size = New System.Drawing.Size(234, 41)
        Me.panelAccount.TabIndex = 14
        '
        'SystemIdleTimer1
        '
        Me.SystemIdleTimer1.MaxIdleTime = CType(10UI, UInteger)
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
        Me.MaterialContextMenuStrip1.ResumeLayout(False)
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBgSearch.ResumeLayout(False)
        Me.panelBgSearch.PerformLayout()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Private WithEvents btnSettings As System.Windows.Forms.Button
    Private WithEvents btnReports As System.Windows.Forms.Button
    Private WithEvents btnAuditLog As System.Windows.Forms.Button
    Private WithEvents panelSelector As System.Windows.Forms.Panel
    Private WithEvents btnDashboard As System.Windows.Forms.Button
    Private WithEvents btnMessages As System.Windows.Forms.Button
    Friend WithEvents divider As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents panelCenter As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel

    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcUserManagement1 As LibraryManagementSystemIETIVB.ucUserManagement
    Friend WithEvents UcStudentManagement1 As LibraryManagementSystemIETIVB.ucStudentManagement
    Friend WithEvents UcSettings1 As LibraryManagementSystemIETIVB.ucSettings
    Friend WithEvents UcReports1 As LibraryManagementSystemIETIVB.ucReports
    Friend WithEvents UcMessages1 As LibraryManagementSystemIETIVB.ucMessages
    Friend WithEvents UcDashboard1 As LibraryManagementSystemIETIVB.ucDashboard
    Friend WithEvents UcBookManagement1 As LibraryManagementSystemIETIVB.ucBookManagement
    Friend WithEvents UcActivityLog1 As LibraryManagementSystemIETIVB.ucActivityLog
    Friend WithEvents UcAboutIETI1 As LibraryManagementSystemIETIVB.ucAboutIETI
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents SystemIdleTimer1 As LibraryManagementSystemIETIVB.SystemIdleTimer
    Friend WithEvents PopupNotifier1 As Tulpep.NotificationWindow.PopupNotifier
    Friend WithEvents btnBookManagement As System.Windows.Forms.Button
    Friend WithEvents btnStudentsMangement As System.Windows.Forms.Button
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents tsSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLogout As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pbProfile As System.Windows.Forms.PictureBox
    Private WithEvents panelBgSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Private WithEvents pbSearch As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnChevron As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents panelAccount As System.Windows.Forms.Panel
    Friend WithEvents btnUserManagement As System.Windows.Forms.Button
    Friend WithEvents btnFacultyManagement As Button
    Friend WithEvents UcAttendance1 As ucAttendance
    Friend WithEvents UcFacultyManagement1 As ucFacultyManagement
    Friend WithEvents btnIssuedReturn As Button
    Friend WithEvents UcIssuedReturn1 As ucIssuedReturn
End Class
