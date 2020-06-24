Imports System.Data.SqlClient

Public Class ucActivityLog
    Private Sub ucActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        LogInOutHistory()
    End Sub

    Private Sub LogInOutHistory()
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
End Class
