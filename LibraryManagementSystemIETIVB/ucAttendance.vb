Imports System.Data.SqlClient

Public Class ucAttendance
    Private Sub ucAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        GridView()
    End Sub

    Public Sub GridView()
        Try
            Dim rowcount As Integer = 0
            str = "SELECT attendance.id, attendance.id_no, students.firstname, students.middlename, students.lastname, attendance.date, attendance.time_in, attendance.time_out FROM attendance INNER JOIN students ON attendance.id_no = students.student_id WHERE is_time_out = '0' ORDER BY id DESC"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvAttendance.Rows.Clear()

            While dr.Read()
                rowcount += 1
                If IsDBNull(dr("time_out")) Then
                    dgvAttendance.Rows.Add(rowcount, dr("id_no"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), CDate(dr("date")).ToShortDateString(), CDate(dr("time_in")).ToShortTimeString(), "-")
                Else
                    dgvAttendance.Rows.Add(rowcount, dr("id_no"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), CDate(dr("date")).ToShortDateString(), CDate(dr("time_in")).ToShortTimeString(), CDate(dr("time_out")).ToShortTimeString())
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
