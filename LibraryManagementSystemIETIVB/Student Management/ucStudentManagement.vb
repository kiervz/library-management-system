Imports Microsoft.Office.Interop

Public Class ucStudentManagement

    'to install office.interlop
    'Install-Package Microsoft.Office.Interop.Excel

    Dim thread As System.Threading.Thread
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
            thread = New System.Threading.Thread(AddressOf LoadData)
            Panel1.Show()
            thread.Start()
        End If
    End Sub

    Private Sub ucStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Panel1.Hide()
    End Sub

    Private Sub LoadData()
        Dim rowcount As Integer = 0
        For Me.xlRow = 1 To xlRange.Rows.Count
            'If xlRange.Cells(xlRow, 1).text <> String.Empty And xlRange.Cells(xlRow, 2) <> String.Empty And xlRange.Cells(xlRow, 3) <> String.Empty And xlRange.Cells(xlRow, 4) <> String.Empty And xlRange.Cells(xlRow, 5) <> String.Empty And xlRange.Cells(xlRow, 6) <> String.Empty And xlRange.Cells(xlRow, 7) <> String.Empty And xlRange.Cells(xlRow, 8) <> String.Empty Then
            If xlRange.Cells(xlRow, 1).Text <> String.Empty Then
                rowcount += 1
                dgvStudents.Rows.Add(rowcount, xlRange.Cells(xlRow, 1).Text(), xlRange.Cells(xlRow, 2).Text(), xlRange.Cells(xlRow, 3).Text(), xlRange.Cells(xlRow, 4).Text(), xlRange.Cells(xlRow, 5).Text(), xlRange.Cells(xlRow, 6).Text(), xlRange.Cells(xlRow, 7).Text(), xlRange.Cells(xlRow, 8).Text(), xlRange.Cells(xlRow, 9).Text())
                txtImporting.Text = "Importing " & rowcount & " records"
                txtPleasewait.Text = "please wait..."
            End If
        Next
        xlWorkBook.Close()
        xlApp.Quit()
        Panel1.Hide()
        dgvStudents.Refresh()
    End Sub


End Class
