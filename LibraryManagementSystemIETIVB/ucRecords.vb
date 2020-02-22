Imports System.Data.SqlClient

Public Class ucRecords
    Private Sub ucRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LoadBookOverdue()
        LoadBookUnreturned()
        LoadBookReturned()
        LoadBookInventory()
    End Sub

    Friend Sub LoadBookOverdue()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.call_number, books.title, books.author, borrows.student_faculty_no, borrows.date_borrowed, borrows.date_due, users.username, borrows.day_penalty, borrows.status_id, (SELECT firstname + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS StudentName, (SELECT firstname + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS FacultyName FROM borrows INNER JOIN books ON borrows.book_id = books.id INNER JOIN users ON borrows.user_id = users.user_id WHERE (borrows.day_penalty > 0) AND (borrows.status_id = 1)"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksOverdue.Rows.Clear()

            While dr.Read
                row_count += 1
                If IsDBNull(dr("FacultyName")) Then
                    dgvBooksOverdue.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("StudentName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"))
                Else
                    dgvBooksOverdue.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("FacultyName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"))
                End If
            End While
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub LoadBookUnreturned()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.call_number, books.title, books.author, borrows.status_id, users.username, borrows.student_faculty_no, (SELECT firstname + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS StudentName, (SELECT firstname + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS FacultyName, borrows.date_borrowed FROM books INNER JOIN borrows ON books.id = borrows.book_id INNER JOIN users ON borrows.user_id = users.user_id WHERE (borrows.status_id = '1')"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksUnreturned.Rows.Clear()

            While dr.Read
                row_count += 1
                If IsDBNull(dr("FacultyName")) Then
                    dgvBooksUnreturned.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("StudentName"), CDate(dr("date_borrowed")).ToShortDateString(), dr("username"))
                Else
                    dgvBooksUnreturned.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("FacultyName"), CDate(dr("date_borrowed")).ToShortDateString(), dr("username"))
                End If
            End While
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub LoadBookReturned()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.call_number, books.title, books.author, borrows.status_id, users.username, borrows.student_faculty_no, (SELECT firstname + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS StudentName, (SELECT firstname + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS FacultyName, borrows.date_borrowed FROM books INNER JOIN borrows ON books.id = borrows.book_id INNER JOIN users ON borrows.user_id = users.user_id WHERE (borrows.status_id = '0')"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksReturned.Rows.Clear()

            While dr.Read
                row_count += 1
                If IsDBNull(dr("FacultyName")) Then
                    dgvBooksReturned.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("StudentName"), CDate(dr("date_borrowed")).ToShortDateString(), dr("username"))
                Else
                    dgvBooksReturned.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("FacultyName"), CDate(dr("date_borrowed")).ToShortDateString(), dr("username"))
                End If
            End While
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub LoadBookInventory()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.call_number, books.title, books.author, books.publisher, books.isbn, books.date_published, book_categories.category, books.total_copies, books.copies AS available_copies, books.id, (SELECT COUNT(id) AS Expr1 FROM borrows WHERE (books.id = book_id) AND (status_id = 1)) AS total_borrowers, (SELECT COUNT(id) AS Expr1 FROM borrows AS borrows_1 WHERE (books.id = book_id) AND (status_id = 2)) AS total_lost FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksInventory.Rows.Clear()

            While dr.Read
                row_count += 1
                dgvBooksInventory.Rows.Add(row_count, dr("call_number"), dr("isbn"), dr("title"), dr("author"), dr("category"), dr("date_published"), dr("publisher"), dr("total_copies"), dr("total_borrowers"), dr("total_lost"), dr("available_copies"))
            End While
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub dgvBooksInventory_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBooksInventory.CellFormatting
        For i = 0 To dgvBooksInventory.Rows.Count - 1
            dgvBooksInventory.Rows(i).Cells(9).Style.ForeColor = Color.Blue
            dgvBooksInventory.Rows(i).Cells(9).Style.SelectionForeColor = Color.Blue

            dgvBooksInventory.Rows(i).Cells(10).Style.ForeColor = Color.Red
            dgvBooksInventory.Rows(i).Cells(10).Style.SelectionForeColor = Color.Red

            dgvBooksInventory.Rows(i).Cells(11).Style.ForeColor = Color.Green
            dgvBooksInventory.Rows(i).Cells(11).Style.SelectionForeColor = Color.Green
        Next
    End Sub
End Class
