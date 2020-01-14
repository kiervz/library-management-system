Imports System.Data.SqlClient

Public Class ucAttendance
    Private Sub ucAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        GridView()
        Timer1.Start()
    End Sub

    Public Sub GridView()
        Try
            Dim rowcount As Integer = 0
            str = "SELECT * FROM attendance WHERE date = '" + Date.Now + "' OR is_time_out = '0' ORDER BY id DESC"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvAttendance.Rows.Clear()

            While dr.Read()
                rowcount += 1
                If IsDBNull(dr("time_out")) Then
                    dgvAttendance.Rows.Add(rowcount, dr("id_no"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), dr("type"), CDate(dr("date")).ToShortDateString(), CDate(dr("time_in")).ToShortTimeString(), "-")
                Else
                    dgvAttendance.Rows.Add(rowcount, dr("id_no"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), dr("type"), CDate(dr("date")).ToShortDateString(), CDate(dr("time_in")).ToShortTimeString(), CDate(dr("time_out")).ToShortTimeString())
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CheckDataIfUpdated()
        Try
            Dim get_updated_date As DateTime
            str = "SELECT time_updated_at FROM data_updated WHERE id = '1'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                get_updated_date = dr("time_updated_at")
                If get_updated_date > My.Settings.data_updated_at Then

                    My.Settings.data_updated_at = get_updated_date
                    My.Settings.Save()
                    My.Settings.Reload()

                    GridView()

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckDataIfUpdated()
    End Sub
End Class
