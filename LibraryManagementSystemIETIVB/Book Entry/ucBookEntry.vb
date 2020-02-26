Imports System.Data.SqlClient

Public Class ucBookEntry

    Dim rowCounnt As Integer

    Private Sub ucBookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        cmbSearchBy.SelectedIndex = 0
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnRegisterBook.Click
        OpenTransparentForm(Me)
        Dim register_book As New frmRegisterUpdateBooks
        register_book._form_title = "REGISTER BOOK"
        register_book.ShowDialog(Me)

        If is_reload = True Then
            FillGridView()
            is_reload = False
        End If
    End Sub

    Friend Sub FillGridView()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            str = "SELECT COUNT(*) AS totalrow FROM books"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                rowCounnt = dr("totalrow")
                lblShowingNentries.Text = "Total Books Registered: " + CStr(rowCounnt)
            End If
            dr.Close()
            cmd.Dispose()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            str = "SELECT books.id, books.call_number, books.isbn, books.title, books.author, books.publisher, book_categories.category, books.date_published, books.copies FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooks.Rows.Clear()

            While dr.Read
                dgvBooks.Rows.Add(dr("id"), dr("call_number"), dr("isbn"), dr("title"), dr("author"), dr("publisher"), dr("category"), dr("date_published"), dr("copies"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "BOOK 1")
        End Try
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick
        Dim i As Integer = dgvBooks.CurrentRow.Index

        If Not dgvBooks.Rows.Count = 0 Then

            If e.ColumnIndex = 9 Then
                Dim borrow_history As New frmBorrrowHistory
                borrow_history.book_id = dgvBooks.Item(0, i).Value
                OpenTransparentForm(Me)
                borrow_history.ShowDialog(Me)

            ElseIf e.ColumnIndex = 10 Then
                OpenTransparentForm(Me)
                Dim update_book As New frmRegisterUpdateBooks
                update_book._form_title = "UPDATE BOOK"
                update_book._selected_book_id = dgvBooks.Item(0, i).Value
                update_book.ShowDialog(Me)

                If is_reload = True Then
                    FillGridView()
                    is_reload = False
                End If
            End If
        End If
    End Sub

    Private Sub btnBookAcquired_Click(sender As Object, e As EventArgs) Handles btnBookAcquired.Click
        OpenTransparentForm(Me)
        Dim book_acquired As New frmBookAcquired
        book_acquired.ShowDialog(Me)

        If is_reload = True Then
            FillGridView()
            is_reload = False
        End If
    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        If cmbSearchBy.SelectedIndex = 5 Then
            cmbCategories.BringToFront()
            FillCategories()
        Else
            txtSearch.BringToFront()
        End If
    End Sub

    Private Sub FillCategories()
        Try
            str = "SELECT category FROM book_categories"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            cmbCategories.Items.Clear()
            While dr.Read
                cmbCategories.Items.Add(dr("category"))
            End While
            cmbCategories.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class