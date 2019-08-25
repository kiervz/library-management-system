Imports System.Drawing.Drawing2D
Imports MetroFramework.Forms
Imports Tulpep.NotificationWindow

Public Class frmMain

    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H2000000
    '        Return cp
    '    End Get
    'End Property

    Private Sub movePanelSelector(btn As Control)
        panelSelector.Top = btn.Top
        panelSelector.Height = btn.Height
    End Sub


    Private Sub HideAllUserControl()
        UcAboutIETI1.Visible = False
        UcActivityLog1.Visible = False
        UcBookManagement1.Visible = False
        UcBorrowers1.Visible = False
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
    End Sub

    Private Sub btnBorrowers_Click(sender As Object, e As EventArgs) Handles btnBorrowers.Click
        movePanelSelector(btnBorrowers)
        HideAllUserControl()
        UcBorrowers1.Visible = True
        lblTitle.Text = "Borrowers"
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
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        movePanelSelector(btnUserManagement)
        HideAllUserControl()
        UcUserManagement1.Visible = True
        lblTitle.Text = "Users Management\Manage User"
    End Sub

    Private Sub btnActivityLog_Click(sender As Object, e As EventArgs) Handles btnActivityLog.Click
        movePanelSelector(btnActivityLog)
        HideAllUserControl()
        UcActivityLog1.Visible = True
        lblTitle.Text = "Activity Log"
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        CustomMessageBox.ShowDialog(Me, "Are you sure you want to Logout?", "Logout", MessageBoxButtonn.YesCancel, MessageBoxIconn.Question)

        If msgBoxButtonClick = DialogResult.Yes Then
            Me.Close()
            Dim login As New frmLogin
            login.ShowDialog()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CustomMessageBox.ShowDialog(Me, "Are you sure you want to Exit?", "Exit", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

        If msgBoxButtonClick = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub pictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles pbProfile.Paint
        Dim gp As New GraphicsPath
        gp.AddEllipse(0, 0, pbProfile.Width - 2, pbProfile.Height - 2)
        Dim rg As New Region(gp)
        pbProfile.Region = rg
    End Sub

    Private Sub panelBgSearch_Click(sender As Object, e As EventArgs) Handles panelBgSearch.Click
        txtSearch.Focus()
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        txtSearch.Focus()
    End Sub

    Private Sub pbSearch_Click(sender As Object, e As EventArgs) Handles pbSearch.Click
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


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        If userImage = "My.Resources.ietilogo" Then
            pbProfile.Image = My.Resources.ietilogo
        Else
            pbProfile.Image = Image.FromFile(userImage)
        End If

        lblFname.Text = userFname
        lblUserType.Text = userType

        HideAllUserControl()
        lblTitle.Text = "Dashboard"
        UcDashboard1.Visible = True

        UserLogTime = DateTime.Now
        lblDuration.Text = "00:00:00"

        Notifier()
    End Sub

    Private Sub login()
        Dim login As New frmLogin
        login.ShowDialog()
    End Sub

    Private Sub Notifier()
        Dim notif As New PopupNotifier
        notif.Image = My.Resources.admin3
        notif.HeaderHeight = 15
        notif.HeaderColor = Color.Teal
        notif.TitleFont = New Font("Century Gothic", 11)
        notif.ContentFont = New Font("Century Gothic", 10)
        notif.TitleText = "Library Management System"
        notif.ContentText = "Welcome back " + userType + " " + userFname
        notif.Popup()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currentLogIn = DateTime.Now - UserLogTime

        If currentLogIn.Days.ToString("00") > 0 Then
            lblDuration.Text = currentLogIn.Days.ToString("00") + ":" + currentLogIn.Hours.ToString("00") + ":" + currentLogIn.Minutes.ToString("00") + ":" + currentLogIn.Seconds.ToString("00")
        Else
            lblDuration.Text = currentLogIn.Hours.ToString("00") + ":" + currentLogIn.Minutes.ToString("00") + ":" + currentLogIn.Seconds.ToString("00")
        End If
    End Sub
End Class