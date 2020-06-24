Imports System.Data.SqlClient

Public Class frmRegisterFaculty

    Friend faculty_id As String
    Friend is_update As Boolean = False

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegisterSave.Click
        If txtFacultyID.Text.Length > 0 And txtFirstname.Text.Length > 0 And txtLastname.Text.Length > 0 Then
            If is_update Then
                str = "SELECT * FROM faculties WHERE firstname=@fn AND middlename=@mn AND lastname=@ln AND birthday=@bday AND faculty_id <> '" + CStr(faculty_id) + "'"
                cmd = New SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@fn", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@mn", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@ln", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@bday", CDate(dtBday.Value).ToShortDateString())
                dr = cmd.ExecuteReader

                If dr.Read Then
                    Msg(Me, "Faculty is already exist", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                cmd.Dispose()
                dr.Close()

                If Val(txtAge.Text) >= 18 Then
                    Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

                    If mes = DialogResult.Yes Then
                        Try
                            str = "UPDATE faculties SET firstname=@fn, middlename=@mn, lastname=@ln, gender=@gender, birthday=@bday, phone=@phone WHERE faculty_id = '" + CStr(faculty_id) + "'"
                            cmd = New SqlCommand(str, conn)
                            cmd.Parameters.AddWithValue("@fn", txtFirstname.Text)
                            If txtMiddlename.Text.Length > 0 Then
                                cmd.Parameters.AddWithValue("@mn", txtMiddlename.Text)
                            Else
                                cmd.Parameters.AddWithValue("@mn", "")
                            End If
                            cmd.Parameters.AddWithValue("@ln", txtLastname.Text)
                            If rbMale.Checked Then cmd.Parameters.AddWithValue("@gender", "Male")
                            If rbFemale.Checked Then cmd.Parameters.AddWithValue("@gender", "Female")
                            cmd.Parameters.AddWithValue("@bday", CDate(dtBday.Value).ToShortDateString())
                            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                            cmd.ExecuteNonQuery()

                            is_reload = True

                            AN_ActivityLog() 'Auto Number for activity log
                            RecordActivities(userID, "Update faculty account. Updated: " + txtFacultyID.Text, "Borrower Management") 'Activity

                            Msg(Me, "Record successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Hide()
                            CloseTransparentForm()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                End If
            Else
                If Val(txtAge.Text) >= 18 Then
                    str = "SELECT * FROM faculties WHERE faculty_id = @faculty_id"
                    cmd = New SqlCommand(str, conn)
                    cmd.Parameters.AddWithValue("@faculty_id", txtFacultyID.Text)
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        Msg(Me, "Faculty ID is already exist", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    cmd.Dispose()
                    dr.Close()

                    Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Register?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

                    If mes = DialogResult.Yes Then
                        Try
                            str = "INSERT INTO faculties (faculty_id,firstname,middlename,lastname,gender,birthday,phone,status_id) VALUES (@faculty_id,@firstname,@middlename,@lastname,@gender,@birthday,@phone,@status_id)"
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
                            cmd.Parameters.AddWithValue("@status_id", "1")
                            cmd.ExecuteNonQuery()

                            is_reload = True

                            AN_ActivityLog() 'Auto Number for activity log
                            RecordActivities(userID, "Add new faculty account. Added: " + txtFacultyID.Text, "Borrower Management") 'Activity

                            Msg(Me, "Record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ClearAll()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                Else
                    Msg(Me, "You age must be atleast 18 and above", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
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
        If is_update Then
            btnRegisterSave.Text = "UPDATE"
            Try
                str = "SELECT * FROM faculties WHERE faculty_id = '" + CStr(faculty_id) + "'"
                cmd = New SqlCommand(str, conn)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txtFacultyID.Text = faculty_id
                    txtFacultyID.Enabled = False
                    txtFirstname.Text = dr("firstname")
                    txtMiddlename.Text = dr("middlename")
                    txtLastname.Text = dr("lastname")

                    If "Male" = dr("gender").ToString() Then
                        rbMale.Checked = True
                    Else
                        rbFemale.Checked = True
                    End If

                    dtBday.Value = CDate(dr("birthday")).ToShortDateString()
                    txtPhone.Text = dr("phone")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            btnRegisterSave.Text = "REGISTER"
            txtFacultyID.Enabled = True
            rbMale.Checked = True
        End If

    End Sub
End Class