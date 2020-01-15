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

    Private Sub btnImportStudent_Click(sender As Object, e As EventArgs) Handles btnImportStudent.Click
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
    End Sub

    Private Sub ucStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        FillGridView()
        CheckForIllegalCrossThreadCalls = False
        Panel1.Hide()
    End Sub

    Private Sub LoadData()
        txtImporting.Text = "Importing 0 records"
        Dim rowcount As Integer = 0

        For xlRow = 1 To xlRange.Rows.Count
            If xlRange.Cells(xlRow, 1).Text <> String.Empty Then
                'If not already in the database 
                If Not IfAlreadyExistInDB(xlRange.Cells(xlRow, 1).Text()) = True Then
                    rowcount += 1
                    'The student information will add
                    AddToDatabase(xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 6).Text(), xlRange.Cells(xlRow, 7).Text(), xlRange.Cells(xlRow, 8).Text(), xlRange.Cells(xlRow, 9).Text())
                    dgvStudents.Rows.Add(rowcount, xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 7).Text(), xlRange.Cells(xlRow, 8).Text(), xlRange.Cells(xlRow, 9).Text())
                    dgvStudents.Refresh()
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
    End Sub

    Friend Sub FillGridView()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim rowcount As Integer = 0
            str = "SELECT * FROM students"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvStudents.Rows.Clear()

            While dr.Read
                rowcount += 1
                dgvStudents.Rows.Add(rowcount, dr("student_id"), dr("firstname"), dr("middlename"), dr("lastname"), dr("gender"), dr("course"), dr("year"), dr("section"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function IfAlreadyExistInDB(studID As String)
        Dim isAlreadyExist As Boolean = False
        Try
            str = "SELECT student_id FROM students WHERE student_id = '" + studID + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                isAlreadyExist = True
            Else
                isAlreadyExist = False
            End If
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

    Private Sub AddToDatabase(studID As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As Date, course As String, year As String, section As String)
        Try
            str = "INSERT INTO students (student_id,firstname,middlename,lastname,gender,birthday,course,year,section) VALUES (@student_id,@firstname,@middlename,@lastname,@gender,@birthday,@course,@year,@section)"
            cmd = New SqlCommand(str, conn)
            cmd.Parameters.AddWithValue("@student_id", studID)
            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@middlename", middlename)
            cmd.Parameters.AddWithValue("@lastname", lastname)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@birthday", birthday)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@section", section)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
