
Public Class frmRegisterUser

    Private imagePath As String

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        Me.Hide()
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

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFirstname.TextLength = 0 Or txtLastname.TextLength = 0 Or txtUsername.TextLength = 0 Or txtPassword.TextLength = 0 Or cmbQuestion.Text = "" Or txtAnswer.TextLength = 0 Or txtConfirmPass.TextLength = 0 Or cmbUserType.Text = "" Then
            CustomMessageBox.ShowDialog("Please fill up all fields!", "Library Management System", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)

        End If
    End Sub
End Class