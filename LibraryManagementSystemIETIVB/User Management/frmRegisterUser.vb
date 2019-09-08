Imports System.Data.SqlClient

Public Class frmRegisterUser

    Private _imagePath As String
    Private _passScore As Integer = 0

    Sub AUTO()
        Try
            Dim cmd As New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = "SP_AutoNo_AN"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@pfx", "UID")
            End With
            cmd.ExecuteScalar()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AN()
        Try
            Dim number As String
            str = "SELECT Max(NewNumber) FROM AutoNumber where Pfx = @Pfx"
            cmd = New SqlCommand(str, conn)
            With cmd
                .Parameters.AddWithValue("@Pfx", "UID")
                If IsDBNull(cmd.ExecuteScalar) Then
                    AUTO()
                    Dim number1 As String
                    str = "SELECT Max(NewNumber) FROM AutoNumber where Pfx = @Pfx"
                    cmd = New SqlCommand(str, conn)
                    With cmd
                        .Parameters.AddWithValue("@Pfx", "UID")
                        number1 = Convert.ToString(cmd.ExecuteScalar)
                        txtUserID.Text = number1
                    End With
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else
                    number = Convert.ToString(cmd.ExecuteScalar)
                    txtUserID.Text = number
                End If

            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmRegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        rbMale.Checked = True
        AN()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub

    'if the RegisterUser form is closed the transparent form will be closed as well
    Private Sub frmRegisterUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CloseTransparentForm
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

    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtMiddlename.KeyPress, txtLastname.KeyPress
        KeyPressLetterOnly(e)
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        KeyPressNumberOnly(e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        UploadImage()
    End Sub

    Private Sub UploadImage()
        OpenFileDialog1.Filter = "Picture Files (*)|*.jpg;*.png"
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = Nothing Then
            pbProfile.ImageLocation = OpenFileDialog1.FileName
            _imagePath = pbProfile.ImageLocation
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
    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFirstname.TextLength = 0 Or txtLastname.TextLength = 0 Or txtUsername.TextLength = 0 Or txtPassword.TextLength = 0 Or cmbQuestion.Text = "" Or txtAnswer.TextLength = 0 Or txtConfirmPass.TextLength = 0 Or cmbUserType.Text.Length = 0 Or _imagePath = "" Then
            CustomMessageBox.ShowDialog(Me, "Please fill up all fields!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        ElseIf Val(txtAge.Text) < 18 Then
            CustomMessageBox.ShowDialog(Me, "Your age must be atleast 18 and above!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        ElseIf txtPassword.Text <> txtConfirmPass.Text Then
            CustomMessageBox.ShowDialog(Me, "Your password does not match!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        ElseIf _passScore <> 4 Then
            CustomMessageBox.ShowDialog(Me, "Please correct your password!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        Else

            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Register?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

            If msgBoxButtonClick = DialogResult.Yes Then

                Try
                    str = "INSERT INTO tblUserInfo (user_id,user_type,firstname,middlename,lastname,gender,phone,birthday,username,password,security_question,security_answer,status,image) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14)"
                    cmd = New SqlCommand(str, conn)
                    With cmd.Parameters
                        .AddWithValue("@1", txtUserID.Text)
                        .AddWithValue("@2", cmbUserType.Text)
                        .AddWithValue("@3", txtFirstname.Text)
                        If txtMiddlename.Text.Length > 0 Then
                            cmd.Parameters.AddWithValue("@4", txtMiddlename.Text)
                        Else
                            cmd.Parameters.AddWithValue("@4", "")
                        End If
                        .AddWithValue("@5", txtLastname.Text)
                        If rbMale.Checked Then cmd.Parameters.AddWithValue("@6", "Male")
                        If rbFemale.Checked Then cmd.Parameters.AddWithValue("@6", "Female")

                        .AddWithValue("@7", txtPhone.Text)
                        .AddWithValue("@8", dtBday.Value.ToShortDateString())
                        .AddWithValue("@9", txtUsername.Text)
                        .AddWithValue("@10", MD5HasherSalt.GetMd5Hash(txtPassword.Text))
                        .AddWithValue("@11", cmbQuestion.Text)
                        .AddWithValue("@12", MD5HasherSalt.GetMd5Hash(txtAnswer.Text))
                        .AddWithValue("@13", "1")
                        .AddWithValue("@14", _imagePath)
                    End With

                    cmd.ExecuteNonQuery()
                    ClearAll()
                    AUTO()
                    AN()
                    frmMain.UcUserManagement1.FillDGV()
                    CustomMessageBox.ShowDialog(Me, "Record successfully added!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

        End If
    End Sub

    Private Sub ClearAll()
        txtUserID.Text = ""
        txtAge.Text = ""
        txtAnswer.Text = ""
        txtConfirmPass.Text = ""
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtMiddlename.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtUsername.Text = ""
        cmbQuestion.Text = ""
        cmbUserType.Text = ""
        rbMale.Checked = True
        pbProfile.Image = My.Resources.no_image
        _passScore = 0
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