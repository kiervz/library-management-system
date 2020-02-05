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
            str = "SELECT borrows.id, books.isbn, books.title, books.author, borrows.student_faculty_no, borrows.date_borrowed, borrows.date_due, borrows.day_penalty, users.username FROM users INNER JOIN borrows ON users.user_id = borrows.user_id INNER JOIN books ON borrows.book_id = books.id WHERE student_faculty_no = @student_faculty_no"
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
                If day_penalty <= 0 Then
                    cmd.Parameters.AddWithValue("@day_penalty", CStr(0))
                    day_penalty = 0
                Else
                    cmd.Parameters.AddWithValue("@day_penalty", CStr(day_penalty))
                End If

                cmd.ExecuteNonQuery()

                Dim total_penalty As Decimal = Val(day_penalty) * Val(txtPenaltyDay.Text)
                dgvBorrows.Rows.Add(dr("id"), dr("isbn"), dr("title"), dr("author"), CDate(dr("date_borrowed")).ToString("MM/dd/yyyy h:mm tt"), CDate(dr("date_due")).ToString("MM/dd/yyyy h:mm tt"), Format(total_penalty, "N2"), dr("username"))
            End While

            If dgvBorrows.Rows.Count = 0 Then
                panelNoRecord.Visible = True
            Else
                panelNoRecord.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SelectBorrower()
        Try
            str = "SELECT * FROM students WHERE student_id = '" + borrower_id.ToString() + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                txtName.Text = dr("firstname") + " " + dr("middlename") + " " + dr("lastname")
                txtYearSec.Text = dr("year") + " " + dr("section")
                cmbType.Text = "Student"
            Else
                cmd.Dispose()
                dr.Close()

                str = "SELECT * FROM faculties WHERE faculty_id = '" + borrower_id.ToString() + "'"
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txtName.Text = dr("firstname") + " " + dr("middlename") + " " + dr("lastname")
                    txtYearSec.Text = "NONE"
                    cmbType.Text = "Faculty"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ucIssuedReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IssuedReturnID()
        txtBookAllowed.Text = My.Settings.no_books_allow
        txtDayAllowed.Text = My.Settings.no_days_allow
        txtPenaltyDay.Text = My.Settings.penalty_per_day
    End Sub

    Private Sub txtBorrowerID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBorrowerID.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectBorrower()
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        CustomMessageBox.ShowDialog(Me, "Are you sure you want to Submit?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

        If msgBoxButtonClick = DialogResult.Yes Then
            Try
                str = "INSERT INTO borrows (id,user_id,book_id,student_faculty_no,date_borrowed,date_due,day_penalty,status) VALUES (@id,@user_id,@book_id,@student_faculty_no,@date_borrowed,@date_due,@day_penalty,@status)"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@id", _issued_return_id)
                cmd.Parameters.AddWithValue("@user_id", userID)
                cmd.Parameters.AddWithValue("@book_id", book_id)
                cmd.Parameters.AddWithValue("@student_faculty_no", txtBorrowerID.Text)
                cmd.Parameters.AddWithValue("@date_borrowed", Date.Now.ToString("MM-dd-yyyy HH:mm:ss"))
                cmd.Parameters.AddWithValue("@date_due", Date.Now.AddDays(txtDayAllowed.Text).ToString("MM-dd-yyyy HH:mm:ss"))
                cmd.Parameters.AddWithValue("@day_penalty", "0")
                cmd.Parameters.AddWithValue("@status", "1")
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                str = "UPDATE books SET status = 'borrowed' WHERE id = @id"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@id", book_id)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                LoadBorrowedBooks()
                CustomMessageBox.ShowDialog(Me, "Book succesfully borrowed!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub IssuedReturnID()
        Try
            str = "SELECT MAX(id) FROM borrows"
            cmd = New SqlCommand(str, conn)

            If IsDBNull(cmd.ExecuteScalar()) Then
                _issued_return_id += 1
            Else
                _issued_return_id = CStr(cmd.ExecuteScalar())
                _issued_return_id += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
