Imports System.Data.SqlClient

Public Class ucAttendance

    Dim rowCounnt As Integer

    Private Sub ucAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        Timer1.Start()
    End Sub

    Private Sub CheckDataIfUpdated()
        Try
            Dim get_updated_date As DateTime
            str = "SELECT time_updated_at FROM options WHERE id = '1'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                get_updated_date = dr("time_updated_at")
                If get_updated_date > My.Settings.data_updated_at Then

                    My.Settings.data_updated_at = get_updated_date.AddSeconds(2)
                    My.Settings.Save()
                    My.Settings.Reload()

                    FillGridView()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckDataIfUpdated()
    End Sub

    Friend Sub FillGridView()
        Try
            str = "SELECT COUNT(*) AS totalrow FROM attendance WHERE date = '" + dtDate.Value + "' "
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                rowCounnt = dr("totalrow")
                lblShowingNentries.Text = "Total Attendance Today: " + CStr(rowCounnt)
            End If
            dr.Close()
            cmd.Dispose()

            str = "SELECT id_no, firstname, middlename, lastname, type, date, time_in, time_out FROM attendance WHERE date = '" + dtDate.Value + "' ORDER BY time_out ASC"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvAttendance.Rows.Clear()

            While dr.Read
                If IsDBNull(dr("time_out")) Then
                    dgvAttendance.Rows.Add(dr("id_no"), dr("firstname"), dr("middlename"), dr("lastname"), dr("type"), CDate(dr("date")).ToShortDateString(), CDate(dr("time_in")).ToString("hh:mm tt"), "-")
                Else
                    dgvAttendance.Rows.Add(dr("id_no"), dr("firstname"), dr("middlename"), dr("lastname"), dr("type"), CDate(dr("date")).ToShortDateString(), CDate(dr("time_in")).ToString("hh:mm tt"), CDate(dr("time_out")).ToString("hh:mm tt"))
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Attendance")
        End Try
    End Sub

    Private Sub dtBday_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        FillGridView()
    End Sub

End Class