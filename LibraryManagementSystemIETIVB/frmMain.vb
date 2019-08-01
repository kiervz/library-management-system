Imports System.Drawing.Drawing2D
Imports MetroFramework.Forms

Public Class frmMain


    Private Sub movePanelSelector(btn As Control)
        panelSelector.Top = btn.Top
        panelSelector.Height = btn.Height
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        movePanelSelector(btnDashboard)
    End Sub

    Private Sub btnBorrowers_Click(sender As Object, e As EventArgs) Handles btnBorrowers.Click
        movePanelSelector(btnBorrowers)
    End Sub

    Private Sub btnBookManagement_Click(sender As Object, e As EventArgs) Handles btnBookManagement.Click
        movePanelSelector(btnBookManagement)
    End Sub

    Private Sub btnStudentsMangement_Click(sender As Object, e As EventArgs) Handles btnStudentsMangement.Click
        movePanelSelector(btnStudentsMangement)
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        movePanelSelector(btnUserManagement)
    End Sub

    Private Sub btnActivityLog_Click(sender As Object, e As EventArgs) Handles btnActivityLog.Click
        movePanelSelector(btnActivityLog)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        movePanelSelector(btnReports)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        movePanelSelector(btnSettings)
    End Sub

    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click
        movePanelSelector(btnMessages)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        movePanelSelector(btnLogout)
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim ask As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

        If ask = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnRestoreMaximize_LocationChanged(sender As Object, e As EventArgs) Handles btnRestoreMaximize.LocationChanged
        If btnRestoreMaximize.Location = New Point(1080, 6) Then
            btnRestoreMaximize.Image = My.Resources.restore_down
        Else
            btnRestoreMaximize.Image = My.Resources.maximize
        End If
    End Sub


    Private Sub btnRestoreMaximize_Click(sender As Object, e As EventArgs) Handles btnRestoreMaximize.Click
        If btnRestoreMaximize.Location = New Point(1080, 6) Then
            panelCenter.Size = New Size(886, 633)
            divider.Size = New Size(886, 5)
            btnRestoreMaximize.Location = New Point(857, 4)
        Else
            panelCenter.Size = New Size(1126, 633)
            divider.Size = New Size(1126, 5)
            btnRestoreMaximize.Location = New Point(1080, 6)
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


    Private Sub btnRestoreMaximize_MouseEnter(sender As Object, e As EventArgs) Handles btnRestoreMaximize.MouseEnter
        MetroToolTip1.ShowAlways = True
        If btnRestoreMaximize.Location = New Point(1091, 11) Then
            MetroToolTip1.SetToolTip(btnRestoreMaximize, "Restore Down")
        Else
            MetroToolTip1.SetToolTip(btnRestoreMaximize, "Maximize")
        End If

    End Sub

    Private Sub btnMinimize_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimize.MouseEnter
        MetroToolTip1.SetToolTip(btnMinimize, "Minimize")
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        MetroToolTip1.SetToolTip(btnClose, "Close")
    End Sub


End Class