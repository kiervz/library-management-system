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
            str = "SELECT borrows.id, books.isbn, books.title, books.author, borrows.student_faculty_no, borrows.date_borrowed, borrows.date_due, borrows.day_penalty, borrows.status, users.username FROM users INNER JOIN borrows ON users.user_id = borrows.user_id INNER JOIN books ON borrows.book_id = books.id WHERE student_faculty_no = @student_faculty_no AND borrows.status_id = '1'"
            cmd = New SqlCommand(str, conn)
            cmd.Parameters.AddWithValue("@student_faculty_no", txtBorrowerID.Text)
            dr = cmd.ExecuteReader

            dgvBorrows.Rows.Clear()

            While dr.Read
                Dim due_date As DateTime = dr("date_due")
                Dim date_now As DateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm tt")
                Dim temp_day_penalty As TimeSpan = date_now.Subtract(due_date)
                Dim day_penalty As Integer = temp_day_penalty.Days
                Dim hour_penalty As Integer = temp_day_penalty.Hours
                Dim borrow_id As String = dr("id")


                'UPDATE the day_penalty of borrows table
                str = "UPDATE borrows SET day_penalty = @day_penalty WHERE id = '" + CStr(borrow_id) + "'"
                cmd = New SqlCommand(str, conn)

                If day_penalty < 0 Then day_penalty = 0
                If day_penalty = 0 And (hour_penalty < 24 And hour_penalty > 0) Then day_penalty = 1

                cmd.Parameters.AddWithValue("@day_penalty", CStr(day_penalty))
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                Dim total_penalty As Decimal = Val(day_penalty) * Val(txtPenaltyDay.Text)
                str = "UPDATE borrows SET payment=@payment WHERE id = '" + CStr(borrow_id) + "'"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@payment", total_penalty)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                dgvBorrows.Rows.Add(dr("id"), dr("isbn"), dr("title"), dr("author"), CDate(dr("date_borrowed")).ToString("MM/dd/yyyy h:mm tt"), CDate(dr("date_due")).ToString("MM/dd/yyyy h:mm tt"), total_penalty, dr("username"))
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
                txtYearSec.Text = dr("major")
                txtType.Text = "Student"
                If txtPenalty.Text = "" Then txtPenalty.Text = "0"
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
                    If txtPenalty.Text = "" Then txtPenalty.Text = "0"
                Else
                    ClearBorrowerInformation()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            dr.Close()
        End Try
    End Sub

    Private Sub ucIssuedReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
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
                book_id = dr("id")
                txtTitle.Text = dr("title")
                txtCallNo.Text = dr("call_number")
                txtAuthor.Text = dr("author")
                txtPublisher.Text = dr("publisher")
            Else
                ClearBookInformation()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If dgvBorrows.Rows.Count = Val(txtBookAllowed.Text) Then
            Msg(Me, "Unable to process. " + txtBookAllowed.Text + " maximum book allowed to borrow.", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim count_penalty As Integer = 0
        For i = 0 To dgvBorrows.Rows.Count - 1
            If Val(dgvBorrows.Item(6, i).Value) > 0 Then
                count_penalty += 1
            End If
        Next

        If count_penalty > 0 Then
            Msg(Me, "Unable to process. You have " + CStr(count_penalty) + " penalty. Please return the book(s) first.", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

        If mes = DialogResult.Yes Then
            Try
                str = "INSERT INTO borrows (id,user_id,book_id,student_faculty_no,date_borrowed,date_due,day_penalty,status_id,status) VALUES ((SELECT ISNULL(MAX(id) + 1, 0) FROM borrows),@user_id,@book_id,@student_faculty_no,@date_borrowed,@date_due,@day_penalty,@status_id,@status)"
                cmd = New SqlCommand(str, conn)
                With cmd.Parameters
                    .AddWithValue("@user_id", userID)
                    .AddWithValue("@book_id", book_id)
                    .AddWithValue("@student_faculty_no", txtBorrowerID.Text)
                    .AddWithValue("@date_borrowed", Date.Now.ToString("MM-dd-yyyy HH:mm:ss"))
                    .AddWithValue("@date_due", Date.Now.AddDays(txtDayAllowed.Text).ToString("MM-dd-yyyy HH:mm:ss"))
                    .AddWithValue("@day_penalty", "0")
                    .AddWithValue("@status_id", "1")
                    .AddWithValue("@status", "Borrowed")
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                str = "UPDATE books SET copies = (copies - 1) WHERE id = @id"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@id", book_id)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                LoadBorrowedBooks()
                Msg(Me, "Book succesfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearBookInformation()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dr.Close()
                cmd.Dispose()
            End Try
        End If
    End Sub

    Private Sub ClearBorrowerInformation()
        txtName.Clear()
        txtType.Clear()
        txtYearSec.Clear()
        txtPenalty.Clear()
        txtBorrowerID.Clear()
        txtBorrowerID.Focus()
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
            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Return?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

            If mes = DialogResult.Yes Then

                If Val(dgvBorrows.Item(6, i).Value) > 0 Then
                    Dim penalty_slip As New frmPenaltySlip
                    penalty_slip.borrow_id = dgvBorrows.Item(0, i).Value
                    penalty_slip.ShowDialog(Me)
                Else
                    Try
                        str = "UPDATE borrows SET status_id = '0', status = 'Returned', date_return = '" + Date.Now.ToString("MM-dd-yyyy HH:mm:ss") + "' WHERE id = '" + CStr(dgvBorrows.Item(0, i).Value) + "'"
                        cmd = New SqlCommand(str, conn)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        str = "UPDATE books SET copies = (copies + 1) WHERE isbn = '" + CStr(dgvBorrows.Item(1, i).Value) + "'"
                        cmd = New SqlCommand(str, conn)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        Msg(Me, "Book Successfully Returned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadBorrowedBooks()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        dr.Close()
                        cmd.Dispose()
                    End Try
                End If

            End If
        End If
    End Sub

    Private Sub txtISBN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtISBN.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectBook()
        End If
    End Sub

    Private Sub dgvBorrows_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBorrows.CellFormatting
        txtPenalty.Text = 0
        For i As Integer = 0 To dgvBorrows.Rows.Count - 1
            If dgvBorrows.Item(6, i).Value > 0 Then
                dgvBorrows.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60)
                dgvBorrows.Rows(i).DefaultCellStyle.ForeColor = Color.WhiteSmoke
                dgvBorrows.Rows(i).DefaultCellStyle.SelectionBackColor = Color.FromArgb(189, 53, 37)
                dgvBorrows.Rows(i).DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
            End If
            txtPenalty.Text += Val(dgvBorrows.Item(6, i).Value)
        Next
    End Sub

    Private Sub dgvBorrows_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBorrows.CellMouseClick
        Dim i As Integer = dgvBorrows.CurrentRow.Index
        If dgvBorrows.Item(6, i).Value > 0 Then
            If e.Button = MouseButtons.Right Then
                MaterialContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub ConfirmReturnToolStripMenuItem1_MouseDown(sender As Object, e As MouseEventArgs) Handles ConfirmReturnToolStripMenuItem1.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim i As Integer = dgvBorrows.CurrentRow.Index
            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Return?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

            If mes = DialogResult.Yes Then
                Try
                    str = "UPDATE borrows SET status_id = '0', status = 'Returned', date_return = '" + Date.Now.ToString("MM-dd-yyyy HH:mm:ss") + "' WHERE id = '" + CStr(dgvBorrows.Item(0, i).Value) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    str = "UPDATE books SET copies = (copies + 1) WHERE isbn = '" + CStr(dgvBorrows.Item(1, i).Value) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Msg(Me, "Book Successfully Returned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadBorrowedBooks()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    dr.Close()
                    cmd.Dispose()
                End Try
            End If

            MaterialContextMenuStrip1.Hide()
        End If
    End Sub
End Class
