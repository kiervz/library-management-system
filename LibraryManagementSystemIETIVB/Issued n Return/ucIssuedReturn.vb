Imports System.Data.SqlClient

Public Class ucIssuedReturn

    Private Sub lookup_borrower(sender As Object, e As EventArgs) Handles pbBrowsePic.Click, lblLookUpBorrowers.Click
        Dim borrowers As New frmBorrowers
        OpenTransparentForm(Me)
        borrowers.ShowDialog(Me)

        If Not borrower_id = "" Then
            txtBorrowerID.Text = borrower_id
            SelectBorrower()
        End If
    End Sub

    Private Sub SelectBorrower()
        Try
            str = "SELECT * FROM students WHERE student_id = '" + borrower_id.ToString() + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                txtName.Text = dr("firstname") + " " + dr("middlename") + " " + dr("lastname")
                txtYearSec.Text = dr("year") + " " + dr("section")
                cmbType.Text = "Student"
            Else
                cmd.Dispose()
                dr.Close()

                str = "SELECT * FROM faculties WHERE faculty_id = '" + borrower_id.ToString() + "'"
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txtName.Text = dr("firstname") + " " + dr("middlename") + " " + dr("lastname")
                    txtYearSec.Text = "NONE"
                    cmbType.Text = "Faculty"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ucIssuedReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookAllowed.Text = My.Settings.no_books_allow
        txtDayAllowed.Text = My.Settings.no_days_allow
        txtPenaltyDay.Text = My.Settings.penalty_per_day
    End Sub

    Private Sub txtBorrowerID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBorrowerID.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectBorrower()
        End If
    End Sub

End Class
