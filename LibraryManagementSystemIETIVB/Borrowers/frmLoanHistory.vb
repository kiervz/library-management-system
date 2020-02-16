Imports System.Data.SqlClient

Public Class frmLoanHistory

    Friend borrower_name As String
    Friend id_no As String

    Private Sub frmLoanHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBorrowerName.Text = borrower_name
        Try
            Dim rowCount As Integer = 0
            str = "SELECT borrows.student_faculty_no, books.call_number, books.title, books.author, borrows.date_borrowed, borrows.status FROM borrows INNER JOIN books ON borrows.book_id = books.id WHERE borrows.student_faculty_no = '" + CStr(id_no) + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvLoanHistory.Rows.Clear()

            While dr.Read
                rowCount += 1
                dgvLoanHistory.Rows.Add(rowCount, dr("call_number"), dr("title"), dr("author"), CDate(dr("date_borrowed")).ToShortDateString(), dr("status"))
            End While

            If dgvLoanHistory.Rows.Count = 0 Then
                panelNoRecord.Visible = True
            Else
                panelNoRecord.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub
End Class