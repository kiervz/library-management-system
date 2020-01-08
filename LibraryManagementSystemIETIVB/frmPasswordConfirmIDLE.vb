Public Class frmPasswordConfirmIDLE

    Private Sub ConfirmPassword()
        If MD5HasherSalt.GetMd5Hash(txtConfirmPassword.Text) = GlobalVariables.userPassword Then
            isPasswordCorrect = True
            Me.Hide()
        Else
            idlePasswordAttempts += 1
            CustomMessageBox.ShowDialog(Me, "Authentication Failed!", "Incorrect Password", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
            txtConfirmPassword.Clear()

            If idlePasswordAttempts = 3 Then
                CustomMessageBox.ShowDialog(Me, "Authentication Failed! System will be closed.", "Incorrect Password", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
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