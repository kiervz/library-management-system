Imports System.Data.SqlClient

Public Class ucDashboard


    Private Sub moreInfoTotalBooks_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox7.DoubleClick, Panel7.DoubleClick, Label19.DoubleClick
        frmMain.btnBookManagement.PerformClick()
        frmMain.btnBookManagement.Focus()
    End Sub

    Private Sub moreInfoTotalStudents_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox8.DoubleClick, Panel8.DoubleClick, Label20.DoubleClick
        frmMain.btnStudentsMangement.PerformClick()
        frmMain.btnStudentsMangement.Focus()
    End Sub

    Private Sub moreInfoTotalBorrowers_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox9.DoubleClick, Panel9.DoubleClick, Label21.DoubleClick
        frmMain.btnAttendance.PerformClick()
        frmMain.btnAttendance.Focus()
    End Sub

    Private Sub moreInfoTotalUsers_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox11.DoubleClick, Panel11.DoubleClick, Label23.DoubleClick
        frmMain.btnUserManagement.PerformClick()
        frmMain.btnUserManagement.Focus()
    End Sub

    Private Sub moreInfoBooksOverdue_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox10.DoubleClick, Panel10.DoubleClick, Label22.DoubleClick

    End Sub

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        TotalUsers()
    End Sub

    Friend Sub TotalUsers()
        Try
            str = "SELECT COUNT(*) AS TotalUsers FROM users WHERE Status = '1'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then

                lblTotalUser.Text = dr("TotalUsers").ToString()

            End If

        Catch ex As Exception
            CustomMessageBox.ShowDialog(Me, ex.Message, "Error")
        End Try
    End Sub

End Class
