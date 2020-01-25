Imports System.Data.SqlClient

Public Class frmRegisterStudent

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtStudentID.Text.Length > 0 And txtFirstname.Text.Length > 0 And txtLastname.Text.Length > 0 And txtSection.Text.Length > 0 And txtCourse.Text.Length > 0 Then
            If Val(txtAge.Text) >= 10 Then
                Dim ask As String = MessageBox.Show("Are you sure you want to Register?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ask = DialogResult.Yes Then
                    Try
                        str = "INSERT INTO students (student_id,firstname,middlename,lastname,gender,birthday,course,year,section) VALUES (@student_id,@firstname,@middlename,@lastname,@gender,@birthday,@course,@year,@section)"
                        cmd = New SqlCommand(str, conn)
                        cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                        cmd.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text)
                        cmd.Parameters.AddWithValue("@birthday", dtBday.Value)
                        cmd.Parameters.AddWithValue("@course", txtCourse.Text)
                        cmd.Parameters.AddWithValue("@year", cmbYear.Text)
                        cmd.Parameters.AddWithValue("@section", txtSection.Text)
                        cmd.ExecuteNonQuery()

                        CustomMessageBox.ShowDialog(Me, "Record successfully added!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                        ClearAll()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Else
                MessageBox.Show("You age must be atleast 10 and above", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ClearAll()
        txtAge.Clear()
        txtCourse.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtMiddlename.Clear()
        txtSection.Clear()
        txtStudentID.Clear()
        cmbGender.SelectedIndex = 0
        dtBday.Value = Date.Now
    End Sub

    Private Sub dtBday_ValueChanged(sender As Object, e As EventArgs) Handles dtBday.ValueChanged
        GetCurrentAge(dtBday.Value)
    End Sub
    Private Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year

        If dob > Today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age
        Return age
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub
End Class