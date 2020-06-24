Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class ucBorrowers

    Dim rowCount As Integer
    Dim rowCountF As Integer

    Dim is_added As Boolean = False

    Private Sub ucBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        CheckForIllegalCrossThreadCalls = False
        MetroTabControl1.SelectedIndex = 0
        cmbSearchStudent.SelectedIndex = 0
        cmbSearchFaculty.SelectedIndex = 0
    End Sub

    Friend Sub FillGridViewStudent()
        Try
            str = "SELECT COUNT(*) AS totalrow FROM students WHERE status_id = 1"
            cmd = New SqlCommand(str, conn)
            Dim dr As SqlDataReader = cmd.ExecuteReader

            If dr.HasRows Then
                If dr.Read Then
                    rowCount = dr("totalrow")
                    lblTotalStudents.Text = "Total Students Registered: " + Format(rowCount, "N0")

                    dr.Close()
                    cmd.Dispose()
                End If
            End If

            dgvStudents.Rows.Clear()

            Dim str1 = "SELECT student_id, firstname, middlename, lastname, gender, major FROM students WHERE status_id = 1"
            cmd = New SqlCommand(str1, conn)
            Dim dr1 As SqlDataReader = cmd.ExecuteReader

            If dr1.HasRows Then
                While dr1.Read
                    dgvStudents.Rows.Add(dr1("student_id"), dr1("firstname"), dr1("middlename"), dr1("lastname"), dr1("gender"), dr1("major"))
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Friend Sub FillGridViewFaculty()
        Try
            str = "SELECT COUNT(*) AS totalrow FROM faculties WHERE status_id = 1"
            cmd = New SqlCommand(str, conn)
            Dim dr As SqlDataReader = cmd.ExecuteReader

            If dr.HasRows Then
                If dr.Read Then
                    rowCount = dr("totalrow")
                    lblShowingNentries.Text = "Total Faculties Registered: " + Format(rowCount, "N0")

                    dr.Close()
                    cmd.Dispose()
                End If
            End If

            dgvFaculties.Rows.Clear()

            Dim str1 As String = "SELECT * FROM faculties WHERE status_id = 1"
            cmd = New SqlCommand(str1, conn)
            Dim dr1 As SqlDataReader = cmd.ExecuteReader

            If dr1.HasRows Then
                While dr1.Read
                    dgvFaculties.Rows.Add(dr1("faculty_id"), dr1("firstname"), dr1("middlename"), dr1("lastname"), dr1("gender"), CDate(dr1("birthday")).ToShortDateString())
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Faculty Gridview")
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub btnAddFaculty_Click(sender As Object, e As EventArgs) Handles btnAddFaculty.Click
        OpenTransparentForm(Me)
        Dim add_faculty As New frmRegisterFaculty
        add_faculty.ShowDialog(Me)

        If is_reload = True Then
            FillGridViewFaculty()
            is_reload = False
        End If
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        OpenTransparentForm(Me)
        Dim add_student As New frmRegisterStudent
        add_student.ShowDialog(Me)

        If is_reload = True Then
            FillGridViewStudent()
            is_reload = False
        End If
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        If MetroTabControl1.SelectedIndex = 0 Then
            btnAddStudent.BringToFront()

            'Show Student Search Box
            cmbSearchStudent.BringToFront()
            cmbSearchStudent.SelectedIndex = 0
            txtSearchStudent.BringToFront()
        Else
            btnAddFaculty.BringToFront()

            'Show Faculty Search Box
            cmbSearchFaculty.BringToFront()
            cmbSearchFaculty.SelectedIndex = 0
            txtSearchFaculty.BringToFront()
        End If
    End Sub

    Private Sub btnLoanHistoryStudent_Click(sender As Object, e As EventArgs) Handles btnLoanHistoryStudent.Click
        Dim i As Integer = dgvStudents.CurrentRow.Index

        OpenTransparentForm(Me)
        Dim loan_history As New frmLoanHistory
        loan_history.borrower_name = dgvStudents.Item(1, i).Value + " " + dgvStudents.Item(2, i).Value + " " + dgvStudents.Item(3, i).Value
        loan_history.id_no = dgvStudents.Item(0, i).Value
        loan_history.ShowDialog(Me)
    End Sub

    Private Sub btnLoanHistoryFaculty_Click(sender As Object, e As EventArgs) Handles btnLoanHistoryFaculty.Click
        Dim i As Integer = dgvFaculties.CurrentRow.Index

        OpenTransparentForm(Me)
        Dim loan_history As New frmLoanHistory
        loan_history.borrower_name = dgvFaculties.Item(1, i).Value + " " + dgvFaculties.Item(2, i).Value + " " + dgvFaculties.Item(3, i).Value
        loan_history.id_no = dgvFaculties.Item(0, i).Value
        loan_history.ShowDialog(Me)
    End Sub

    Private Sub txtSearchStudent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchStudent.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If cmbSearchStudent.SelectedIndex = 0 Then
                    str = "SELECT * FROM students WHERE status_id = 1"
                ElseIf cmbSearchStudent.SelectedIndex = 1 Then
                    str = "SELECT * FROM students WHERE student_id = '" + txtSearchStudent.Text + "' AND status_id = 1"
                ElseIf cmbSearchStudent.SelectedIndex = 2 Then
                    str = "SELECT * FROM students WHERE lastname LIKE '%" + txtSearchStudent.Text + "%' AND status_id = 1"
                ElseIf cmbSearchStudent.SelectedIndex = 3 Then
                    str = "SELECT * FROM students WHERE firstname LIKE '%" + txtSearchStudent.Text + "%' AND status_id = 1"
                ElseIf cmbSearchStudent.SelectedIndex = 4 Then
                    str = "SELECT * WHERE middlename LIKE '%" + txtSearchStudent.Text + "%' AND status_id = 1"
                ElseIf cmbSearchStudent.SelectedIndex = 5 Then
                    str = "SELECT * FROM students WHERE major LIKE '%" + txtSearchStudent.Text + "%' AND status_id = 1"
                End If
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                dgvStudents.Rows.Clear()
                While dr.Read
                    dgvStudents.Rows.Add(dr("student_id"), dr("firstname"), dr("middlename"), dr("lastname"), dr("gender"), dr("major"))
                End While
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cmbSearchStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchStudent.SelectedIndexChanged
        'If cmbSearchStudent.SelectedIndex = 0 Then
        '    FillGridViewStudent()
        '    txtSearchStudent.Clear()
        'End If
    End Sub

    Private Sub txtSearchFaculty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchFaculty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbSearchFaculty.SelectedIndex = 0 Then
                str = "SELECT * FROM faculties WHERE status_id = 1"
            ElseIf cmbSearchFaculty.SelectedIndex = 1 Then
                str = "SELECT * FROM faculties WHERE faculty_id = '" + txtSearchFaculty.Text + "' AND status_id = 1"
            ElseIf cmbSearchFaculty.SelectedIndex = 2 Then
                str = "SELECT * FROM faculties WHERE lastname LIKE '%" + txtSearchFaculty.Text + "%' AND status_id = 1"
            ElseIf cmbSearchFaculty.SelectedIndex = 3 Then
                str = "SELECT * FROM faculties WHERE firstname LIKE '%" + txtSearchFaculty.Text + "%' AND status_id = 1"
            ElseIf cmbSearchFaculty.SelectedIndex = 4 Then
                str = "SELECT * FROM faculties WHERE middlename LIKE '%" + txtSearchFaculty.Text + "%' AND status_id = 1"
            End If
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvFaculties.Rows.Clear()

            While dr.Read
                dgvFaculties.Rows.Add(dr("faculty_id"), dr("firstname"), dr("middlename"), dr("lastname"), dr("gender"), CDate(dr("birthday")).ToShortDateString())
            End While
        End If
    End Sub

    Private Sub cmbSearchFaculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchFaculty.SelectedIndexChanged
        'If cmbSearchFaculty.SelectedIndex = 0 Then
        '    FillGridViewFaculty()
        '    txtSearchFaculty.Clear()
        'End If
    End Sub

    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick
        Dim i As Integer = dgvStudents.CurrentRow.Index
        Dim tempStudentID As String = dgvStudents.Item(0, i).Value

        If e.ColumnIndex = 6 Then
            OpenTransparentForm(Me)

            Dim update_student As New frmRegisterStudent
            update_student.student_id = tempStudentID
            update_student.is_update = True
            update_student.ShowDialog(Me)

            If is_reload Then
                FillGridViewStudent()
                is_reload = False
            End If
        ElseIf e.ColumnIndex = 7 Then
            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

            If mes = DialogResult.Yes Then
                Try
                    str = "UPDATE students SET status_id = 0 WHERE student_id = '" + CStr(tempStudentID) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()

                    AN_ActivityLog() 'Auto Number for activity log
                    RecordActivities(userID, "Delete student account. Deleted: " + CStr(tempStudentID), "Borrower Management") 'Activity

                    Msg(Me, "Record successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FillGridViewStudent()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub dgvFaculties_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFaculties.CellContentClick
        Dim i As Integer = dgvFaculties.CurrentRow.Index
        Dim tempFacultyID As String = dgvFaculties.Item(0, i).Value

        If e.ColumnIndex = 6 Then
            OpenTransparentForm(Me)

            Dim update_faculty As New frmRegisterFaculty
            update_faculty.faculty_id = tempFacultyID
            update_faculty.is_update = True
            update_faculty.ShowDialog(Me)

            If is_reload Then
                FillGridViewFaculty()
                is_reload = False
            End If
        ElseIf e.ColumnIndex = 7 Then
            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

            If mes = DialogResult.Yes Then
                Try
                    str = "UPDATE faculties SET status_id = 0 WHERE faculty_id = '" + CStr(tempFacultyID) + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.ExecuteNonQuery()

                    AN_ActivityLog() 'Auto Number for activity log
                    RecordActivities(userID, "Delete faculty account. Deleted: " + CStr(tempFacultyID), "Borrower Management") 'Activity

                    Msg(Me, "Record successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FillGridViewFaculty()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub
End Class