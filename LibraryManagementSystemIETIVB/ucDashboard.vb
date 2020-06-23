Imports System.Data.SqlClient

Public Class ucDashboard


    Private Sub moreInfoTotalBooks_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox7.DoubleClick, Panel7.DoubleClick, Label19.DoubleClick
        frmMain.btnBookManagement.PerformClick()
        frmMain.btnBookManagement.Focus()
    End Sub

    Private Sub moreInfoTotalStudents_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox8.DoubleClick, Panel8.DoubleClick, Label20.DoubleClick
        frmMain.btnBorrowers.PerformClick()
        frmMain.UcBorrowers1.MetroTabControl1.SelectedIndex = 0
        frmMain.btnBorrowers.Focus()
    End Sub

    Private Sub moreInfoTotalBorrowers_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox9.DoubleClick, Panel9.DoubleClick, Label21.DoubleClick
        frmMain.btnRecords.PerformClick()
        frmMain.UcRecords1.MetroTabControl1.SelectedIndex = 1
        frmMain.btnRecords.Focus()
    End Sub

    Private Sub moreInfoTotalUsers_DoubleClick(sender As Object, e As EventArgs)
        frmMain.btnUserManagement.PerformClick()
        frmMain.btnUserManagement.Focus()
    End Sub

    Private Sub Label24_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox12.DoubleClick, Label24.DoubleClick
        frmMain.btnRecords.PerformClick()
        frmMain.UcRecords1.MetroTabControl1.SelectedIndex = 3
        frmMain.btnRecords.Focus()
    End Sub

    Private Sub moreInfoBooksOverdue_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox10.DoubleClick, Panel10.DoubleClick, Label22.DoubleClick
        frmMain.btnRecords.PerformClick()
        frmMain.UcRecords1.MetroTabControl1.SelectedIndex = 4
        frmMain.btnRecords.Focus()
    End Sub

    Private Sub moreInfo_totalFaculties(sender As Object, e As EventArgs) Handles PictureBox13.DoubleClick, Label3.DoubleClick
        frmMain.btnBorrowers.PerformClick()
        frmMain.UcBorrowers1.MetroTabControl1.SelectedIndex = 1
        frmMain.btnBorrowers.Focus()
    End Sub

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
    End Sub

    Friend Sub TotalStudents()
        Try
            str = "SELECT COUNT(*) AS TotalStudents FROM students WHERE status_id = '1'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim totalStudent As Decimal = dr("TotalStudents").ToString()
                lblTotalStudents.Text = Format(totalStudent, "N0")
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub TotalFaculties()
        Try
            str = "SELECT COUNT(*) AS TotalFaculties FROM faculties WHERE status_id = '1'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim totalFaculties As Decimal = dr("TotalFaculties").ToString()
                lblTotalFaculties.Text = Format(totalFaculties, "N0")
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub


    Friend Sub TotalOverDue()
        Try
            str = "SELECT COUNT(*) AS total_overdue FROM borrows WHERE (day_penalty > 0) AND (status_id = 1)"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim totalOverdue As Integer = dr("total_overdue").ToString()
                lblTotalOverdue.Text = Format(totalOverdue, "N0")
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub TotalBorrowers()
        Try
            str = "SELECT COUNT(*) AS total_borrowers FROM borrows WHERE (status = 'Borrowed')"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim totalBorrowers As Integer = dr("total_borrowers").ToString()
                lblTotalBorrowers.Text = Format(totalBorrowers, "N0")
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub TotalBookLost()
        Try
            str = "SELECT COUNT(*) AS total_books_lost FROM borrows WHERE (status = 'Lost')"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim total_books_lost As Integer = dr("total_books_lost").ToString()
                lblTotalLostBook.Text = Format(total_books_lost, "N0")
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub TotalBooks()
        Try
            str = "SELECT SUM(copies) AS total_books FROM books"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim total_books As Integer = dr("total_books").ToString()
                lblTotalBooks.Text = Format(total_books, "N0")
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

End Class
