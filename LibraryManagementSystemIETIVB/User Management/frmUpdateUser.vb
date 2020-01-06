Imports System.Data.SqlClient

Public Class frmUpdateUser

    Private _user_id As String
    Private _imagePath As String

    Public Sub GetUserID(user_id As String)
        Me._user_id = user_id
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CloseTransparentForm()
        Me.Hide()
    End Sub

    'if the RegisterUser form is close the transparent form will be closed as well
    Private Sub frmUpdateUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CloseTransparentForm()
    End Sub

    Private Sub frmUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        rbMale.Checked = True
        SelectUser()
    End Sub

    Private Sub SelectUser()
        Try
            str = "SELECT firstname,middlename,lastname,user_type,gender,phone,birthday,image FROM tblUserInfo WHERE user_id = '" + _user_id + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then

                txtFirstname.Text = dr("firstname")
                txtMiddlename.Text = dr("middlename")
                txtLastname.Text = dr("lastname")
                cmbUserType.Text = dr("user_type")
                txtPhone.Text = dr("phone")
                If dr("gender") = "Male" Then
                    rbMale.Checked = True
                Else
                    rbFemale.Checked = True
                End If
                dtBday.Value = CDate(dr("birthday"))
                _imagePath = dr("image")

                Try
                    pbProfile.Image = Image.FromFile(_imagePath)
                Catch ex As Exception
                    pbProfile.Image = My.Resources.no_image
                End Try

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
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

    Private Sub dtBday_ValueChanged(sender As Object, e As EventArgs) Handles dtBday.ValueChanged
        GetCurrentAge(dtBday.Value)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtFirstname.Text.Length = 0 Or txtLastname.Text.Length = 0 Or txtPhone.Text.Length = 0 Or cmbUserType.Text.Length = 0 Or _imagePath = "" Then
            CustomMessageBox.ShowDialog(Me, "Please fill up all fields!", "Fields Required", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
        ElseIf Val(txtAge.Text) < 18 Then
            CustomMessageBox.ShowDialog(Me, "Your age must be atleast 18 years old and above!", "18 and Above", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
        Else
            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Update?", "Confirmation", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

            If msgBoxButtonClick = DialogResult.Yes Then

                Try
                    str = "UPDATE tblUserInfo SET user_type=@1, firstname=@2, middlename=@3, lastname=@4, gender=@5, phone=@6, birthday=@7, image=@8 WHERE user_id = '" + _user_id + "'"
                    cmd = New SqlCommand(str, conn)
                    cmd.Parameters.AddWithValue("@1", cmbUserType.Text)
                    cmd.Parameters.AddWithValue("@2", txtFirstname.Text)
                    cmd.Parameters.AddWithValue("@3", txtMiddlename.Text)
                    cmd.Parameters.AddWithValue("@4", txtLastname.Text)
                    If rbMale.Checked Then
                        cmd.Parameters.AddWithValue("@5", "Male")
                    Else
                        cmd.Parameters.AddWithValue("@5", "Female")
                    End If
                    cmd.Parameters.AddWithValue("@6", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@7", dtBday.Value.ToShortDateString())
                    cmd.Parameters.AddWithValue("@8", _imagePath)
                    cmd.ExecuteNonQuery()

                    frmMain.UcUserManagement1.FillDGV()
                    CustomMessageBox.ShowDialog(Me, "Record successfully updated!", "Success", MessageBoxButtonn.Ok, MessageBoxIconn.Information)

                    CloseTransparentForm()
                    Me.Hide()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub UploadImage()
        OpenFileDialog1.Filter = "Picture Files (*)|*.jpg;*.png"
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = Nothing Then
            pbProfile.ImageLocation = OpenFileDialog1.FileName
            _imagePath = pbProfile.ImageLocation
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        UploadImage()
    End Sub

    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtMiddlename.KeyPress, txtLastname.KeyPress
        KeyPressLetterOnly(e)
    End Sub

End Class