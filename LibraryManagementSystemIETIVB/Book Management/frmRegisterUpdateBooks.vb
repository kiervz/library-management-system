Imports System.Data.SqlClient

Public Class frmRegisterUpdateBooks

    Private _imagePath As String = "none"
    Private _book_id As Integer
    Private _category_id As Integer
    Friend form_title As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtAuthor.Text.Length > 0 And txtDescription.Text.Length > 0 And txtISBN.Text.Length > 0 And txtPrice.Text.Length > 0 And txtPublisher.Text.Length > 0 And txtRackNo.Text.Length > 0 And txtSeriesDate.Text.Length > 0 And txtTitle.Text.Length > 0 And cmbCategories.SelectedIndex > -1 Then
            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Add?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

            If msgBoxButtonClick = DialogResult.Yes Then
                Try
                    str = "INSERT INTO books (id, isbn, title, author, publisher, description, category_id, series_date, rack_no, status, image) VALUES (@id, @isbn, @title, @author, @publisher, @description, @category_id, @series_date, @rack_no, @status, @image)"
                    cmd = New SqlCommand(str, conn)
                    cmd.Parameters.AddWithValue("@id", _book_id)
                    cmd.Parameters.AddWithValue("@isbn", txtISBN.Text)
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
                    cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@category_id", _category_id)
                    cmd.Parameters.AddWithValue("@series_date", txtSeriesDate.Text)
                    cmd.Parameters.AddWithValue("@rack_no", txtRackNo.Text)
                    cmd.Parameters.AddWithValue("@status", "available")
                    cmd.Parameters.AddWithValue("@image", _imagePath)
                    cmd.ExecuteNonQuery()
                    BookAutoID()
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
        Me.Text = form_title
        FillCategories()
        BookAutoID()
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

    Private Sub BookAutoID()
        Try
            str = "SELECT MAX(id) FROM books"
            cmd = New SqlCommand(str, conn)

            If IsDBNull(cmd.ExecuteScalar()) Then
                _book_id += 1
            Else
                _book_id = Convert.ToString(cmd.ExecuteScalar())
                _book_id += 1
            End If
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
        txtAuthor.Clear()
        txtDescription.Clear()
        txtISBN.Clear()
        txtPrice.Clear()
        txtPublisher.Clear()
        txtRackNo.Clear()
        txtSeriesDate.Clear()
        txtTitle.Clear()
        cmbCategories.SelectedIndex = 0
    End Sub
End Class