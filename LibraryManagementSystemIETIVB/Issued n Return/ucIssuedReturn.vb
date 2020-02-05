Imports System.Data.SqlClient

Public Class ucIssuedReturn

    Private _issued_return_id As Integer

    Private Sub lookup_borrower(sender As Object, e As EventArgs) Handles pbBrowsePic.Click, lblLookUpBorrowers.Click
        Dim borrowers As New frmBorrowerList
        OpenTransparentForm(Me)
        borrowers.ShowDialog(Me)

        If Not borrower_id = "" Then
            txtBorrowerID.Text = borrower_id
            SelectBorrower()
            LoadBorrowedBooks()
        End If
    End Sub

    Friend Sub LoadBorrowedBooks()
        Try
            str = "SELECT borrows.id, books.isbn, books.title, books.author, borrows.student_faculty_no, borrows.date_borrowed, borrows.date_due, borrows.day_penalty, borrows.status, users.username FROM users INNER JOIN borrows ON users.user_id = borrows.user_id INNER JOIN books ON borrows.book_id = books.id WHERE student_faculty_no = @student_faculty_no AND borrows.status = '1'"
            cmd = New SqlCommand(str, conn)
            cmd.Parameters.AddWithValue("@student_faculty_no", txtBorrowerID.Text)
            dr = cmd.ExecuteReader

            dgvBorrows.Rows.Clear()

            While dr.Read
                Dim due_date As DateTime = dr("date_due")
                Dim temp_day_penalty As TimeSpan = Date.Now.Subtract(due_date)
                Dim day_penalty As Integer = temp_day_penalty.Days

                'UPDATE the day_penalty of borrows table
                str = "UPDATE borrows SET day_penalty = @day_penalty WHERE id = '" + CStr(dr("id")) + "'"
                cmd = New SqlCommand(str, conn)

                If day_penalty <= 0 Then day_penalty = 0

                cmd.Parameters.AddWithValue("@day_penalty", CStr(day_penalty))
                cmd.ExecuteNonQuery()

                Dim total_penalty As Decimal = Val(day_penalty) * Val(txtPenaltyDay.Text)
                dgvBorrows.Rows.Add(dr("id"), dr("isbn"), dr("title"), dr("author"), CDate(dr("date_borrowed")).ToString("MM/dd/yyyy h:mm tt"), CDate(dr("date_due")).ToString("MM/dd/yyyy h:mm tt"), Format(total_penalty, "N2"), dr("username"))
            End While

            If dgvBorrows.Rows.Count = 0 Then
                panelNoRecord.Visible = True
            Else
                panelNoRecord.Visible = False
            End If

            txtBookAllowed.Text = My.Settings.no_books_allow
            txtDayAllowed.Text = My.Settings.no_days_allow
            txtPenaltyDay.Text = My.Settings.penalty_per_day
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SelectBorrower()
        Try
            str = "SELECT * FROM students WHERE student_id = '" + txtBorrowerID.Text + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                txtName.Text = dr("firstname") + " " + dr("middlename") + " " + dr("lastname")
                txtYearSec.Text = dr("year") + " " + dr("section")
                txtType.Text = "Student"
            Else
                cmd.Dispose()
                dr.Close()

                str = "SELECT * FROM faculties WHERE faculty_id = '" + txtBorrowerID.Text + "'"
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txtName.Text = dr("firstname") + " " + dr("middlename") + " " + dr("lastname")
                    txtYearSec.Text = "NONE"
                    txtType.Text = "Faculty"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ucIssuedReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookAllowed.Text = My.Settings.no_books_allow
        txtDayAllowed.Text = My.Settings.no_days_allow
        txtPenaltyDay.Text = My.Settings.penalty_per_day
        btnBorrow.Enabled = False
    End Sub

    Private Sub txtBorrowerID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBorrowerID.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectBorrower()
            LoadBorrowedBooks()
        End If
    End Sub

    Private Sub lookup_book(sender As Object, e As EventArgs) Handles PictureBox1.Click, Label8.Click
        Dim books As New frmBooksList
        OpenTransparentForm(Me)
        books.ShowDialog(Me)

        If Not book_isbn = "" Then
            txtISBN.Text = book_isbn
            SelectBook()
        End If
    End Sub

    Private Sub SelectBook()
        Try
            str = "SELECT * FROM books WHERE ISBN = '" + txtISBN.Text + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                txtTitle.Text = dr("title")
                txtCallNo.Text = dr("call_number")
                txtAuthor.Text = dr("author")
                txtPublisher.Text = dr("publisher")
            Else
                ClearBookInformation()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If dgvBorrows.Rows.Count = Val(txtBookAllowed.Text) Then
            CustomMessageBox.ShowDialog(Me, "Unable to process. " + txtBookAllowed.Text + " maximum book allowed to borrow.", "Library System", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
            Exit Sub
        End If
        CustomMessageBox.ShowDialog(Me, "Are you sure you want to Submit?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

        If msgBoxButtonClick = DialogResult.Yes Then
            Try
                str = "INSERT INTO borrows (id,user_id,book_id,student_faculty_no,date_borrowed,date_due,day_penalty,status) VALUES ((SELECT ISNULL(MAX(id) + 1, 0) FROM borrows),@user_id,@book_id,@student_faculty_no,@date_borrowed,@date_due,@day_penalty,@status)"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@user_id", userID)
                cmd.Parameters.AddWithValue("@book_id", book_id)
                cmd.Parameters.AddWithValue("@student_faculty_no", txtBorrowerID.Text)
                cmd.Parameters.AddWithValue("@date_borrowed", Date.Now.ToString("MM-dd-yyyy HH:mm:ss"))
                cmd.Parameters.AddWithValue("@date_due", Date.Now.AddDays(txtDayAllowed.Text).ToString("MM-dd-yyyy HH:mm:ss"))
                cmd.Parameters.AddWithValue("@day_penalty", "0")
                cmd.Parameters.AddWithValue("@status", "1")
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                str = "UPDATE books SET copies = (copies - 1) WHERE id = @id"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@id", book_id)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                LoadBorrowedBooks()
                CustomMessageBox.ShowDialog(Me, "Book succesfully borrowed!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                ClearBookInformation()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ClearBookInformation()
        txtISBN.Clear()
        txtTitle.Clear()
        txtPublisher.Clear()
        txtCallNo.Clear()
        txtAuthor.Clear()
        txtISBN.Focus()
    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged, txtName.TextChanged
        If txtName.Text.Length > 0 And txtTitle.Text.Length > 0 Then
            btnBorrow.Enabled = True
        Else
            btnBorrow.Enabled = False
        End If
    End Sub

    Private Sub dgvBorrows_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrows.CellContentClick
        Dim i As Integer = dgvBorrows.CurrentRow.Index

        If e.ColumnIndex = 8 Then
            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Return?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

            If msgBoxButtonClick = DialogResult.Yes Then
                Try
                    str = "UPDATE borrows SET status = '0', date_return = '" + Date.Now.ToString("MM-dd-yyyy HH:mm:ss") + "' WHERE id = '" + CStr(dgvBorrows.Item(0, i).Value) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    str = "UPDATE books SET copies = (copies + 1) WHERE isbn = '" + CStr(dgvBorrows.Item(1, i).Value) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    CustomMessageBox.ShowDialog(Me, "Book Successfully Returned", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                    LoadBorrowedBooks()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txtISBN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtISBN.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectBook()
        End If
    End Sub

End Class
