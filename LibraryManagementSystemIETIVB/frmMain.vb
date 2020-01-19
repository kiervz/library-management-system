﻿Imports System.Drawing.Drawing2D

Public Class frmMain
    Private idle As New SystemIdleTimer


    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        idle.Start()

        lblFname.Text = userFname
        lblUserType.Text = userType

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
        End If

        lblDuration.Text = "00:00:00"
        UserLogTime = DateTime.Now

        Notifier() 'Welcome notification will show

    End Sub

    Private Sub movePanelSelector(btn As Control)
        panelSelector.Top = btn.Top
        panelSelector.Height = btn.Height
    End Sub

    Private Sub LoggedInAsStudentAssistant()
        btnUserManagement.Visible = False
        btnAuditLog.Visible = False
        btnReports.Visible = False
        btnMessages.Location = New Point(4, 239)
        btnSettings.Location = New Point(4, 284)
    End Sub

    Private Sub HideAllUserControl()
        UcAboutIETI1.Visible = False
        UcActivityLog1.Visible = False
        UcBookManagement1.Visible = False
        UcAttendance1.Visible = False
        UcDashboard1.Visible = False
        UcMessages1.Visible = False
        UcReports1.Visible = False
        UcSettings1.Visible = False
        UcStudentManagement1.Visible = False
        UcUserManagement1.Visible = False
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        movePanelSelector(btnDashboard)
        HideAllUserControl()
        UcDashboard1.Visible = True
        lblTitle.Text = "Dashboard"
        UcDashboard1.TotalUsers()
        UcDashboard1.TotalStudents()
    End Sub


    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        movePanelSelector(btnAttendance)
        HideAllUserControl()
        UcAttendance1.Visible = True
        UcAttendance1.FillGridView()
        lblTitle.Text = "Attendance"
    End Sub


    Private Sub btnFacultyManagement_Click(sender As Object, e As EventArgs) Handles btnFacultyManagement.Click
        movePanelSelector(btnFacultyManagement)
        HideAllUserControl()
        UcFacultyManagement1.Visible = True
        UcFacultyManagement1.FillGridView()
        lblTitle.Text = "Faculty Management"
    End Sub

    Private Sub btnBookManagement_Click(sender As Object, e As EventArgs) Handles btnBookManagement.Click
        movePanelSelector(btnBookManagement)
        HideAllUserControl()
        UcBookManagement1.Visible = True
        lblTitle.Text = "Books Management"
    End Sub

    Private Sub btnStudentsMangement_Click(sender As Object, e As EventArgs) Handles btnStudentsMangement.Click
        movePanelSelector(btnStudentsMangement)
        HideAllUserControl()
        UcStudentManagement1.Visible = True
        lblTitle.Text = "Students Management"
        UcStudentManagement1.FillGridView()
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
        UcSettings1.Visible = True
        lblTitle.Text = "Settings"
    End Sub

    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click
        movePanelSelector(btnMessages)
        HideAllUserControl()
        UcMessages1.Visible = True
        lblTitle.Text = "Messages"
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CustomMessageBox.ShowDialog(Me, "Are you sure you want to Exit?", "Exit", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

        If msgBoxButtonClick = DialogResult.Yes Then Application.Exit()
    End Sub

    'Circle Picture box
    Private Sub pictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles pbProfile.Paint
        Dim gp As New GraphicsPath
        gp.AddEllipse(0, 0, pbProfile.Width - 2, pbProfile.Height - 2)
        Dim rg As New Region(gp)
        pbProfile.Region = rg
    End Sub

    Private Sub panelBgSearch_Click(sender As Object, e As EventArgs) Handles panelBgSearch.Click, lblSearch.Click, pbSearch.Click
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearch.Visible = False
        Else
            lblSearch.Visible = True
        End If
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
                Application.Exit()
            End If
        End If

    End Sub

    Private Sub PopupNotifier1_Click(sender As Object, e As EventArgs) Handles PopupNotifier1.Click
        btnSettings.PerformClick()
        btnSettings.Focus()
    End Sub

    Private Sub pbProfile_Click(sender As Object, e As EventArgs) Handles pbProfile.Click, lblUserType.Click, lblFname.Click, btnChevron.Click, panelAccount.Click
        btnChevron.ContextMenuStrip.Show(New Point(1163, 80))
    End Sub

    Private Sub tsLogout_Click(sender As Object, e As EventArgs) Handles tsLogout.Click
        CustomMessageBox.ShowDialog(Me, "Are you sure you want to Logout?", "Logout", MessageBoxButtonn.YesCancel, MessageBoxIconn.Question)

        If msgBoxButtonClick = DialogResult.Yes Then
            Me.Close()
            Dim login As New frmLogin
            login.Show()
        End If
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            Dim systemIdle As New frmSetSystemIdle
            systemIdle.ShowDialog(Me)
        End If
    End Sub

End Class