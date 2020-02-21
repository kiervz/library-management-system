Imports System.Data.SqlClient

Public Class frmRegisterStudent

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtStudentID.Text.Length > 0 And txtFirstname.Text.Length > 0 And txtLastname.Text.Length > 0 And txtMajor.Text.Length > 0 Then
            If Val(txtAge.Text) >= 10 Then
                CustomMessageBox.ShowDialog(Me, "Are you sure you want to Register?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

                If msgBoxButtonClick = DialogResult.Yes Then
                    Try
                        str = "INSERT INTO students (student_id,firstname,middlename,lastname,gender,birthday,major) VALUES (@student_id,@firstname,@middlename,@lastname,@gender,@birthday,@major)"
                        cmd = New SqlCommand(str, conn)
                        cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                        cmd.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text)
                        cmd.Parameters.AddWithValue("@birthday", dtBday.Value)
                        cmd.Parameters.AddWithValue("@major", txtMajor.Text)
                        cmd.ExecuteNonQuery()

                        is_reload = True

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
        txtAge.Text = ""
        txtMajor.Text = ""
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtMiddlename.Text = ""
        txtMajor.Text = ""
        txtStudentID.Text = ""
        cmbGender.SelectedIndex = 0
        dtBday.Value = Date.Now
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

    Private Sub dtBday_ValueChanged(sender As Object, e As EventArgs) Handles dtBday.ValueChanged
        GetCurrentAge(dtBday.Value)
    End Sub

    Private Sub frmRegisterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
    End Sub
End Class