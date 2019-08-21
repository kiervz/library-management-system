
Public Class frmRegisterUser

    Private imagePath As String
    Private passScore As Integer = 0

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
        Me.Hide()
    End Sub

    'if the RegisterUser form is closed the transparent form will be closed as well
    Private Sub frmRegisterUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
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

    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress
        KeyPressLetterOnly(e)
    End Sub

    Private Sub txtLastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastname.KeyPress
        KeyPressLetterOnly(e)
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        KeyPressNumberOnly(e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        UploadImage()
    End Sub

    Private Sub UploadImage()
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = Nothing Then
            pbProfile.ImageLocation = OpenFileDialog1.FileName
            imagePath = pbProfile.ImageLocation
        End If
    End Sub

    Private Sub frmRegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMale.Checked = True
    End Sub


    Private Sub ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 1)

        Dim passed As Integer = 0
        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) >= minLength Then
            lbl8Characters.Visible = False
            passed += 1
        Else
            lbl8Characters.Visible = True
        End If
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count >= numUpper Then
            lblUpperCase.Visible = False
            passed += 1
        Else
            lblUpperCase.Visible = True
        End If

        If number.Matches(pwd).Count >= numNumbers Then
            lblNumber.Visible = False
            passed += 1
        Else
            lblNumber.Visible = True
        End If
        If special.Matches(pwd).Count >= numSpecial Then
            lblSpecialCharacter.Visible = False
            passed += 1
        Else
            lblSpecialCharacter.Visible = True
        End If

        ' Passed all checks.
        passScore = passed
    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFirstname.TextLength = 0 Or txtLastname.TextLength = 0 Or txtUsername.TextLength = 0 Or txtPassword.TextLength = 0 Or cmbQuestion.Text = "" Or txtAnswer.TextLength = 0 Or txtConfirmPass.TextLength = 0 Or cmbUserType.Text = "" Then
            CustomMessageBox.ShowDialog("Please fill up all fields!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        ElseIf Val(txtAge.Text) < 18 Then
            CustomMessageBox.ShowDialog("Your age must be atleast 18 and above!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        ElseIf txtPassword.Text <> txtConfirmPass.Text Then
            CustomMessageBox.ShowDialog("Your password does not match!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        ElseIf passScore <> 4 Then
            CustomMessageBox.ShowDialog("Please correct your password!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        Else



        End If
    End Sub

    Private Sub ValidatePasswordMatch()
        If txtPassword.Text.Length > 0 Or txtConfirmPass.Text.Length > 0 Then
            pbCheck1.Visible = True
            pbCheck2.Visible = True
            If txtPassword.Text = txtConfirmPass.Text Then
                pbCheck1.Image = My.Resources.check
                pbCheck2.Image = My.Resources.check
            Else
                pbCheck1.Image = My.Resources.x
                pbCheck2.Image = My.Resources.x
            End If
        Else
            pbCheck1.Visible = False
            pbCheck2.Visible = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ValidatePasswordMatch()
        ValidatePassword(txtPassword.Text)
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        ValidatePasswordMatch()
        ValidatePassword(txtConfirmPass.Text)
    End Sub
End Class