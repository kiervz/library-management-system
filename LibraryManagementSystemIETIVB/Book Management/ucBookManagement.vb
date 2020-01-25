Imports System.Data.SqlClient

Public Class ucBookManagement

    Dim pagingAdapter As SqlDataAdapter
    Dim pagingDS As DataSet
    Dim scrollVal As Integer
    Dim rowCounnt As Integer
    Dim totalPages As Integer
    Dim currentPage As Integer = 1

    Private Sub ucBookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        FillGridView()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        OpenTransparentForm(Me)
        Dim register_book As New frmRegisterUpdateBooks
        register_book.form_title = "REGISTER BOOK"
        register_book.ShowDialog(Me)
        FillGridView()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rowCounnt > 0 Then
            scrollVal = scrollVal + 50
            If scrollVal >= rowCounnt Then
                scrollVal = rowCounnt - 50
            End If
            If currentPage < totalPages Then
                currentPage += 1
                txtCurrentPage.Text = "Page " + CStr(currentPage)
            End If

            If Not totalPages = 1 Then
                pagingDS.Clear()
                pagingAdapter.Fill(pagingDS, scrollVal, 50, "books_table")
            End If

            If currentPage = totalPages Then
                btnNext.Enabled = False
                Exit Sub
            Else
                btnNext.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If rowCounnt > 0 Then
            scrollVal = scrollVal - 50
            If scrollVal <= 0 Then
                scrollVal = 0
            End If

            If currentPage > 1 Then
                currentPage -= 1
                txtCurrentPage.Text = "Page " + CStr(currentPage)
            End If

            If Not totalPages = 1 Then
                pagingDS.Clear()
                pagingAdapter.Fill(pagingDS, scrollVal, 50, "books_table")
            End If

            If currentPage = totalPages Then
                btnNext.Enabled = False
                Exit Sub
            Else
                btnNext.Enabled = True
            End If
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
                totalPages = Math.Ceiling(rowCounnt / 50)
                lblPages.Text = "Total Pages " + CStr(totalPages)
                lblShowingNentries.Text = "Showing 1 to " + CStr(50) + " of " + CStr(rowCounnt) + " entries"
            End If
            dr.Close()
            cmd.Dispose()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            str = "SELECT books.id, books.isbn, books.title, books.author, books.publisher, book_categories.category, books.series_date, books.rack_no FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id"
            pagingAdapter = New SqlDataAdapter(str, conn)
            pagingDS = New DataSet()
            pagingAdapter.Fill(pagingDS, scrollVal, 50, "books_table")

            dgvBooks.DataSource = pagingDS
            dgvBooks.DataMember = "books_table"
            dgvBooks.Columns(0).Width = 80
            dgvBooks.Columns(1).Width = 125
            dgvBooks.Columns(2).Width = 300
            dgvBooks.Columns(3).Width = 150
            dgvBooks.Columns(4).Width = 130
            dgvBooks.Columns(5).Width = 125
            dgvBooks.Columns(6).Width = 80
            dgvBooks.Columns(0).HeaderText = "ID"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "BOOK")
        End Try
    End Sub

End Class
