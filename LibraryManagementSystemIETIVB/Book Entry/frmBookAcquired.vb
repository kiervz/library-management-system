Imports System.Data.SqlClient

Public Class frmBookAcquired

    Private Sub frmBookAcquired_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        Try
            str = "SELECT call_number, isbn, title, author, total_copies, copies FROM books"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBooks.Rows.Clear()

            While dr.Read
                dgvBooks.Rows.Add(dr("call_number"), dr("isbn"), dr("title"), dr("author"), dr("total_copies"), dr("copies"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvBooks_DoubleClick(sender As Object, e As EventArgs) Handles dgvBooks.DoubleClick
        Dim i As Integer = dgvBooks.CurrentRow.Index

        txtCallNumber.Text = dgvBooks.Item(0, i).Value
        txtISBN.Text = dgvBooks.Item(1, i).Value
        txtTitle.Text = dgvBooks.Item(2, i).Value
        txtAuthor.Text = dgvBooks.Item(3, i).Value
        txtTotalCopies.Text = dgvBooks.Item(4, i).Value
        txtAvailableCopies.Text = dgvBooks.Item(5, i).Value

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCallNumber.Text.Length > 0 And txtAddCopies.Text.Length > 0 Then
            If txtAddCopies.Text = "0" Then
                CustomMessageBox.ShowDialog(Me, "Please enter greater than zero (0)", "Unable to update", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
            Else
                CustomMessageBox.ShowDialog(Me, "Are you sure you want to Update?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

                If msgBoxButtonClick = DialogResult.Yes Then
                    Try
                        Dim sum_of_totalcopies As Integer = Val(txtTotalCopies.Text) + Val(txtAddCopies.Text)
                        Dim sum_of_copies As Integer = Val(txtAvailableCopies.Text) + Val(txtAddCopies.Text)

                        str = "UPDATE books SET total_copies = @total_copies, copies = @copies WHERE isbn = @isbn"
                        cmd = New SqlCommand(str, conn)
                        cmd.Parameters.AddWithValue("@total_copies", CStr(sum_of_totalcopies))
                        cmd.Parameters.AddWithValue("@copies", CStr(sum_of_copies))
                        cmd.Parameters.AddWithValue("@isbn", txtISBN.Text)
                        cmd.ExecuteNonQuery()

                        CustomMessageBox.ShowDialog(Me, "Book copies is already updated!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)

                        LoadBooks()
                        ClearAll()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub ClearAll()
        txtAddCopies.Clear()
        txtAuthor.Clear()
        txtCallNumber.Clear()
        txtISBN.Clear()
        txtTitle.Clear()
        txtTotalCopies.Clear()
        txtAvailableCopies.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
        LoadBooks()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()
        CloseTransparentForm()
    End Sub
End Class