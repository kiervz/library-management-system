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

    Private Sub ucBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        CheckForIllegalCrossThreadCalls = False
        MetroTabControl1.SelectedIndex = 0
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
                If Not IfAlreadyExistInDBStudent(xlRange.Cells(xlRow, 1).Text()) = True Then
                    rowcount += 1
                    'The student information will add
                    AddToDatabaseStudent(xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 6).Text(), xlRange.Cells(xlRow, 7).Text())
                    txtImportingS.Text = "Importing " & rowcount & " records"
                    txtPleasewaitS.Text = "please wait..."
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
        txtImporting.Text = "Importing 0 records"
        Dim rowcount As Integer = 0

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
            If Not IfAlreadyExistInDBFaculty(xlRangeF.Cells(xlRowF, 1).Text()) = True Then
                rowcount += 1
                'The faculty information will add
                AddToDatabaseFaculty(xlRangeF.Cells(xlRowF, 1).Text(), xlRangeF.Cells(xlRowF, 2).Text(), xlRangeF.Cells(xlRowF, 3).Text(), xlRangeF.Cells(xlRowF, 4).Text(), xlRangeF.Cells(xlRowF, 5).Text(), xlRangeF.Cells(xlRowF, 6).Text())
                txtImporting.Text = "Importing " & rowcount & " records"
                txtPleasewait.Text = "please wait..."
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
            txtSearchStudent.BringToFront()
        Else
            btnAddFaculty.BringToFront()
            btnImportFaculties.BringToFront()

            'Show Faculty Search Box
            cmbSearchFaculty.BringToFront()
            txtSearchFaculty.BringToFront()
        End If
    End Sub

    Private Function IfAlreadyExistInDBFaculty(facultyID As String)
        Dim isAlreadyExist As Boolean = False
        Try
            str = "SELECT faculty_id FROM faculties WHERE faculty_id = '" + facultyID + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                If dr.Read Then
                    isAlreadyExist = True
                Else
                    isAlreadyExist = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
        Return isAlreadyExist
    End Function

    Private Function IfAlreadyExistInDBStudent(studID As String)
        Dim isAlreadyExist As Boolean = False
        Try
            str = "SELECT student_id FROM students WHERE student_id = '" + studID + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                If dr.Read Then
                    isAlreadyExist = True
                Else
                    isAlreadyExist = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
        Return isAlreadyExist
    End Function

    Private Sub AddToDatabaseStudent(studID As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As String, major As String)
        Try
            If Not studID = "" Or firstname = "" Or lastname = "" Or gender = "" Or birthday = "" Or major = "" Then
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddToDatabaseFaculty(faculty_id As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As String)
        Try
            If Not faculty_id = "" Or firstname = "" Or lastname = "" Or gender = "" Or birthday = "" Then
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
