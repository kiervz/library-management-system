Public Class frmPasswordConfirmIDLE

    Private Sub ConfirmPassword()
        If MD5HasherSalt.GetMd5Hash(txtConfirmPassword.Text) = GlobalVariables.userPassword Then
            isPasswordCorrect = True
            Me.Hide()
        Else
            idlePasswordAttempts += 1
            Msg(Me, "Authentication Failed!", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.Clear()

            If idlePasswordAttempts = 3 Then
                Msg(Me, "Authentication Failed! System will be closed.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Not txtConfirmPassword.Text.Length = 0 Then
            ConfirmPassword()
        End If
    End Sub

    Private Sub txtConfirmPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirmPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not txtConfirmPassword.Text.Length = 0 Then
                ConfirmPassword()
            End If
        End If
    End Sub

    Private Sub frmPasswordConfirmIDLE_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CloseTransparentForm()
    End Sub
End Class