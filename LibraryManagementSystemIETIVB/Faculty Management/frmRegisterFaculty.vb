Imports System.Data.SqlClient

Public Class frmRegisterFaculty
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFacultyID.Text.Length > 0 And txtFirstname.Text.Length > 0 And txtLastname.Text.Length > 0 Then
            If Val(txtAge.Text) >= 18 Then
                Dim ask As String = MessageBox.Show("Are you sure you want to Register?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ask = DialogResult.Yes Then
                    Try
                        str = "INSERT INTO faculties (faculty_id,firstname,middlename,lastname,gender,birthday) VALUES (@student_id,@firstname,@middlename,@lastname,@gender,@birthday)"
                        cmd = New SqlCommand(str, conn)
                        cmd.Parameters.AddWithValue("@faculty_id", txtFacultyID.Text)
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                        cmd.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text)
                        cmd.Parameters.AddWithValue("@birthday", dtBday.Value)
                        cmd.ExecuteNonQuery()


                        CustomMessageBox.ShowDialog(Me, "Record successfully added!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                        ClearAll()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Else
                MessageBox.Show("You age must be atleast 18 and above", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ClearAll()
        txtAge.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtMiddlename.Clear()
        cmbGender.SelectedIndex = 0
        dtBday.Value = Date.Now
    End Sub

End Class