Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class ucStudentManagement

    'to install office.interlop
    'Install-Package Microsoft.Office.Interop.Excel
    Dim thread As Threading.Thread
    Dim iCount, i As Integer

    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlRange As Excel.Range
    Dim xlRow As Integer
    Dim strDestination As String

    Dim rowCounnt As Integer

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
                thread = New Threading.Thread(AddressOf LoadData)
                Panel1.Show()
                thread.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ucStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        CheckForIllegalCrossThreadCalls = False
        Panel1.Hide()
    End Sub

    Private Sub LoadData()
        Try
            txtImporting.Text = "Importing 0 records"
            Dim rowcount As Integer = 0

            For xlRow = 1 To xlRange.Rows.Count
                If xlRange.Cells(xlRow, 1).Text <> String.Empty Then
                    'If not already in the database 
                    If Not IfAlreadyExistInDB(xlRange.Cells(xlRow, 1).Text()) = True Then
                        isStudentsImporting = True
                        rowcount += 1
                        'The student information will add
                        AddToDatabase(xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 6).Text(), xlRange.Cells(xlRow, 7).Text(), xlRange.Cells(xlRow, 8).Text(), xlRange.Cells(xlRow, 9).Text())
                        txtImporting.Text = "Importing " & rowcount & " records"
                        txtPleasewait.Text = "please wait..."
                    End If
                End If
            Next

            xlWorkBook.Close()
            xlApp.Quit()
            Panel1.Hide()
            FillGridView()
            thread.Abort()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Friend Sub FillGridView()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            str = "SELECT COUNT(*) AS totalrow FROM students"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                rowCounnt = dr("totalrow")
                lblShowingNentries.Text = "Total Students Registered: " + CStr(rowCounnt)
            End If
            dr.Close()
            cmd.Dispose()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            str = "SELECT student_id, firstname, middlename, lastname, gender, course, year, section FROM students"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvStudents.Rows.Clear()

            While dr.Read
                dgvStudents.Rows.Add(dr("student_id"), dr("firstname"), dr("middlename"), dr("lastname"), dr("gender"), dr("course"), dr("year"), dr("section"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Function IfAlreadyExistInDB(studID As String)
        Dim isAlreadyExist As Boolean = False
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            str = "SELECT student_id FROM students WHERE student_id = '" + studID + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                isAlreadyExist = True
            Else
                isAlreadyExist = False
            End If
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return isAlreadyExist
    End Function

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        OpenTransparentForm(Me)
        Dim add_student As New frmRegisterStudent
        add_student.ShowDialog(Me)
    End Sub

    Private Sub AddToDatabase(studID As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As String, course As String, year As String, section As String)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            If Not studID = "" Or firstname = "" Or lastname = "" Or gender = "" Or birthday = "" Or course = "" Or year = "" Or year Then
                str = "INSERT INTO students (student_id,firstname,middlename,lastname,gender,birthday,course,year,section) VALUES (@student_id,@firstname,@middlename,@lastname,@gender,@birthday,@course,@year,@section)"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@student_id", studID)
                cmd.Parameters.AddWithValue("@firstname", firstname)
                cmd.Parameters.AddWithValue("@middlename", middlename)
                cmd.Parameters.AddWithValue("@lastname", lastname)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@birthday", CDate(birthday).ToShortDateString())
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@year", year)
                cmd.Parameters.AddWithValue("@section", section)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
