Imports System.Data.SqlClient

Public Class frmBorrowerList
    Private Sub frmBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedIndex = 0
        LoadStudents()
        LoadFaculties()
    End Sub

    Private Sub LoadStudents()
        Try
            str = "SELECT student_id, firstname, middlename, lastname, gender, major FROM students"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvStudents.Rows.Clear()

            While dr.Read
                dgvStudents.Rows.Add(dr("student_id"), dr("firstname"), dr("middlename"), dr("lastname"), dr("gender"), dr("major"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadFaculties()
        Try
            str = "SELECT * FROM faculties"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvFaculties.Rows.Clear()

            While dr.Read
                dgvFaculties.Rows.Add(dr("faculty_id"), dr("firstname"), dr("middlename"), dr("lastname"), dr("gender"), CDate(dr("birthday")).ToShortDateString())
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub

    Private Sub dgvStudents_DoubleClick(sender As Object, e As EventArgs) Handles dgvStudents.DoubleClick
        Dim i As Integer = dgvStudents.CurrentRow.Index

        borrower_id = dgvStudents.Item(0, i).Value
        CloseTransparentForm()
        Me.Hide()
    End Sub

    Private Sub dgvFaculties_DoubleClick(sender As Object, e As EventArgs) Handles dgvFaculties.DoubleClick
        Dim i As Integer = dgvFaculties.CurrentRow.Index

        borrower_id = dgvFaculties.Item(0, i).Value
        CloseTransparentForm()
        Me.Hide()
    End Sub

End Class