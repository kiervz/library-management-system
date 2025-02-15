﻿Imports System.Data.SqlClient
Imports Tulpep.NotificationWindow
Imports System.Text
Imports System.Security.Cryptography

Public Class frmLogin

    Private _id_no As Integer
    Private _imageNumber As Integer = 1
    Private _nextAttempt As Integer = 60
    Private _attempts As Integer = 0

    Private Sub LoadNextImage()
        If _imageNumber = 7 Then _imageNumber = 1

        picCarousel.ImageLocation = String.Format("images\" + CStr(_imageNumber) + ".jpg")
        _imageNumber += 1
    End Sub


    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        LoadNextImage()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isDBConnnected = True Then
            Login()
        Else
            Msg(Me, "Connection Failed! Please contact the administrator.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ErrorPanel(isVisible As Boolean)
        PictureBox1.Visible = isVisible
        PictureBox3.Visible = isVisible
    End Sub

    Private Sub Login()
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            Msg(Me, "Please enter your username and password!", "Username and Password Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtUsername.Text = "" And txtPassword.Text.Length > 0 Then
            Msg(Me, "Please enter your username!", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text = "" And txtUsername.Text.Length > 0 Then
            Msg(Me, "Please enter your password!", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                cmd = New SqlCommand("SELECT user_id, firstname, lastname, password, user_type, status, image FROM users WHERE username=@1 AND password=@2", conn)
                cmd.Parameters.AddWithValue("@1", txtUsername.Text)
                cmd.Parameters.AddWithValue("@2", MD5HasherSalt.GetMd5Hash(txtPassword.Text))
                dr = cmd.ExecuteReader

                If dr.Read Then
                    If dr("status").Equals(0) Then
                        Msg(Me, "Your account has been disabled. Contact your administrator to enable.", "Disabled Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtUsername.Clear()
                        txtPassword.Clear()

                        Exit Sub
                    End If

                    GlobalVariables.userID = dr("user_id")
                    GlobalVariables.userFname = dr("firstname")
                    GlobalVariables.userLname = dr("lastname")
                    GlobalVariables.userPassword = dr("password")
                    GlobalVariables.userImage = dr("image")
                    GlobalVariables.userType = dr("user_type")

                    dateTimeLogin = DateTime.Now
                    logHistory()

                    txtUsername.Clear()
                    txtPassword.Clear()

                    GetUpdatedTime()

                    frmMain.Show()

                    Me.Hide()
                Else
                    Msg(Me, "Your username and password is incorrect!", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Attempt()
                End If
            Catch ex As Exception
                'Dim el As New ErrorLogger
                'el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
                Msg(Me, "Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                dr.Close()
                cmd.Dispose()
            End Try

        End If

    End Sub


    Private Sub LogInOutHistoryAN()
        Try
            str = "SELECT MAX(id) FROM log_in_out"
            cmd = New SqlCommand(str, conn)

            If IsDBNull(cmd.ExecuteScalar()) Then
                loginout_id += 1
            Else
                loginout_id = CStr(cmd.ExecuteScalar())
                loginout_id += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub logHistory()
        Try
            cmd = New SqlCommand("INSERT INTO log_in_out (id,user_id, datee, login) VALUES(@id, @user_id, @datee, @login)", conn)
            With cmd
                .Parameters.AddWithValue("@id", loginout_id)
                .Parameters.AddWithValue("@user_id", userID)
                .Parameters.AddWithValue("@login", CDate(dateTimeLogin))
                .Parameters.AddWithValue("@datee", Date.Now.ToShortDateString())
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnableControl(isEnable As Boolean)
        lblPassword.Enabled = isEnable
        lblUsername.Enabled = isEnable
        txtPassword.Enabled = isEnable
        txtUsername.Enabled = isEnable
        btnLogin.Enabled = isEnable
        cbShowPassword.Enabled = isEnable
        txtUsername.Clear()
        txtPassword.Clear()
        cbShowPassword.Checked = False
    End Sub


    Private Sub Attempt()
        _attempts = _attempts + 1

        If _attempts = 3 Then
            Msg(Me, "You have reached the maximum attempts. System will be locked!", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'StartCaptureCamera()
            ErrorPanel(True)
            EnableControl(False)
            lblNextAttempt.Visible = True
            lblRemainingTime.Visible = True
            timer2.Start()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        ErrorPanel(False)
        LogInOutHistoryAN()
        txtUsername.Focus()
    End Sub

    Private Sub GetUpdatedTime()
        Try
            str = "SELECT time_updated_at FROM options"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                My.Settings.data_updated_at = dr("time_updated_at")
                My.Settings.Save()
                My.Settings.Reload()
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            'Dim el As New ErrorLogger
            'el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
            Msg(Me, "Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            dr.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        _nextAttempt -= 1

        lblRemainingTime.Text = _nextAttempt

        If Val(lblRemainingTime.Text) = 0 Then
            lblNextAttempt.Visible = False
            lblRemainingTime.Visible = False
            _attempts = 0
            _nextAttempt = 60
            EnableControl(True)
            ErrorPanel(False)
            timer2.Stop()
        End If
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            Dim db_config As New frmDatabaseConfiguration
            db_config.ShowDialog(Me)
        End If
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub username_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

End Class