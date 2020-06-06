Imports System.Data.SqlClient

Public Class frmRegisterFaculty

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFacultyID.Text.Length > 0 And txtFirstname.Text.Length > 0 And txtLastname.Text.Length > 0 Then
            If Val(txtAge.Text) >= 18 Then
                Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Register?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

                If mes = DialogResult.Yes Then
                    Try
                        str = "INSERT INTO faculties (faculty_id,firstname,middlename,lastname,gender,birthday,phone) VALUES (@faculty_id,@firstname,@middlename,@lastname,@gender,@birthday,@phone)"
                        cmd = New SqlCommand(str, conn)
                        cmd.Parameters.AddWithValue("@faculty_id", txtFacultyID.Text)
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)

                        If txtMiddlename.Text.Length > 0 Then
                            cmd.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                        Else
                            cmd.Parameters.AddWithValue("@middlename", "")
                        End If

                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)

                        If rbMale.Checked Then cmd.Parameters.AddWithValue("@gender", "Male")
                        If rbFemale.Checked Then cmd.Parameters.AddWithValue("@gender", "Female")

                        cmd.Parameters.AddWithValue("@birthday", dtBday.Value)
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                        cmd.ExecuteNonQuery()

                        is_reload = True

                        Msg(Me, "Record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ClearAll()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Else
                Msg(Me, "You age must be atleast 18 and above", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Msg(Me, "Please fill up all fields!", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ClearAll()
        txtFacultyID.Clear()
        txtAge.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtMiddlename.Clear()
        rbMale.Checked = True
        txtPhone.Clear()
        dtBday.Value = Date.Now
        txtAge.Clear()
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

    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddlename.KeyPress, txtLastname.KeyPress, txtFirstname.KeyPress
        KeyPressLetterOnly(e)
    End Sub

    Private Sub frmRegisterFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        rbMale.Checked = True
    End Sub
End Class