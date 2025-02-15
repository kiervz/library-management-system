﻿Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class frmMain

    Private idle As New SystemIdleTimer

    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        lblDuration.Text = "00:00:00"
        lblDateTime.Text = Date.Now.ToString("dddd, dd MMMM yyyy") + Space(2) + "│" + Space(2) + DateTime.Now.ToString("hh:mm:ss tt")
        UserLogTime = DateTime.Now

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        idle.Start()

        txtName.Text = userFname + " " + userLname
        txtUserType.Text = userType

        Try
            pbProfile.Image = Image.FromFile(userImage)
        Catch ex As Exception
            pbProfile.Image = My.Resources.no_image
        End Try

        HideAllUserControl()
        lblTitle.Text = "Dashboard"
        UcDashboard1.Visible = True

        If userType = "Student Assistant" Then
            LoggedInAsStudentAssistant()
        ElseIf userType = "Librarian" Then
            LoggedInAsLibrarian
        End If

        Notifier() 'Welcome notification will show
        btnDashboard.PerformClick()
    End Sub

    Friend Sub movePanelSelector(btn As Control)
        panelSelector.Top = btn.Top
        panelSelector.Height = btn.Height
    End Sub

    Private Sub LoggedInAsStudentAssistant()
        UcSettings1.MetroTabControl1.HideTab(UcSettings1.MetroTabPage2)
        btnUserManagement.Visible = False
        btnAuditLog.Visible = False
        btnReports.Visible = False
        btnSettings.Location = New Point(4, 271)
    End Sub

    Private Sub LoggedInAsLibrarian()
        UcSettings1.MetroTabControl1.HideTab(UcSettings1.MetroTabPage2)
        btnAuditLog.Visible = False
        btnReports.Location = New Point(4, 316)
        btnSettings.Location = New Point(4, 361)
    End Sub

    Friend Sub HideAllUserControl()
        UcAboutIETI1.Visible = False
        UcActivityLog1.Visible = False
        UcBookManagement1.Visible = False
        UcAttendance1.Visible = False
        UcDashboard1.Visible = False
        UcRecords1.Visible = False
        UcReports1.Visible = False
        UcSettings1.Visible = False
        UcBorrowers1.Visible = False
        UcUserManagement1.Visible = False
        UcIssuedReturn1.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        movePanelSelector(btnDashboard)
        HideAllUserControl()
        lblTitle.Text = "Dashboard"
        UcDashboard1.Visible = True
        UcDashboard1.TotalStudents()
        UcDashboard1.TotalBookLost()
        UcDashboard1.TotalBooks()
        UcDashboard1.TotalBorrowers()
        UcDashboard1.TotalOverDue()
        UcDashboard1.TotalFaculties()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        movePanelSelector(btnAttendance)
        HideAllUserControl()
        UcAttendance1.Visible = True
        UcAttendance1.FillGridView()
        lblTitle.Text = "Attendance"
    End Sub

    Private Sub btnIssuedReturn_Click(sender As Object, e As EventArgs) Handles btnIssuedReturn.Click
        movePanelSelector(btnIssuedReturn)
        HideAllUserControl()
        UcIssuedReturn1.Visible = True
        UcIssuedReturn1.LoadBorrowedBooks()
        lblTitle.Text = "Issued && Return"
    End Sub

    Private Sub btnBookManagement_Click(sender As Object, e As EventArgs) Handles btnBookManagement.Click
        movePanelSelector(btnBookManagement)
        HideAllUserControl()
        UcBookManagement1.Visible = True
        UcBookManagement1.FillGridView()
        lblTitle.Text = "Books Entry"
    End Sub

    Private Sub btnBorrowers_Click(sender As Object, e As EventArgs) Handles btnBorrowers.Click
        movePanelSelector(btnBorrowers)
        HideAllUserControl()
        If Not isFacultiesImporting = True Or Not isStudentsImporting = True Then
            UcBorrowers1.FillGridViewStudent()
            UcBorrowers1.FillGridViewFaculty()
        End If
        UcBorrowers1.Visible = True
        lblTitle.Text = "Borrowers"
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        movePanelSelector(btnUserManagement)
        HideAllUserControl()
        UcUserManagement1.Visible = True
        lblTitle.Text = "Users Management"
        UcUserManagement1.dgvUserInfo.Focus()
        UcUserManagement1.FillDGV()
        UcUserManagement1.FillDGVArchived()
    End Sub

    Private Sub btnActivityLog_Click(sender As Object, e As EventArgs) Handles btnAuditLog.Click
        movePanelSelector(btnAuditLog)
        HideAllUserControl()
        UcActivityLog1.Visible = True
        UcActivityLog1.ActivityLog()
        UcActivityLog1.LogInOutHistory()
        lblTitle.Text = "Audit Log"
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        movePanelSelector(btnReports)
        HideAllUserControl()
        UcReports1.Visible = True
        lblTitle.Text = "Reports"
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        movePanelSelector(btnSettings)
        HideAllUserControl()
        UcSettings1.LoadGracePeriod()
        UcSettings1.Visible = True
        lblTitle.Text = "Settings"
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        movePanelSelector(btnRecords)
        HideAllUserControl()
        UcRecords1.Visible = True
        UcRecords1.MetroTabControl1.SelectedIndex = 0
        UcRecords1.LoadBookOverdue()
        UcRecords1.LoadBookReturned()
        UcRecords1.LoadBookBorrowed()
        UcRecords1.LoadBookInventory()
        UcRecords1.LoadBookLost()
        lblTitle.Text = "Records"
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)
        If mes = DialogResult.Yes Then Application.Exit() LogOutHistory()
    End Sub

    Private Sub btnMinimize_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimize.MouseEnter
        ToolTip1.SetToolTip(btnMinimize, "Minimize")
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        ToolTip1.SetToolTip(btnClose, "Close")
    End Sub

    Private Sub Notifier()
        PopupNotifier1.Image = My.Resources.admin3
        PopupNotifier1.TitleText = "Library Management System"
        PopupNotifier1.ContentText = "Welcome back " + userType + " " + userFname
        PopupNotifier1.Popup()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dddd, dd MMMM yyyy") + Space(2) + "│" + Space(2) + DateTime.Now.ToString("hh:mm:ss tt")
        Dim currentLogIn = DateTime.Now - UserLogTime

        AddHandler idle.OnEnterIdleState, Sub(sender2, eventargs2)
                                              isSystemIDLE = True
                                          End Sub
        idle.MaxIdleTime = My.Settings.IdleTime

        'Duration Time
        If currentLogIn.Days.ToString("00") > 0 Then
            lblDuration.Text = currentLogIn.Days.ToString("00") + ":" + currentLogIn.Hours.ToString("00") + ":" + currentLogIn.Minutes.ToString("00") + ":" + currentLogIn.Seconds.ToString("00")
        Else
            lblDuration.Text = currentLogIn.Hours.ToString("00") + ":" + currentLogIn.Minutes.ToString("00") + ":" + currentLogIn.Seconds.ToString("00")
        End If

        If isSystemIDLE Then
            Timer1.Stop()
            idle.Stop()

            Dim confirmPass As New frmPasswordConfirmIDLE
            confirmPass.ShowDialog(Me)

            If isPasswordCorrect Then
                Timer1.Start()
                idle.Start()
                isSystemIDLE = False
                isPasswordCorrect = False
                idlePasswordAttempts = 0
            Else
                LogOutHistory()
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub PopupNotifier1_Click(sender As Object, e As EventArgs) Handles PopupNotifier1.Click
        btnSettings.PerformClick()
        btnSettings.Focus()
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            Dim systemIdle As New frmSetSystemIdle
            systemIdle.ShowDialog(Me)
        End If
    End Sub

    Private Sub pbProfile_Paint(sender As Object, e As PaintEventArgs) Handles pbProfile.Paint
        Dim gp As New GraphicsPath
        gp.AddEllipse(0, 0, pbProfile.Width - 2, pbProfile.Height - 2)
        Dim rg As New Region(gp)
        pbProfile.Region = rg
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

        If mes = DialogResult.Yes Then
            LogOutHistory()
            Me.Close()
            Dim login As New frmLogin
            login.Show()
        End If
    End Sub

    Private Sub LogOutHistory()
        Try
            dateTimeLogout = DateTime.Now
            str = "UPDATE log_in_out SET logout = '" + CDate(dateTimeLogout) + "' WHERE id ='" + CStr(loginout_id) + "'"
            cmd = New SqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class