Imports System.Data.SqlClient

Public Class ucRecords

    Dim thread As System.Threading.Thread

    Private Sub ucRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        Timer1.Start()
    End Sub

    Friend Sub LoadBookOverdue()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.id, books.call_number, books.title, books.author, borrows.student_faculty_no, borrows.date_borrowed, borrows.date_due, users.username, borrows.day_penalty, borrows.status_id, (SELECT firstname + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS StudentName, (SELECT firstname + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS FacultyName,  (SELECT phone FROM students AS students_1 WHERE (student_id = borrows.student_faculty_no)) AS student_phone, (SELECT phone FROM faculties AS faculties_1 WHERE (faculty_id = borrows.student_faculty_no)) AS faculty_phone FROM borrows INNER JOIN books ON borrows.book_id = books.id INNER JOIN users ON borrows.user_id = users.user_id WHERE (borrows.day_penalty > 0) AND (borrows.status_id = 1)"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksOverdue.Rows.Clear()

            While dr.Read
                row_count += 1
                If IsDBNull(dr("FacultyName")) Then
                    dgvBooksOverdue.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("StudentName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"), dr("id"), dr("student_phone"), dr("student_faculty_no"))
                Else
                    dgvBooksOverdue.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("FacultyName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"), dr("id"), dr("faculty_phone"), dr("student_faculty_no"))
                End If
            End While
            If dgvBooksOverdue.RowCount = 0 Then
                panelBookOverdue.BringToFront()
                btnMarkLost.Enabled = False
                btnSendSMS.Enabled = False
            Else
                panelBookOverdue.SendToBack()
                btnMarkLost.Enabled = True
                btnSendSMS.Enabled = True
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub LoadBookLost()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.id, borrows.id AS borrow_id,  books.call_number, books.title, books.author, borrows.student_faculty_no, borrows.date_borrowed, borrows.date_due, users.username, borrows.day_penalty, borrows.status_id, (SELECT firstname + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS StudentName, (SELECT firstname + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS FacultyName FROM borrows INNER JOIN books ON borrows.book_id = books.id INNER JOIN users ON borrows.user_id = users.user_id WHERE (borrows.day_penalty > 0) AND (borrows.status_id = 3)"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBookLost.Rows.Clear()

            While dr.Read
                row_count += 1
                If IsDBNull(dr("FacultyName")) Then
                    dgvBookLost.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("StudentName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"), dr("borrow_id"))
                Else
                    dgvBookLost.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("FacultyName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"), dr("borrow_id"))
                End If
            End While
            If dgvBookLost.RowCount = 0 Then
                panelBookLost.BringToFront()
                btnReturn.Enabled = False
            Else
                panelBookLost.SendToBack()
                btnReturn.Enabled = True
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub LoadBookBorrowed()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.id, borrows.id as borrow_id, books.call_number, books.title, books.author, borrows.status_id, users.username, borrows.student_faculty_no, (SELECT firstname + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS StudentName, (SELECT firstname + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS FacultyName, borrows.date_borrowed, borrows.date_due FROM books INNER JOIN borrows ON books.id = borrows.book_id INNER JOIN users ON borrows.user_id = users.user_id WHERE (borrows.status_id = '1')"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksBorrowed.Rows.Clear()

            While dr.Read
                row_count += 1
                If IsDBNull(dr("FacultyName")) Then
                    dgvBooksBorrowed.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("StudentName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"), dr("student_faculty_no"), dr("borrow_id"), CDate(dr("date_due")).ToString("MM/dd/yyyy HH:mm tt"))
                Else
                    dgvBooksBorrowed.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("FacultyName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_due")).ToShortDateString(), dr("username"), dr("student_faculty_no"), dr("borrow_id"), CDate(dr("date_due")).ToString("MM/dd/yyyy HH:mm tt"))
                End If
            End While

            If dgvBooksBorrowed.RowCount = 0 Then
                panelBookBorrowed.BringToFront()
            Else
                panelBookBorrowed.SendToBack()
            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub LoadBookReturned()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.call_number, books.title, books.author, borrows.status_id, users.username, borrows.student_faculty_no, (SELECT firstname + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS StudentName, (SELECT firstname + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS FacultyName, borrows.date_borrowed, borrows.date_return FROM books INNER JOIN borrows ON books.id = borrows.book_id INNER JOIN users ON borrows.user_id = users.user_id WHERE (borrows.status_id = '0')"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksReturned.Rows.Clear()

            While dr.Read
                row_count += 1
                If IsDBNull(dr("FacultyName")) Then
                    dgvBooksReturned.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("StudentName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_return")).ToShortDateString(), dr("username"))
                Else
                    dgvBooksReturned.Rows.Add(row_count, dr("call_number"), dr("title"), dr("author"), dr("FacultyName"), CDate(dr("date_borrowed")).ToShortDateString(), CDate(dr("date_return")).ToShortDateString(), dr("username"))
                End If
            End While

            If dgvBooksReturned.Rows.Count = 0 Then
                panelBookReturned.BringToFront()
            Else
                panelBookReturned.SendToBack()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub LoadBookInventory()
        Try
            Dim row_count As Integer = 0
            str = "SELECT books.call_number, books.title, books.author, books.publisher, books.isbn, books.date_published, book_categories.category, books.total_copies, books.copies AS available_copies, books.id, (SELECT COUNT(id) AS Expr1 FROM borrows WHERE (books.id = book_id) AND (status_id = 1)) AS total_borrowers, (SELECT COUNT(id) AS Expr1 FROM borrows AS borrows_1 WHERE (books.id = book_id) AND (status_id = 3)) AS total_lost FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooksInventory.Rows.Clear()

            While dr.Read
                row_count += 1
                dgvBooksInventory.Rows.Add(row_count, dr("call_number"), dr("isbn"), dr("title"), dr("author"), dr("category"), dr("date_published"), dr("publisher"), dr("total_copies"), dr("total_borrowers"), dr("total_lost"), dr("available_copies"))
            End While

            If dgvBooksInventory.RowCount = 0 Then
                panelBookInventory.BringToFront()
            Else
                panelBookInventory.SendToBack()
            End If
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

    Private Sub btnMarkLost_Click(sender As Object, e As EventArgs) Handles btnMarkLost.Click
        If dgvBooksOverdue.Rows.Count > 0 Then
            Dim i As Integer = dgvBooksOverdue.CurrentRow.Index
            Dim borrow_id As Integer = dgvBooksOverdue.Item(8, i).Value
            Dim book_title As String = dgvBooksOverdue.Item(2, i).Value
            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Mark as Lost  " + CStr(book_title) + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

            If mes = DialogResult.Yes Then
                Try
                    str = "UPDATE borrows SET status_id = '3', status = 'Lost' WHERE id = '" + CStr(borrow_id) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Msg(Me, "The book " + CStr(book_title) + " successfully mark as lost!", "Mark as lost", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadBookLost()
                    LoadBookOverdue()

                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If dgvBookLost.Rows.Count > 0 Then
            Dim i As Integer = dgvBookLost.CurrentRow.Index
            Dim borrow_id As Integer = dgvBookLost.Item(8, i).Value
            Dim book_title As String = dgvBookLost.Item(2, i).Value
            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Return " + CStr(book_title) + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

            If mes = DialogResult.Yes Then
                Try
                    str = "UPDATE borrows SET status_id = '1', status = 'Borrowed' WHERE id = '" + CStr(borrow_id) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Msg(Me, "The book " + CStr(book_title) + " successfully returned!", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadBookLost()
                    LoadBookOverdue()
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click
        If dgvBooksOverdue.Rows.Count > 0 Then
            Dim i As Integer = dgvBooksOverdue.CurrentRow.Index

            frmSendSMS.book_name = dgvBooksOverdue.Item(2, i).Value
            frmSendSMS.date_borrowed = CDate(dgvBooksOverdue.Item(5, i).Value).ToShortDateString()
            frmSendSMS.due_date = CDate(dgvBooksOverdue.Item(6, i).Value).ToShortDateString()
            frmSendSMS.borrower_phone = dgvBooksOverdue.Item(9, i).Value
            frmSendSMS.txtBorrowersName.Text = dgvBooksOverdue.Item(4, i).Value
            frmSendSMS.ShowDialog(Me)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i = 0 To dgvBooksBorrowed.Rows.Count - 1
            If CDate(dgvBooksBorrowed.Item(6, i).Value) <= Date.Now Then

                Dim due_date As DateTime = CDate(dgvBooksBorrowed.Item(10, i).Value).ToString("MM/dd/yyyy HH:mm tt")
                Dim date_now As DateTime = Now.ToString("MM/dd/yyyy HH:mm tt")
                Dim temp_day_penalty As TimeSpan = date_now.Subtract(due_date)
                Dim day_penalty As Integer = temp_day_penalty.Days
                Dim hour_penalty As Integer = temp_day_penalty.Hours
                Dim borrow_id As String = dgvBooksBorrowed.Item(9, i).Value

                'UPDATE the day_penalty of borrows table
                str = "UPDATE borrows SET day_penalty = @day_penalty WHERE id = '" + CStr(borrow_id) + "'"
                cmd = New SqlCommand(str, conn)

                If day_penalty < 0 Then day_penalty = 0
                If day_penalty = 0 And (hour_penalty < 24 And hour_penalty > 0) Then day_penalty = 1

                cmd.Parameters.AddWithValue("@day_penalty", CStr(day_penalty))
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                Dim total_penalty As Decimal = Val(day_penalty) * Val(My.Settings.penalty_per_day)
                str = "UPDATE borrows SET payment=@payment WHERE id = '" + CStr(borrow_id) + "'"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@payment", total_penalty)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            End If
        Next
    End Sub

    Private Sub btnGotoReturn_Click(sender As Object, e As EventArgs) Handles btnGotoReturn.Click
        Dim i As Integer = dgvBooksOverdue.CurrentRow.Index
        frmMain.btnIssuedReturn.PerformClick()
        frmMain.UcIssuedReturn1.txtBorrowerID.Clear()
        frmMain.UcIssuedReturn1.txtBorrowerID.Text = dgvBooksOverdue.Item(10, i).Value
        frmMain.UcIssuedReturn1.txtBorrowerID.Focus()
        frmMain.UcIssuedReturn1.Perform_Keydown()
    End Sub
End Class
