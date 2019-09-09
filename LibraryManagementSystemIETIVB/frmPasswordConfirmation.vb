Public Class frmPasswordConfirmation

    Private Sub ConfirmPassword()
        If txtConfirmPassword.Text.Length > 0 Then
            If MD5HasherSalt.GetMd5Hash(txtConfirmPassword.Text) = GlobalVariables.userPassword Then isPasswordCorrect = True
            Me.Hide()
        End If
    End Sub

    Private Sub txtConfirmPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirmPassword.KeyDown
        If txtConfirmPassword.Text.Length > 0 Then
            If e.KeyCode = Keys.Enter Then
                ConfirmPassword()
            End If
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtConfirmPassword.Text.Length > 0 Then
            ConfirmPassword()
        End If
    End Sub

End Class