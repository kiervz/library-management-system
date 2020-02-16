Imports System.Data.SqlClient

Public Class frmRegisterUpdateBooks

    Private _imagePath As String = "none"
    Private _book_id As Integer
    Private _category_id As Integer
    Friend _form_title As String
    Friend _selected_book_id As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtAuthor.Text.Length > 0 And txtCallNumber.Text.Length > 0 And txtDescription.Text.Length > 0 And txtISBN.Text.Length > 0 And txtPrice.Text.Length > 0 And txtPublisher.Text.Length > 0 And txtCopies.Text.Length > 0 And txtDatePublished.Text.Length > 0 And txtTitle.Text.Length > 0 And cmbCategories.SelectedIndex > -1 Then
            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Add?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

            If msgBoxButtonClick = DialogResult.Yes Then
                Try
                    str = "INSERT INTO books (id,isbn,call_number,title,author,publisher,description,category_id,date_published,copies,image) VALUES ((SELECT ISNULL(MAX(id) + 1, 0) FROM books),@isbn,@call_number,@title,@author,@publisher,@description,@category_id,@date_published,@copies,@image)"
                    cmd = New SqlCommand(str, conn)
                    cmd.Parameters.AddWithValue("@isbn", txtISBN.Text)
                    cmd.Parameters.AddWithValue("@call_number", txtCallNumber.Text)
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
                    cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@category_id", _category_id)
                    cmd.Parameters.AddWithValue("@date_published", txtDatePublished.Text)
                    cmd.Parameters.AddWithValue("@copies", txtCopies.Text)
                    cmd.Parameters.AddWithValue("@image", _imagePath)
                    cmd.ExecuteNonQuery()
                    CustomMessageBox.ShowDialog(Me, "Book Successfully Added!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)

                    ClearAll()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            CustomMessageBox.ShowDialog(Me, "Please fill all fields!", "Fields Required", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
        End If
    End Sub

    Private Sub frmRegisterUpdateBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        Me.Text = _form_title
        FillCategories()
        btnUpdate.Enabled = False

        If _form_title = "UPDATE BOOK" Then
            Try
                str = "SELECT books.id, books.isbn, books.call_number, books.title, books.author, books.publisher, books.description, book_categories.category_id, book_categories.category, books.date_published, books.copies, books.price, books.image FROM books INNER JOIN book_categories ON books.category_id = book_categories.category_id WHERE books.id = '" + CStr(_selected_book_id) + "'"
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txtAuthor.Text = dr("author")
                    txtCallNumber.Text = dr("call_number")
                    txtCopies.Text = dr("copies")
                    txtDatePublished.Text = dr("date_published")
                    txtDescription.Text = dr("description")
                    txtISBN.Text = dr("isbn")
                    txtPrice.Text = dr("price")
                    txtPublisher.Text = dr("publisher")
                    txtTitle.Text = dr("title")
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
        Else
            cmbCategories.SelectedIndex = 0
        End If
    End Sub

    Private Sub BrowsePicture(sender As Object, e As EventArgs) Handles pbBrowsePic.Click, lblBrowsePic.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.jpg;*.png"
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = Nothing Then
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
        txtCopies.Clear()
        txtDatePublished.Clear()
        txtTitle.Clear()
        cmbCategories.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtAuthor.Text.Length > 0 And txtCallNumber.Text.Length > 0 And txtDescription.Text.Length > 0 And txtISBN.Text.Length > 0 And txtPrice.Text.Length > 0 And txtPublisher.Text.Length > 0 And txtCopies.Text.Length > 0 And txtDatePublished.Text.Length > 0 And txtTitle.Text.Length > 0 And cmbCategories.SelectedIndex > -1 Then
                CustomMessageBox.ShowDialog(Me, "Are you sure you want to Update?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

                If msgBoxButtonClick = DialogResult.Yes Then
                    str = "UPDATE books SET isbn=@isbn, call_number=@call_number, title=@title, author=@author, publisher=@publisher, description=@description, category_id=@category_id, date_published=@date_published, copies=@copies, price=@price, image=@image WHERE id = @id"
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
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text)
                    cmd.Parameters.AddWithValue("@copies", txtCopies.Text)
                    cmd.Parameters.AddWithValue("@image", _imagePath)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    CustomMessageBox.ShowDialog(Me, "Book Successfully Updated!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                    is_book_updated = True
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
    End Sub
End Class