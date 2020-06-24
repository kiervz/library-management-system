Public Class ucReports

    Private Sub btnBooksMasterList_Click(sender As Object, e As EventArgs) Handles btnBooksInventory.Click
        OpenTransparentForm(Me)

        AN_ActivityLog() 'Auto Number for activity log
        RecordActivities(userID, "View Books Inventory Report", "Books Inventory Report") 'Activity

        Dim books_master_list As New frmReportBooksInventory
        books_master_list.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        OpenTransparentForm(Me)

        AN_ActivityLog() 'Auto Number for activity log
        RecordActivities(userID, "View Attendance Report", "Attendance Report") 'Activity

        Dim attendance As New frmReportsAttendance
        attendance.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub btnFacultyMasterList_Click(sender As Object, e As EventArgs) Handles btnFacultyMasterList.Click
        OpenTransparentForm(Me)

        AN_ActivityLog() 'Auto Number for activity log
        RecordActivities(userID, "View Faculty Master List Report", "Faculty Master List Report") 'Activity

        Dim faculty As New frmReportFacultyMasterList
        faculty.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub btnStudentMasterList_Click(sender As Object, e As EventArgs) Handles btnStudentMasterList.Click
        OpenTransparentForm(Me)

        AN_ActivityLog() 'Auto Number for activity log
        RecordActivities(userID, "View Student Master List Report", "Student Master List Report") 'Activity

        Dim student As New frmReportStudentMasterList
        student.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenTransparentForm(Me)

        AN_ActivityLog() 'Auto Number for activity log
        RecordActivities(userID, "View Borrowed Books Report", "Borrowed Books Report") 'Activity

        Dim book_borrowed As New frmReportBooksBorrowed
        book_borrowed.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub btnPenaltyList_Click(sender As Object, e As EventArgs) Handles btnPenaltyList.Click
        OpenTransparentForm(Me)

        AN_ActivityLog() 'Auto Number for activity log
        RecordActivities(userID, "View Penalty List Report", "Penalty List Report") 'Activity

        Dim penalty_list As New frmReportPenaltyList
        penalty_list.ShowDialog(Me)
        CloseTransparentForm()
    End Sub
End Class
