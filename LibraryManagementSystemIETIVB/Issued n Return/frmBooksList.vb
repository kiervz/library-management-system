Imports System.Data.SqlClient

Public Class frmBooksList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub

    Private Sub frmBooksList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            str = "SELECT books.id, books.isbn, books.title, books.author, book_categories.category, books.series_date, books.call_number, books.status FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE books.status = 'available'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooks.Rows.Clear()

            While dr.Read
                dgvBooks.Rows.Add(dr("id"), dr("call_number"), dr("title"), dr("author"), dr("category"), dr("series_date"), dr("isbn"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvBooks_DoubleClick(sender As Object, e As EventArgs) Handles dgvBooks.DoubleClick
        If dgvBooks.Rows.Count > 0 Then
            Dim i As Integer = dgvBooks.CurrentRow.Index

            book_id = dgvBooks.Item(0, i).Value
            book_isbn = dgvBooks.Item(6, i).Value
            CloseTransparentForm()
            Me.Hide()
        End If
    End Sub

End Class