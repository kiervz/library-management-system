Public Class ucReports

    Private Sub btnBooksMasterList_Click(sender As Object, e As EventArgs) Handles btnBooksInventory.Click
        OpenTransparentForm(Me)
        Dim books_master_list As New frmReportBooksInventory
        books_master_list.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        OpenTransparentForm(Me)
        Dim attendance As New frmReportsAttendance
        attendance.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub btnFacultyMasterList_Click(sender As Object, e As EventArgs) Handles btnFacultyMasterList.Click
        OpenTransparentForm(Me)
        Dim faculty As New frmReportFacultyMasterList
        faculty.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub btnStudentMasterList_Click(sender As Object, e As EventArgs) Handles btnStudentMasterList.Click
        OpenTransparentForm(Me)
        Dim student As New frmReportStudentMasterList
        student.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenTransparentForm(Me)
        Dim book_borrowed As New frmReportBooksBorrowed
        book_borrowed.ShowDialog(Me)
        CloseTransparentForm()
    End Sub
End Class
