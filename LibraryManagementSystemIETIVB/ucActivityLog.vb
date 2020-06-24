Imports System.Data.SqlClient

Public Class ucActivityLog

    Private Sub ucActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LogInOutHistory()
        ActivityLog()
        cmbFilterBy.SelectedIndex = 0
    End Sub

    Friend Sub LogInOutHistory()
        Try
            dgvLoginout.Rows.Clear()
            str = "SELECT log_in_out.id, log_in_out.user_id, log_in_out.datee, log_in_out.login, log_in_out.logout, users.firstname + ' ' + users.middlename + ' ' + users.lastname AS Name FROM log_in_out INNER JOIN users ON log_in_out.user_id = users.user_id ORDER BY log_in_out.id DESC"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader
            While (dr.Read())
                If IsDBNull(dr("Logout")) Then
                    dgvLoginout.Rows.Add(dr("id"), dr("user_id"), dr("Name"), CDate(dr("datee")).ToShortDateString(), CDate(dr("login")).ToString("hh:mm tt"), "-")
                Else
                    dgvLoginout.Rows.Add(dr("id"), dr("user_id"), dr("Name"), CDate(dr("datee")).ToShortDateString(), CDate(dr("login")).ToString("hh:mm tt"), CDate(dr("logout")).ToString("hh:mm tt"))
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Friend Sub ActivityLog()
        Try
            str = "SELECT * FROM activity_log WHERE datee = '" + DateTime.Now + "'"
            cmd = New SqlClient.SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvActivityLog.Rows.Clear()

            While dr.Read
                dgvActivityLog.Rows.Add(dr("id"), dr("user_id"), dr("activities"), CDate(dr("datee")).ToShortDateString(), dr("time"), dr("filter"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridViewWithFilter()
        If cmbFilterBy.SelectedIndex = 0 Then
            str = "SELECT * FROM activity_log WHERE datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 1 Then
            str = "SELECT * FROM activity_log WHERE filter = 'User Management' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 2 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Borrower Management' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 3 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Book Entry' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 4 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Issued & Return' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 5 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Attendance Report' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 6 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Books Inventory Report' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 7 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Borrowed Books Report' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 8 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Faculty Master List Report' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 9 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Student Master List Report' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        ElseIf cmbFilterBy.SelectedIndex = 10 Then
            str = "SELECT * FROM activity_log WHERE filter = 'Penalty List Report' AND datee = '" + dtDate.Value + "' ORDER BY id DESC"
        End If
        Try
            cmd = New SqlClient.SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvActivityLog.Rows.Clear()

            While dr.Read
                dgvActivityLog.Rows.Add(dr("id"), dr("user_id"), dr("activities"), CDate(dr("datee")).ToShortDateString(), dr("time"), dr("filter"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbFilterBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterBy.SelectedIndexChanged
        GridViewWithFilter()
    End Sub

    Private Sub dtDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        GridViewWithFilter()
    End Sub
End Class
