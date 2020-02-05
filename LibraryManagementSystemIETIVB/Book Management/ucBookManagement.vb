Imports System.Data.SqlClient

Public Class ucBookManagement

    Dim rowCounnt As Integer

    Private Sub ucBookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        OpenTransparentForm(Me)
        Dim register_book As New frmRegisterUpdateBooks
        register_book.form_title = "REGISTER BOOK"
        register_book.ShowDialog(Me)
        FillGridView()
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
            str = "SELECT books.id, books.isbn, books.title, books.author, books.publisher, book_categories.category, books.date_published, books.copies FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooks.Rows.Clear()

            While dr.Read
                dgvBooks.Rows.Add(dr("id"), dr("isbn"), dr("title"), dr("author"), dr("publisher"), dr("category"), dr("date_published"), dr("copies"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "BOOK 1")
        End Try
    End Sub

End Class