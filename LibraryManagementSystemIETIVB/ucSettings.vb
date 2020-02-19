Imports System.Data.SqlClient

Public Class ucSettings

    Private _passScore As Integer = 0

    Private Sub ucSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNoBooksAllowed.Text = My.Settings.no_books_allow
        txtNoDaysAllowed.Text = My.Settings.no_days_allow
        txtPenaltyPerDay.Text = My.Settings.penalty_per_day
        'txtIdleTime.Text = My.Settings.IdleTime
        MetroTabControl1.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.no_books_allow = txtNoBooksAllowed.Text
        My.Settings.no_days_allow = txtNoDaysAllowed.Text
        My.Settings.penalty_per_day = txtPenaltyPerDay.Text
        'My.Settings.IdleTime = txtIdleTime.Text

        Try
            str = "UPDATE options SET grace_perion = @gp WHERE id = 1"
            cmd = New SqlCommand(str, conn)
            cmd.Parameters.AddWithValue("@gp", txtGracePeriod.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtConfirmpass.Text = "" Or txtNewpass.Text = "" Or txtOldpass.Text = "" Then
            MessageBox.Show("Please complete all fields.", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                str = "SELECT password FROM users WHERE user_id=@user_id"
                cmd = New SqlClient.SqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@user_id", userID)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    Dim userpass As String = dr("password")
                    If userpass <> MD5HasherSalt.GetMd5Hash(txtOldpass.Text) Then
                        CustomMessageBox.ShowDialog(Me, "Your old password is incorrect.", "Incorrect Password", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
                        MessageBox.Show("Your old password does not match.", "Does Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If txtNewpass.Text <> txtConfirmpass.Text Then
                            CustomMessageBox.ShowDialog(Me, "Your new password does not match.", "Password Requirements", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
                        ElseIf _passScore < 4 Then
                            CustomMessageBox.ShowDialog(Me, "Password you have entered did not meet the minimum requirements", "Password Requirements", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
                        Else
                            dr.Close()
                            cmd.Dispose()

                            str = "UPDATE users SET password = @password WHERE user_id = '" + userID + "'"
                            cmd = New SqlClient.SqlCommand(str, conn)
                            cmd.Parameters.AddWithValue("@password", MD5HasherSalt.GetMd5Hash(txtNewpass.Text))
                            cmd.ExecuteNonQuery()

                            MessageBox.Show("Password has been changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtConfirmpass.Text = ""
                            txtNewpass.Text = ""
                            txtOldpass.Text = ""
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 1)

        Dim passed As Integer = 0
        ' Uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        ' Lowercase letters.
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        ' Numbers
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special character.
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check if password is greater than or equal to 8
        If Len(pwd) >= minLength Then
            lbl8Characters.Visible = False
            passed += 1
        Else
            lbl8Characters.Visible = True
        End If
        ' Check if password has a uppercase letter.
        If upper.Matches(pwd).Count >= numUpper Then
            lblUpperCase.Visible = False
            passed += 1
        Else
            lblUpperCase.Visible = True
        End If

        ' Check if password has a number.
        If number.Matches(pwd).Count >= numNumbers Then
            lblNumber.Visible = False
            passed += 1
        Else
            lblNumber.Visible = True
        End If

        ' Check if password has a special character.
        If special.Matches(pwd).Count >= numSpecial Then
            lblSpecialCharacter.Visible = False
            passed += 1
        Else
            lblSpecialCharacter.Visible = True
        End If

        ' Passed all checks.
        _passScore = passed
        If _passScore = 4 Then
            pbCheck1.Image = My.Resources.check
        Else
            pbCheck1.Image = My.Resources.x
        End If
    End Sub

    Private Sub ValidatePasswordMatch()
        If txtNewpass.Text.Length > 0 Or txtConfirmpass.Text.Length > 0 Then
            pbCheck1.Visible = True
            pbCheck2.Visible = True
            If txtNewpass.Text = txtConfirmpass.Text Then
                pbCheck2.Image = My.Resources.check
            Else
                pbCheck2.Image = My.Resources.x
            End If
        Else
            pbCheck1.Visible = False
            pbCheck2.Visible = False
        End If
    End Sub

    Private Sub txtNewpass_TextChanged(sender As Object, e As EventArgs) Handles txtNewpass.TextChanged
        ValidatePasswordMatch()
        ValidatePassword(txtNewpass.Text)
    End Sub

    Private Sub txtConfirmpass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmpass.TextChanged
        ValidatePasswordMatch()
    End Sub

End Class