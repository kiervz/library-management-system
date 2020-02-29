Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class ucBorrowers

    'to install office.interlop
    'Install-Package Microsoft.Office.Interop.Excel

    Dim thread As Threading.Thread
    Dim threadF As Threading.Thread

    Dim iCount, i As Integer
    Dim iCountF, i_f As Integer

    Dim xlApp As Excel.Application
    Dim xlAppF As Excel.Application

    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkBookF As Excel.Workbook

    Dim xlWorkSheet As Excel.Worksheet
    Dim xlWorkSheetF As Excel.Worksheet

    Dim xlRange As Excel.Range
    Dim xlRangeF As Excel.Range

    Dim xlRow As Integer
    Dim xlRowF As Integer

    Dim strDestination As String
    Dim strDestinationF As String

    Dim rowCount As Integer
    Dim rowCountF As Integer

    Dim is_added As Boolean = False

    Private Sub ucBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        CheckForIllegalCrossThreadCalls = False
        MetroTabControl1.SelectedIndex = 0
        cmbSearchStudent.SelectedIndex = 0
        cmbSearchFaculty.SelectedIndex = 0
        PanelStudentImport.Hide()
        PanelFacultyImport.Hide()
    End Sub

    'IMPORT EXCEL FACULTY
    Private Sub btnImportFaculties_Click(sender As Object, e As EventArgs) Handles btnImportFaculties.Click
        Try
            With OpenFileDialog1
                .Filter = "Excel Office| *.xls;*.xlsx"
                .FileName = String.Empty
                .ShowDialog()
                strDestinationF = .FileName
            End With

            If strDestinationF <> String.Empty Then
                xlAppF = New Excel.Application
                xlWorkBookF = xlAppF.Workbooks.Open(strDestinationF)
                xlWorkSheetF = xlWorkBookF.Worksheets("Sheet1")
                xlRangeF = xlWorkSheetF.UsedRange
                threadF = New Threading.Thread(AddressOf LoadDataFaculty)
                PanelFacultyImport.Show()
                threadF.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'IMPORT EXCEL STUDENTS
    Private Sub btnImportStudent_Click(sender As Object, e As EventArgs) Handles btnImportStudent.Click
        Try
            With OpenFileDialog1
                .Filter = "Excel Office| *.xls;*.xlsx"
                .FileName = String.Empty
                .ShowDialog()
                strDestination = .FileName
            End With

            If strDestination <> String.Empty Then
                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Open(strDestination)
                xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
                xlRange = xlWorkSheet.UsedRange
                thread = New Threading.Thread(AddressOf LoadDataStudent)
                PanelStudentImport.Show()
                thread.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'IMPORT STUDENT DATA FROM EXCEL TO DATABASE THEN DISPLAY IN DATAGRIDVIEW
    Private Sub LoadDataStudent()
        Try
            txtImportingS.Text = "Importing 0 records"
            Dim rowcount As Integer = 0

            xlRange = xlWorkSheet.UsedRange

            For xlRow = 1 To xlRange.Rows.Count
                isStudentsImporting = True
                btnImportStudent.Enabled = False
                btnImportFaculties.Enabled = False
                If xlRow = 1 Then
                    If xlRange.Cells(xlRow, 1).Text = "Student ID" And xlRange.Cells(xlRow, 2).Text = "Firstname" And xlRange.Cells(xlRow, 3).Text = "Middlename" And xlRange.Cells(xlRow, 4).Text = "Lastname" And xlRange.Cells(xlRow, 5).Text = "Gender" And xlRange.Cells(xlRow, 6).Text = "Birthday" And xlRange.Cells(xlRow, 7).Text = "Major" Then
                        If xlRow = 1 Then xlRow += 1
                    Else
                        MessageBox.Show("Please arrange excel file in order. " +
                                      Environment.NewLine + "Student ID" +
                                      Environment.NewLine + "Firstname" +
                                      Environment.NewLine + "Middlename" +
                                      Environment.NewLine + "Lastname" +
                                      Environment.NewLine + "Gender" +
                                      Environment.NewLine + "Birthday" +
                                      Environment.NewLine + "Major")

                        xlWorkBook.Close()
                        xlApp.Quit()

                        releaseObject(xlApp)
                        releaseObject(xlWorkBook)
                        releaseObject(xlWorkSheet)

                        TerminateProcess("excel.exe")

                        PanelStudentImport.Hide()
                        btnImportStudent.Enabled = True
                        btnImportFaculties.Enabled = True
                        thread.Abort()
                        Exit Sub
                    End If
                End If

                'If not already in the database 
                If Not IfAlreadyExistInDBStudent(xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 6).Text()) = True Then 'The student information will add
                    'The student information will add
                    AddToDatabaseStudent(xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 6).Text(), xlRange.Cells(xlRow, 7).Text())
                    If is_added = True Then
                        rowcount += 1

                        txtImportingS.Text = "Importing " & rowcount & " records"
                        txtPleasewaitS.Text = "please wait..."
                        is_added = False
                    End If
                End If
            Next

            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            TerminateProcess("excel.exe")

            btnImportStudent.Enabled = True
            btnImportFaculties.Enabled = True

            PanelStudentImport.Hide()
            isStudentsImporting = False
            FillGridViewStudent()
            thread.Abort()
        Catch ex As Exception
        End Try
    End Sub

    'IMPORT FACULTY DATA FROM EXCEL TO DATABASE THEN DISPLAY IN DATAGRIDVIEW
    Private Sub LoadDataFaculty()
        Try
            txtImporting.Text = "Importing 0 records"
            Dim rowcount As Integer = 0

            xlRangeF = xlWorkSheetF.UsedRange

            For xlRowF = 1 To xlRangeF.Rows.Count
                isFacultiesImporting = True
                btnImportStudent.Enabled = False
                btnImportFaculties.Enabled = False
                If xlRowF = 1 Then
                    If xlRangeF.Cells(xlRowF, 1).Text = "Faculty ID" And xlRangeF.Cells(xlRowF, 2).Text = "Firstname" And xlRangeF.Cells(xlRowF, 3).Text = "Middlename" And xlRangeF.Cells(xlRowF, 4).Text = "Lastname" And xlRangeF.Cells(xlRowF, 5).Text = "Gender" And xlRangeF.Cells(xlRowF, 6).Text = "Birthday" Then
                        If xlRowF = 1 Then xlRowF += 1
                    Else
                        MessageBox.Show("Please arrange excel file in order. " +
                                  Environment.NewLine + "Faculty ID" +
                                  Environment.NewLine + "Firstname" +
                                  Environment.NewLine + "Middlename" +
                                  Environment.NewLine + "Lastname" +
                                  Environment.NewLine + "Gender" +
                                  Environment.NewLine + "Birthday")

                        xlWorkBookF.Close()
                        xlAppF.Quit()

                        releaseObject(xlAppF)
                        releaseObject(xlWorkBookF)
                        releaseObject(xlWorkSheetF)

                        TerminateProcess("excel.exe")

                        PanelFacultyImport.Hide()
                        btnImportStudent.Enabled = True
                        btnImportFaculties.Enabled = True
                        threadF.Abort()
                        Exit Sub
                    End If
                End If

                'If not already in the database 
                If Not IfAlreadyExistInDBFaculty(xlRangeF.Cells(xlRowF, 1).Text(), xlRangeF.Cells(xlRowF, 2).Text(), xlRangeF.Cells(xlRowF, 3).Text(), xlRangeF.Cells(xlRowF, 4).Text(), xlRangeF.Cells(xlRowF, 6).Text()) = True Then
                    'The faculty information will add
                    AddToDatabaseFaculty(xlRangeF.Cells(xlRowF, 1).Text(), xlRangeF.Cells(xlRowF, 2).Text(), xlRangeF.Cells(xlRowF, 3).Text(), xlRangeF.Cells(xlRowF, 4).Text(), xlRangeF.Cells(xlRowF, 5).Text(), xlRangeF.Cells(xlRowF, 6).Text())
                    If is_added = True Then
                        rowcount += 1

                        txtImporting.Text = "Importing " & rowcount & " records"
                        txtPleasewait.Text = "please wait..."
                        is_added = False
                    End If
                End If
            Next

            xlWorkBookF.Close()
            xlAppF.Quit()

            releaseObject(xlAppF)
            releaseObject(xlWorkBookF)
            releaseObject(xlWorkSheetF)

            TerminateProcess("excel.exe")

            btnImportStudent.Enabled = True
            btnImportFaculties.Enabled = True

            PanelFacultyImport.Hide()
            isFacultiesImporting = False
            FillGridViewFaculty()
            threadF.Abort()
        Catch ex As Exception
        End Try
    End Sub

    Friend Sub FillGridViewStudent()
        Try
            str = "SELECT COUNT(*) AS totalrow FROM students"
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

            Dim str1 = "SELECT student_id, firstname, middlename, lastname, gender, major FROM students"
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
            str = "SELECT COUNT(*) AS totalrow FROM faculties"
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

            Dim str1 As String = "SELECT * FROM faculties"
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
            btnImportStudent.BringToFront()

            'Show Student Search Box
            cmbSearchStudent.BringToFront()
            cmbSearchStudent.SelectedIndex = 0
            txtSearchStudent.BringToFront()
        Else
            btnAddFaculty.BringToFront()
            btnImportFaculties.BringToFront()

            'Show Faculty Search Box
            cmbSearchFaculty.BringToFront()
            cmbSearchFaculty.SelectedIndex = 0
            txtSearchFaculty.BringToFront()
        End If
    End Sub

    Private Function IfAlreadyExistInDBFaculty(facultyID As String, fname As String, mname As String, lname As String, bday As String)
        Dim isAlreadyExist As Boolean = False
        Try
            If facultyID = "" Then
                isAlreadyExist = True
                Exit Function
            End If
            str = "SELECT faculty_id FROM faculties WHERE faculty_id = '" + facultyID + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                isAlreadyExist = True
            Else
                isAlreadyExist = False
            End If

            cmd.Dispose()
            dr.Close()

            If isAlreadyExist = False Then
                str = "SELECT * FROM students WHERE firstname = @fn AND middlename = @mn AND lastname = @ln AND birthday = @bday"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@fn", fname)
                cmd.Parameters.AddWithValue("@mn", mname)
                cmd.Parameters.AddWithValue("@ln", lname)
                cmd.Parameters.AddWithValue("@bday", CDate(bday).ToShortDateString())
                dr = cmd.ExecuteReader

                If dr.Read Then
                    isAlreadyExist = True
                Else
                    isAlreadyExist = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            dr.Close()
        End Try
        Return isAlreadyExist
    End Function

    Private Function IfAlreadyExistInDBStudent(studID As String, fname As String, mname As String, lname As String, bday As String)
        Dim isAlreadyExist As Boolean = False
        Try
            If studID = "" Then
                isAlreadyExist = True
                Exit Function
            End If
            str = "SELECT student_id FROM students WHERE student_id = '" + studID + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                isAlreadyExist = True
            Else
                isAlreadyExist = False
            End If

            cmd.Dispose()
            dr.Close()

            If isAlreadyExist = False Then
                str = "SELECT * FROM students WHERE firstname = @fn AND middlename = @mn AND lastname = @ln AND birthday = @bday"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@fn", fname)
                cmd.Parameters.AddWithValue("@mn", mname)
                cmd.Parameters.AddWithValue("@ln", lname)
                cmd.Parameters.AddWithValue("@bday", CDate(bday).ToShortDateString())
                dr = cmd.ExecuteReader

                If dr.Read Then
                    isAlreadyExist = True
                Else
                    isAlreadyExist = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            isAlreadyExist = False
        Finally
            cmd.Dispose()
            dr.Close()
        End Try
        Return isAlreadyExist
    End Function

    Private Sub AddToDatabaseStudent(studID As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As String, major As String)
        Try
            If studID.Length > 0 And firstname.Length > 0 And lastname.Length > 0 And gender.Length > 0 And birthday.Length > 0 And major.Length > 0 Then
                Dim str As String = "INSERT INTO students (student_id,firstname,middlename,lastname,gender,birthday,major) VALUES (@student_id,@firstname,@middlename,@lastname,@gender,@birthday,@major)"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@student_id", studID)
                cmd.Parameters.AddWithValue("@firstname", firstname)
                cmd.Parameters.AddWithValue("@middlename", middlename)
                cmd.Parameters.AddWithValue("@lastname", lastname)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@birthday", CDate(birthday).ToShortDateString())
                cmd.Parameters.AddWithValue("@major", major)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                is_added = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddToDatabaseFaculty(faculty_id As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As String)
        Try
            If faculty_id.Length > 0 And firstname.Length > 0 And lastname.Length > 0 And gender.Length > 0 And birthday.Length > 0 Then
                Dim str As String = "INSERT INTO faculties (faculty_id,firstname,middlename,lastname,gender,birthday) VALUES (@faculty_id,@firstname,@middlename,@lastname,@gender,@birthday)"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@faculty_id", faculty_id)
                cmd.Parameters.AddWithValue("@firstname", firstname)
                cmd.Parameters.AddWithValue("@middlename", middlename)
                cmd.Parameters.AddWithValue("@lastname", lastname)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                is_added = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                    str = "SELECT * FROM students"
                ElseIf cmbSearchStudent.SelectedIndex = 1 Then
                    str = "SELECT * FROM students WHERE student_id = '" + txtSearchStudent.Text + "'"
                ElseIf cmbSearchStudent.SelectedIndex = 2 Then
                    str = "SELECT * FROM students WHERE lastname LIKE '%" + txtSearchStudent.Text + "%'"
                ElseIf cmbSearchStudent.SelectedIndex = 3 Then
                    str = "SELECT * FROM students WHERE firstname LIKE '%" + txtSearchStudent.Text + "%'"
                ElseIf cmbSearchStudent.SelectedIndex = 4 Then
                    str = "SELECT * WHERE middlename LIKE '%" + txtSearchStudent.Text + "%'"
                ElseIf cmbSearchStudent.SelectedIndex = 5 Then
                    str = "SELECT * FROM students WHERE major LIKE '%" + txtSearchStudent.Text + "%'"
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
        If cmbSearchStudent.SelectedIndex = 0 Then
            FillGridViewStudent()
            txtSearchStudent.Clear()
        End If
    End Sub

    Private Sub txtSearchFaculty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchFaculty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbSearchFaculty.SelectedIndex = 0 Then
                str = "SELECT * FROM faculties"
            ElseIf cmbSearchFaculty.SelectedIndex = 1 Then
                str = "SELECT * FROM faculties WHERE faculty_id = '" + txtSearchFaculty.Text + "'"
            ElseIf cmbSearchFaculty.SelectedIndex = 2 Then
                str = "SELECT * FROM faculties WHERE lastname LIKE '%" + txtSearchFaculty.Text + "%'"
            ElseIf cmbSearchFaculty.SelectedIndex = 3 Then
                str = "SELECT * FROM faculties WHERE firstname LIKE '%" + txtSearchFaculty.Text + "%'"
            ElseIf cmbSearchFaculty.SelectedIndex = 4 Then
                str = "SELECT * FROM faculties WHERE middlename LIKE '%" + txtSearchFaculty.Text + "%'"
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
        If cmbSearchFaculty.SelectedIndex = 0 Then
            FillGridViewFaculty()
            txtSearchFaculty.Clear()
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TerminateProcess(app_exe As String)
        Dim Process As Object
        For Each Process In GetObject("winmgmts:").ExecQuery("SELECT * FROM Win32_Process WHERE Name = '" & app_exe & "'")
            Process.Terminate
        Next
    End Sub
End Class
