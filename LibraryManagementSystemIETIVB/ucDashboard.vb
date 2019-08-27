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
        frmMain.btnBorrowers.PerformClick()
        frmMain.btnBorrowers.Focus()
    End Sub

    Private Sub moreInfoBooksOverdue_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox10.DoubleClick, Panel10.DoubleClick, Label22.DoubleClick

    End Sub
End Class
