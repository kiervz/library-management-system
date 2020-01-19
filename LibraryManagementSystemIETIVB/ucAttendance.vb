Imports System.Data.SqlClient

Public Class ucAttendance

    Dim pagingAdapter As SqlDataAdapter
    Dim pagingDS As DataSet
    Dim scrollVal As Integer
    Dim rowCounnt As Integer
    Dim totalPages As Integer
    Dim currentPage As Integer = 1

    Private Sub ucAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        FillGridView()
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

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If rowCounnt > 0 Then
            scrollVal = scrollVal - 50
            If scrollVal <= 0 Then
                scrollVal = 0
            End If

            If currentPage > 1 Then
                currentPage -= 1
                txtCurrentPage.Text = "Page " + CStr(currentPage)
            End If
            If currentPage = totalPages Then
                btnNext.Enabled = False
                Exit Sub
            Else
                btnNext.Enabled = True
            End If
            pagingDS.Clear()
            pagingAdapter.Fill(pagingDS, scrollVal, 50, "attendance_table")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rowCounnt > 0 Then
            scrollVal = scrollVal + 50
            If scrollVal >= rowCounnt Then
                scrollVal = rowCounnt - 50
            End If
            If currentPage < totalPages Then
                currentPage += 1
                txtCurrentPage.Text = "Page " + CStr(currentPage)
            End If
            If currentPage = totalPages Then
                btnNext.Enabled = False
                Exit Sub
            Else
                btnNext.Enabled = True
            End If
            pagingDS.Clear()
            pagingAdapter.Fill(pagingDS, scrollVal, 50, "attendance_table")
        End If
    End Sub

    Friend Sub FillGridView()
        Try
            str = "SELECT COUNT(*) AS totalrow FROM attendance"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                rowCounnt = dr("totalrow")
                totalPages = Math.Ceiling(rowCounnt / 50)
                lblPages.Text = "Total Pages " + CStr(totalPages)
                lblShowingNentries.Text = "Showing 1 to " + CStr(50) + " of " + CStr(rowCounnt) + " entries"
            End If
            dr.Close()
            cmd.Dispose()

            str = "SELECT * FROM attendance WHERE date = '" + dtBday.Value + "' ORDER BY time_out ASC"
            pagingAdapter = New SqlDataAdapter(str, conn)
            pagingDS = New DataSet
            pagingAdapter.Fill(pagingDS, scrollVal, 50, "attendance_table")

            dgvAttendance.DataSource = pagingDS
            dgvAttendance.DataMember = "attendance_table"
            dgvAttendance.Columns(0).Width = 80
            dgvAttendance.Columns(1).Width = 95
            dgvAttendance.Columns(2).Width = 180
            dgvAttendance.Columns(3).Width = 180
            dgvAttendance.Columns(4).Width = 180
            dgvAttendance.Columns(5).Width = 90
            dgvAttendance.Columns(1).HeaderText = "ID No"

            dgvAttendance.Columns(0).Visible = False
            dgvAttendance.Columns(9).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "pagination")
        End Try
    End Sub

    Private Sub dtBday_ValueChanged(sender As Object, e As EventArgs) Handles dtBday.ValueChanged
        FillGridView()
    End Sub

End Class