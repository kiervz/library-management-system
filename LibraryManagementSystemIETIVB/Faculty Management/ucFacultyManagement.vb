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

    Dim rowCounnt As Integer

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
                    isFacultiesImporting = True
                    rowcount += 1
                    'The faculty information will add
                    AddToDatabase(xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 6).Text())
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
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
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

    Private Sub AddToDatabase(faculty_id As String, firstname As String, middlename As String, lastname As String, gender As String, birthday As String)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            If Not faculty_id = "" Or firstname = "" Or lastname = "" Or gender = "" Or birthday = "" Then
                str = "INSERT INTO faculties (faculty_id,firstname,middlename,lastname,gender,birthday) VALUES (@faculty_id,@firstname,@middlename,@lastname,@gender,@birthday)"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@faculty_id", faculty_id)
                cmd.Parameters.AddWithValue("@firstname", firstname)
                cmd.Parameters.AddWithValue("@middlename", middlename)
                cmd.Parameters.AddWithValue("@lastname", lastname)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.ExecuteNonQuery()
            End If
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

    Friend Sub FillGridView()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            str = "SELECT COUNT(*) AS totalrow FROM faculties"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                rowCounnt = dr("totalrow")
                lblShowingNentries.Text = "Showing 1 to " + CStr(50) + " of " + CStr(rowCounnt) + " entries"
            End If
            dr.Close()
            cmd.Dispose()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            str = "SELECT * FROM faculties"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvFaculties.Rows.Clear()

            While dr.Read
                dgvFaculties.Rows.Add(dr("faculty_id"), dr("firstname"), dr("middlename"), dr("lastname"), dr("gender"), CDate(dr("birthday")).ToShortDateString())
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Faculty Gridview")
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

End Class
