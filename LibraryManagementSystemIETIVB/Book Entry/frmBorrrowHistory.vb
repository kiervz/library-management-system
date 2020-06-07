Imports System.Data.SqlClient

Public Class frmBorrrowHistory

    Friend book_id As String

    Private Sub frmBorrrowHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim rowCount As Integer = 0
            str = "SELECT borrows.book_id, (SELECT firstname + ' ' + middlename + ' ' + lastname AS Name FROM students WHERE (student_id = borrows.student_faculty_no)) AS name_student, (SELECT firstname + ' ' + middlename + ' ' + lastname AS Name FROM faculties WHERE (faculty_id = borrows.student_faculty_no)) AS name_faculty, books.call_number, books.title, books.author, borrows.date_borrowed, borrows.status FROM borrows INNER JOIN books ON borrows.book_id = books.id WHERE (borrows.book_id = '" + CStr(book_id) + "')"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvBorrowHistory.Rows.Clear()

            While dr.Read
                rowCount += 1
                If Not IsDBNull(dr("name_student")) Then
                    dgvBorrowHistory.Rows.Add(rowCount, dr("book_id"), dr("name_student"), "Student", dr("call_number"), dr("title"), dr("author"), CDate(dr("date_borrowed")).ToShortDateString(), dr("status"))
                Else
                    dgvBorrowHistory.Rows.Add(rowCount, dr("book_id"), dr("name_faculty"), "Faculty", dr("call_number"), dr("title"), dr("author"), CDate(dr("date_borrowed")).ToShortDateString(), dr("status"))
                End If
            End While

            If dgvBorrowHistory.Rows.Count = 0 Then
                panelNoRecord.Visible = True
            Else
                panelNoRecord.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub

End Class