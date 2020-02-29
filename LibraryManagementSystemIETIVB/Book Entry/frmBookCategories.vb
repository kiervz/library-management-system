Imports System.Data.SqlClient

Public Class frmBookCategories

    Dim category_id As Integer

    Private Sub frmBookCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LoadCategories()
        btnUpdate.Enabled = False
    End Sub

    Private Sub LoadCategories()
        Try
            str = "SELECT * FROM book_categories"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBookCategories.Rows.Clear()

            While dr.Read
                dgvBookCategories.Rows.Add(dr("category_id"), dr("category"))
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            str = "SELECT category FROM book_categories WHERE category = @category"
            cmd = New SqlCommand(str, conn)
            cmd.Parameters.AddWithValue("@category", txtCategory.Text)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Msg(Me, "Category you have entered is already exist!", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mes = DialogResult.Yes Then
                str = "INSERT INTO book_categories (category_id, category) VALUES ((SELECT ISNULL(MAX(category_id) + 1, 0) FROM book_categories), @category)"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@category", txtCategory.Text)
                cmd.ExecuteNonQuery()
                Msg(Me, "Category has been added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadCategories()
                txtCategory.Clear()
                is_reload = True
            End If
        Catch ex As Exception
            'Dim el As New ErrorLogger
            'el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
            Msg(Me, "Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mes = DialogResult.Yes Then
                str = "UPDATE book_categories SET category =@category WHERE category_id = '" + CStr(category_id) + "'"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@category", txtCategory.Text)
                cmd.ExecuteNonQuery()

                Msg(Me, "Category has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadCategories()
                txtCategory.Clear()
                btnSave.Enabled = True
                btnUpdate.Enabled = False
                is_reload = True
            End If
        Catch ex As Exception
            'Dim el As New ErrorLogger
            'el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
            Msg(Me, "Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        LoadCategories()
        txtCategory.Clear()
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub dgvBookCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookCategories.CellContentClick
        Dim i As Integer = dgvBookCategories.CurrentRow.Index

        category_id = dgvBookCategories.Item(0, i).Value

        If e.ColumnIndex = 2 Then
            txtCategory.Text = dgvBookCategories.Item(1, i).Value
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            'ElseIf e.ColumnIndex = 3 Then
            '    CustomMessageBox.ShowDialog(Me, "Are you sure you want to Delete?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

            '    If msgBoxButtonClick = DialogResult.Yes Then
            '        Try
            '            str = "DELETE book_categories WHERE category_id = '" + CStr(category_id) + "'"
            '            cmd = New SqlCommand(str, conn)
            '            cmd.ExecuteNonQuery()
            '            MessageBox.Show("Category has been deleted!")
            '            LoadCategories()
            '            txtCategory.Clear()
            '            btnSave.Enabled = True
            '            btnUpdate.Enabled = False
            '        Catch ex As Exception
            '            Dim el As New ErrorLogger
            '            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
            '            CustomMessageBox.ShowDialog(Me, "Something Went Wrong!", "Error", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
            '        Finally
            '            dr.Close()
            '            cmd.Dispose()
            '        End Try
            '    End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class