Imports System.Data.SqlClient

Public Class frmRegisterUpdateBooks

    Private _imagePath As String = "none"
    Private _book_id As Integer
    Private _category_id As Integer
    Friend _form_title As String
    Friend _selected_book_id As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtAuthor.Text.Length > 0 And txtCallNumber.Text.Length > 0 And txtDescription.Text.Length > 0 And txtISBN.Text.Length > 0 And txtPrice.Text.Length > 0 And txtPublisher.Text.Length > 0 And txtDatePublished.Text.Length > 0 And txtTitle.Text.Length > 0 And cmbCategories.SelectedIndex > -1 Then

                str = "SELECT isbn FROM books WHERE isbn = '" + txtISBN.Text + "'"
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    Msg(Me, "Book Already Exist", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

                If mes = DialogResult.Yes Then
                    str = "INSERT INTO books (id,isbn,call_number,title,author,publisher,description,category_id,date_published,series,image,price,copies,total_copies) VALUES ((SELECT ISNULL(MAX(id) + 1, 0) FROM books),@isbn,@call_number,@title,@author,@publisher,@description,@category_id,@date_published,@series,@image,@price,@copies,@total_copies)"
                    cmd = New SqlCommand(str, conn)
                    cmd.Parameters.AddWithValue("@isbn", txtISBN.Text)
                    cmd.Parameters.AddWithValue("@call_number", txtCallNumber.Text)
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
                    cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@category_id", _category_id)
                    cmd.Parameters.AddWithValue("@date_published", txtDatePublished.Text)
                    cmd.Parameters.AddWithValue("@series", txtSeries.Text)
                    cmd.Parameters.AddWithValue("@image", _imagePath)
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text)
                    cmd.Parameters.AddWithValue("@copies", "0")
                    cmd.Parameters.AddWithValue("@total_copies", "0")
                    cmd.ExecuteNonQuery()
                    Msg(Me, "Book Successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    is_reload = True
                    ClearAll()
                End If
            Else
                Msg(Me, "Please fill all fields!", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRegisterUpdateBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        Me.Text = _form_title
        FillCategories()
        btnUpdate.Enabled = False

        If _form_title = "UPDATE BOOK" Then
            Try
                str = "SELECT books.id, books.isbn, books.call_number, books.title, books.author, books.publisher, books.description, book_categories.category_id, book_categories.category, books.date_published, books.series, books.price, books.image FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE books.id = '" + CStr(_selected_book_id) + "'"
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txtAuthor.Text = dr("author")
                    txtCallNumber.Text = dr("call_number")
                    txtDatePublished.Text = dr("date_published")
                    txtDescription.Text = dr("description")
                    txtISBN.Text = dr("isbn")
                    txtPrice.Text = dr("price")
                    txtPublisher.Text = dr("publisher")
                    txtTitle.Text = dr("title")
                    txtSeries.Text = dr("series")
                    cmbCategories.Text = dr("category")

                    Try
                        pbBookImage.Image = dr("image")
                    Catch ex As Exception
                        pbBookImage.Image = My.Resources.no_image1
                    End Try
                End If

                btnSave.Enabled = False
                btnClear.Enabled = False
                btnUpdate.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BrowsePicture(sender As Object, e As EventArgs) Handles pbBrowsePic.Click, lblBrowsePic.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.jpg;*.png"
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            pbBookImage.ImageLocation = OpenFileDialog1.FileName
            _imagePath = pbBookImage.ImageLocation
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        CloseTransparentForm()
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

    Private Sub GetCategoryID(category As String)
        Try
            str = "SELECT category_id FROM book_categories WHERE category = '" + CStr(category) + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                _category_id = dr("category_id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategories.SelectedIndexChanged
        GetCategoryID(cmbCategories.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub ClearAll()
        txtCallNumber.Clear()
        txtAuthor.Clear()
        txtDescription.Clear()
        txtISBN.Clear()
        txtPrice.Clear()
        txtPublisher.Clear()
        txtDatePublished.Clear()
        txtTitle.Clear()
        cmbCategories.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtAuthor.Text.Length > 0 And txtCallNumber.Text.Length > 0 And txtDescription.Text.Length > 0 And txtISBN.Text.Length > 0 And txtPrice.Text.Length > 0 And txtPublisher.Text.Length > 0 And txtDatePublished.Text.Length > 0 And txtTitle.Text.Length > 0 And cmbCategories.SelectedIndex > -1 Then
                Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

                If mes = DialogResult.Yes Then
                    str = "UPDATE books SET isbn=@isbn, call_number=@call_number, title=@title, author=@author, publisher=@publisher, description=@description, category_id=@category_id, date_published=@date_published, copies=@copies, price=@price, series=@series, image=@image WHERE id = @id"
                    cmd = New SqlCommand(str, conn)
                    cmd.Parameters.AddWithValue("@id", _selected_book_id)
                    cmd.Parameters.AddWithValue("@isbn", txtISBN.Text)
                    cmd.Parameters.AddWithValue("@call_number", txtCallNumber.Text)
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
                    cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@category_id", cmbCategories.SelectedIndex + 1)
                    cmd.Parameters.AddWithValue("@date_published", txtDatePublished.Text)
                    cmd.Parameters.AddWithValue("@series", txtSeries.Text)
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text)
                    cmd.Parameters.AddWithValue("@image", _imagePath)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Msg(Me, "Book Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    is_reload = True
                    CloseTransparentForm()
                    Me.Hide()
                End If

            End If
        Catch ex As Exception
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Dim category As New frmBookCategories
        category.ShowDialog(Me)

        If is_reload = True Then
            FillCategories()
            is_reload = False
        End If
    End Sub

End Class