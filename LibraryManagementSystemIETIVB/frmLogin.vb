Imports System.Data.SqlClient
Imports Tulpep.NotificationWindow

Public Class frmLogin

    Private imageNumber As Integer = 1
    Private totalAttempt As Integer = 0
    Private att As Integer = 0

    Private Sub LoadNextImage()
        If imageNumber = 5 Then
            imageNumber = 1
        End If

        picCarousel.ImageLocation = String.Format("Images\" + CStr(imageNumber) + ".jpg")
        imageNumber = imageNumber + 1
    End Sub


    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        LoadNextImage()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub Login()
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            Msg(Me, "Please enter your username and password!", "Username and Password Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtUsername.Text = "" And txtPassword.Text.Length > 0 Then
            Msg(Me, "Please enter your username!", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtPassword.Text = "" And txtUsername.Text.Length > 0 Then
            Msg(Me, "Please enter your password!", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Try
                cmd = New SqlCommand("SELECT UserID, FirstName, LastName, UserType, Image FROM tblUserInfo WHERE Username=@1 AND Password=@2", conn)
                cmd.Parameters.AddWithValue("@1", txtUsername.Text)
                cmd.Parameters.AddWithValue("@2", MD5Hasher.GetMd5Hash(txtPassword.Text))
                dr = cmd.ExecuteReader

                If dr.Read Then

                    GlobalVariables.userid = dr("UserID")
                    GlobalVariables.fname = dr("FirstName")
                    GlobalVariables.lname = dr("LastName")
                    GlobalVariables.image = dr("Image")
                    GlobalVariables.userType = dr("UserType")

                    txtUsername.Clear()
                    txtPassword.Clear()

                    frmMain.Show()
                    Me.Hide()
                Else
                    Msg(Me, "Your username and password is incorrect!", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    attempt()
                End If
            Catch ex As Exception
                Msg(Me, ex.Message, "Error")
            End Try

        End If

    End Sub

    Public Sub attempt()
        att = att + 1

        If att = 3 Then
            Msg(Me, "You have reached the maximum attempts... System will be closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class