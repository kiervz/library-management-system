Imports System.Data.SqlClient

Public Class frmRegisterStudent

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtStudentID.Text.Length > 0 And txtFirstname.Text.Length > 0 And txtLastname.Text.Length > 0 And txtMajor.Text.Length > 0 Then
            Try
                str = "SELECT * FROM students WHERE student_id = @student_id"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    Msg(Me, "Student is already exist", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                str = "SELECT * FROM students WHERE firstname = @fn AND middlename = @mn AND lastname = @ln AND birthday = @bday"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@fn", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@mn", txtMiddlename.Text)
                cmd.Parameters.AddWithValue("@ln", txtLastname.Text)
                cmd.Parameters.AddWithValue("@bday", dtBday.Value.ToShortDateString())
                dr = cmd.ExecuteReader

                If dr.Read Then
                    Msg(Me, "Student is already exist", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If Val(txtAge.Text) >= 10 Then
                    Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Register?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If mes = DialogResult.Yes Then
                        str = "INSERT INTO students (student_id,firstname,middlename,lastname,gender,birthday,major,phone) VALUES (@student_id,@firstname,@middlename,@lastname,@gender,@birthday,@major,@phone)"
                        cmd = New SqlCommand(str, conn)
                        cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                        cmd.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text)
                        cmd.Parameters.AddWithValue("@birthday", dtBday.Value)
                        cmd.Parameters.AddWithValue("@major", txtMajor.Text)
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                        cmd.ExecuteNonQuery()

                        is_reload = True

                        Msg(Me, "Record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearAll()
                    End If
                Else
                    Msg(Me, "You age must be atleast 10 and above", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ClearAll()
        txtAge.Clear()
        txtMajor.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtMiddlename.Clear()
        txtMajor.Clear()
        txtStudentID.Clear()
        txtPhone.Clear()
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

    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddlename.KeyPress, txtLastname.KeyPress, txtFirstname.KeyPress
        KeyPressLetterOnly(e)
    End Sub
End Class