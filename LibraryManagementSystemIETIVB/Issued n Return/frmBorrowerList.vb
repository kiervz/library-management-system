Imports System.Data.SqlClient

Public Class frmBorrowerList
    Private Sub frmBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedIndex = 0
        cmbSearchFaculty.SelectedIndex = 0
        cmbSearchStudent.SelectedIndex = 0
        LoadStudents()
        LoadFaculties()
    End Sub

    Private Sub LoadStudents(Optional ByVal str As String = "SELECT student_id, firstname, middlename, lastname, gender, major FROM students")
        Try
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

    Private Sub LoadFaculties(Optional ByVal str As String = "SELECT faculty_id, firstname, middlename, lastname, gender, birthday FROM faculties", Optional ByVal search As String = "")
        Try
            cmd = New SqlCommand(str, conn)
            If Not search = "" Then cmd.Parameters.AddWithValue("@search", txtSearchFaculty.Text)
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

    Private Sub txtSearchStudent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchStudent.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbSearchStudent.SelectedIndex = 0 Then
                str = "SELECT * FROM students WHERE student_id = '" + txtSearchStudent.Text + "'"
            ElseIf cmbSearchStudent.SelectedIndex = 1 Then
                str = "SELECT * FROM students WHERE lastname LIKE '%" + txtSearchStudent.Text + "%'"
            ElseIf cmbSearchStudent.SelectedIndex = 2 Then
                str = "SELECT * FROM students WHERE firstname LIKE '%" + txtSearchStudent.Text + "%'"
            ElseIf cmbSearchStudent.SelectedIndex = 3 Then
                str = "SELECT * FROM students WHERE middlename LIKE '%" + txtSearchStudent.Text + "%'"
            ElseIf cmbSearchStudent.SelectedIndex = 4 Then
                str = "SELECT * FROM students WHERE major = '" + txtSearchStudent.Text + "'"
            End If

            If txtSearchStudent.Text = "" Then
                LoadStudents()
            Else
                LoadStudents(str)
            End If
        End If
    End Sub

    Private Sub txtSearchFaculty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchFaculty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbSearchFaculty.SelectedIndex = 0 Then
                str = "SELECT * FROM faculties WHERE faculty_id = '" + txtSearchFaculty.Text + "'"
            ElseIf cmbSearchFaculty.SelectedIndex = 1 Then
                str = "SELECT * FROM faculties WHERE lastname LIKE '%" + txtSearchFaculty.Text + "%'"
            ElseIf cmbSearchFaculty.SelectedIndex = 2 Then
                str = "SELECT * FROM faculties WHERE firstname LIKE '%" + txtSearchFaculty.Text + "%'"
            ElseIf cmbSearchFaculty.SelectedIndex = 3 Then
                str = "SELECT * FROM faculties WHERE middlenameLIKE '%" + txtSearchFaculty.Text + "%'"
            End If

            If txtSearchFaculty.Text = "" Then
                LoadFaculties()
            Else
                LoadFaculties(str)
            End If
        End If
    End Sub
End Class