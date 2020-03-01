Imports System.Data.SqlClient

Public Class frmBooksList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub

    Private Sub frmBooksList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LoadData()
        FillCategories()
        cmbSearchBy.SelectedIndex = 0
        cmbCategories.SelectedIndex = 0
    End Sub

    Private Sub FillCategories()
        Try
            str = "SELECT category FROM book_categories"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            cmbCategories.Items.Clear()
            While dr.Read
                If cmbCategories.Items.Count = 0 Then
                    cmbCategories.Items.Add("All Categories")
                End If
                cmbCategories.Items.Add(dr("category"))
            End While
        Catch ex As Exception
        Finally
            cmd.Dispose()
            dr.Close()
        End Try
    End Sub

    Private Sub LoadData()
        Try
            str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.copies, books.date_published, books.call_number FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooks.Rows.Clear()

            While dr.Read
                dgvBooks.Rows.Add(dr("id"), dr("call_number"), dr("title"), dr("author"), dr("category"), dr("copies"), dr("date_published"), dr("isbn"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub dgvBooks_DoubleClick(sender As Object, e As EventArgs) Handles dgvBooks.DoubleClick
        If dgvBooks.Rows.Count > 0 Then
            Dim i As Integer = dgvBooks.CurrentRow.Index

            If Not dgvBooks.Item(5, i).Value > 0 Then
                Msg(Me, "Book you have selected is out of stock!", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            book_id = dgvBooks.Item(0, i).Value
            book_isbn = dgvBooks.Item(7, i).Value
            CloseTransparentForm()
            Me.Hide()
        End If
    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        If cmbSearchBy.SelectedIndex = 0 Then
            LoadData()
            txtSearch.Clear()
            txtSearch.BringToFront()
        ElseIf cmbSearchBy.SelectedIndex = 5 Then
            cmbCategories.BringToFront()
        Else
            cmbCategories.SendToBack()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If cmbSearchBy.SelectedIndex = 0 Then
                    LoadData()
                    txtSearch.Clear()
                    Exit Sub
                ElseIf cmbSearchBy.SelectedIndex = 1 Then
                    str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.copies, books.date_published, books.call_number FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE books.isbn = '" + txtSearch.Text + "'"
                ElseIf cmbSearchBy.SelectedIndex = 2 Then
                    str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.copies, books.date_published, books.call_number FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE books.title LIKE '%" + txtSearch.Text + "%'"
                ElseIf cmbSearchBy.SelectedIndex = 3 Then
                    str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.copies, books.date_published, books.call_number FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE books.Author LIKE '%" + txtSearch.Text + "%'"
                ElseIf cmbSearchBy.SelectedIndex = 4 Then
                    str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.copies, books.date_published, books.call_number FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE books.Publisher LIKE '%" + txtSearch.Text + "%'"
                End If

                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                dgvBooks.Rows.Clear()

                While dr.Read
                    dgvBooks.Rows.Add(dr("id"), dr("call_number"), dr("title"), dr("author"), dr("category"), dr("copies"), dr("date_published"), dr("isbn"))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dr.Close()
                cmd.Dispose()
            End Try
        End If
    End Sub

    Private Sub cmbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategories.SelectedIndexChanged
        If cmbSearchBy.SelectedIndex = 5 Then
            Try
                If cmbCategories.SelectedIndex = 0 Then
                    str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.copies, books.date_published, books.call_number FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id"
                Else
                    str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.copies, books.date_published, books.call_number FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE book_categories.category = '" + cmbCategories.Text + "'"
                End If
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                dgvBooks.Rows.Clear()

                While dr.Read
                    dgvBooks.Rows.Add(dr("id"), dr("call_number"), dr("title"), dr("author"), dr("category"), dr("copies"), dr("date_published"), dr("isbn"))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dr.Close()
                cmd.Dispose()
            End Try
        End If
    End Sub
End Class