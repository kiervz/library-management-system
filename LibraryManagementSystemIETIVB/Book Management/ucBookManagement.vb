Imports System.Data.SqlClient

Public Class ucBookManagement

    Dim rowCounnt As Integer

    Private Sub ucBookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        OpenTransparentForm(Me)
        Dim register_book As New frmRegisterUpdateBooks
        register_book._form_title = "REGISTER BOOK"
        register_book.ShowDialog(Me)

        If is_book_updated = True Then
            FillGridView()
            is_book_updated = False
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

                If is_book_updated = True Then
                    FillGridView()
                    is_book_updated = False
                End If
            End If
        End If
    End Sub
End Class