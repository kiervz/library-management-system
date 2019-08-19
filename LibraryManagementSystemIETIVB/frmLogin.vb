﻿Imports System.Data.SqlClient
Imports Tulpep.NotificationWindow
Imports AForge.Video.DirectShow
Imports AForge.Video

Public Class frmLogin

    Private imageNumber As Integer = 1
    Private nextAttempt As Integer = 120
    Private attempts As Integer = 0

    Private CAMERA As VideoCaptureDevice
    Private btmp As Bitmap

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
            CustomMessageBox.ShowDialog("Please enter your username and password!", "Username and Password Required", MessageBoxButtonn.Ok, MessageBoxIconn.Warning)
        ElseIf txtUsername.Text = "" And txtPassword.Text.Length > 0 Then
            CustomMessageBox.ShowDialog("Please enter your username!", "Username Required", MessageBoxButtonn.Ok, MessageBoxIconn.Warning)
        ElseIf txtPassword.Text = "" And txtUsername.Text.Length > 0 Then
            CustomMessageBox.ShowDialog("Please enter your password!", "Password Required", MessageBoxButtonn.Ok, MessageBoxIconn.Warning)
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
                    GlobalVariables.userImage = dr("Image")
                    GlobalVariables.userType = dr("UserType")

                    txtUsername.Clear()
                    txtPassword.Clear()

                    frmMain.Show()
                    Me.Hide()
                Else
                    CustomMessageBox.ShowDialog("Your username and password is incorrect!", "Authentication Failed", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
                    Attempt()
                End If
            Catch ex As Exception
                Msg(Me, ex.Message, "Error")
            End Try

        End If

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
    End Sub


    Private Sub Attempt()
        attempts = attempts + 1

        If attempts = 3 Then
            'StartCaptureCamera()
            EnableControl(False)
            lblNextAttempt.Visible = True
            lblRemainingTime.Visible = True
            timer2.Start()
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

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        nextAttempt -= 1

        lblRemainingTime.Text = nextAttempt

        If Val(lblRemainingTime.Text) = 0 Then
            lblNextAttempt.Visible = False
            lblRemainingTime.Visible = False
            attempts = 0
            nextAttempt = 120
            EnableControl(True)
            timer2.Stop()
        End If
    End Sub

#Region "Capture Image"
    'Private Sub StartCaptureCamera()
    '    'Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
    '    Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
    '    Dim videoSource As New VideoCaptureDevice(videoDevices(0).MonikerString)
    '    AddHandler videoSource.NewFrame, New NewFrameEventHandler(AddressOf Video_NewFrame)
    '    videoSource.Start()
    '    'videoSource.SignalToStop()
    'End Sub

    'Private Sub Video_NewFrame(sender As Object, e As NewFrameEventArgs)
    '    btmp = DirectCast(e.Frame.Clone(), Bitmap)
    '    pbTakePic.Image = DirectCast(e.Frame.Clone(), Bitmap)
    '    SaveImage()
    'End Sub

    'Private Sub SaveImage()
    '    ' Compose the picture's base file name.
    '    Dim file_name As String = Application.ExecutablePath
    '    file_name = "C:\Intel."

    '    ' Get a Bitmap.

    '    PictureBox1.Image = pbTakePic.Image
    '    Dim bmpNew As Bitmap = PictureBox1.Image

    '    ''btmp = bmpNew
    '    bmpNew.Save(file_name & ".jpg", _
    '        System.Drawing.Imaging.ImageFormat.Jpeg)
    'End Sub
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        CustomMessageBox.ShowDialog("wdwd", "wadawd", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)
    End Sub
End Class