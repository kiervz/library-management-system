Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class ucFacultyManagement

    Dim thread As Threading.Thread
    Dim iCount, i As Integer

    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlRange As Excel.Range
    Dim xlRow As Integer
    Dim strDestination As String

    Dim pagingAdapter As SqlDataAdapter
    Dim pagingDS As DataSet
    Dim scrollVal As Integer
    Dim rowCounnt As Integer
    Dim totalPages As Integer
    Dim currentPage As Integer = 1


    Private Sub btnImportFaculties_Click(sender As Object, e As EventArgs) Handles btnImportFaculties.Click
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

    Private Sub ucFacultyManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        'cmbEntries.SelectedIndex = 0
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
                    'The faculty information will add
                    AddToDatabase(xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 6).Text())
                    dgvFaculties.Refresh()
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

    Private Function IfAlreadyExistInDB(facultyID As String)
        Dim isAlreadyExist As Boolean = False
        Try
            str = "SELECT faculty_id FROM faculties WHERE faculty_id = '" + facultyID + "'"
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

    Private Sub AddToDatabase(faculty_id As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As Date)
        Try
            str = "INSERT INTO faculties (faculty_id,firstname,middlename,lastname,gender,birthday) VALUES (@faculty_id,@firstname,@middlename,@lastname,@gender,@birthday)"
            cmd = New SqlCommand(str, conn)
            cmd.Parameters.AddWithValue("@faculty_id", faculty_id)
            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@middlename", middlename)
            cmd.Parameters.AddWithValue("@lastname", lastname)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@birthday", birthday)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddFaculty_Click(sender As Object, e As EventArgs) Handles btnAddFaculty.Click
        OpenTransparentForm(Me)
        Dim add_faculty As New frmRegisterFaculty
        add_faculty.ShowDialog(Me)
        FillGridView()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If rowCounnt > 0 Then
            scrollVal = scrollVal - 50
            If scrollVal <= 0 Then
                scrollVal = 0
            End If

            If currentPage > 1 Then
                currentPage -= 1
                txtCurrentPage.Text = "Page " + CStr(currentPage)
            End If
            If currentPage = totalPages Then
                btnNext.Enabled = False
                Exit Sub
            Else
                btnNext.Enabled = True
            End If
            pagingDS.Clear()
            pagingAdapter.Fill(pagingDS, scrollVal, 50, "faculties_table")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rowCounnt > 0 Then
            scrollVal = scrollVal + 50
            If scrollVal >= rowCounnt Then
                scrollVal = rowCounnt - 50
            End If
            If currentPage < totalPages Then
                currentPage += 1
                txtCurrentPage.Text = "Page " + CStr(currentPage)
            End If
            If currentPage = totalPages Then
                btnNext.Enabled = False
                Exit Sub
            Else
                btnNext.Enabled = True
            End If
            pagingDS.Clear()
            pagingAdapter.Fill(pagingDS, scrollVal, 50, "faculties_table")
        End If
    End Sub

    Friend Sub FillGridView()
        Try
            str = "SELECT COUNT(*) AS totalrow FROM faculties"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                rowCounnt = dr("totalrow")
                totalPages = Math.Ceiling(rowCounnt / 50)
                lblPages.Text = "Total Pages " + CStr(totalPages)
                lblShowingNentries.Text = "Showing 1 to " + CStr(50) + " of " + CStr(rowCounnt) + " entries"
            End If
            dr.Close()
            cmd.Dispose()

            str = "SELECT * FROM faculties"
            pagingAdapter = New SqlDataAdapter(str, conn)
            pagingDS = New DataSet()
            pagingAdapter.Fill(pagingDS, scrollVal, 50, "faculties_table")

            dgvFaculties.DataSource = pagingDS
            dgvFaculties.DataMember = "faculties_table"
            dgvFaculties.Columns(0).Width = 110
            dgvFaculties.Columns(1).Width = 230
            dgvFaculties.Columns(2).Width = 230
            dgvFaculties.Columns(3).Width = 230
            dgvFaculties.Columns(4).Width = 110
            dgvFaculties.Columns(5).Width = 125
            dgvFaculties.Columns(0).HeaderText = "Faculty ID"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "POTAAA")
        End Try
    End Sub

End Class
