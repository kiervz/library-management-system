Imports System.Data.SqlClient
Imports Tulpep.NotificationWindow
'Imports AForge.Video.DirectShow
'Imports AForge.Video
Imports System.Text
Imports System.Security.Cryptography

Public Class frmLogin

    Private _imageNumber As Integer = 1
    Private _nextAttempt As Integer = 60
    Private _attempts As Integer = 0

    'Private _CAMERA As VideoCaptureDevice
    'Private _btmp As Bitmap

    Private Sub LoadNextImage()
        If _imageNumber = 7 Then _imageNumber = 1

        picCarousel.ImageLocation = String.Format("images\" + CStr(_imageNumber) + ".jpg")
        _imageNumber += 1
    End Sub


    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        LoadNextImage()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub Login()
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            CustomMessageBox.ShowDialog(Me, "Please enter your username and password!", "Username and Password Required", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
        ElseIf txtUsername.Text = "" And txtPassword.Text.Length > 0 Then
            CustomMessageBox.ShowDialog(Me, "Please enter your username!", "Username Required", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
        ElseIf txtPassword.Text = "" And txtUsername.Text.Length > 0 Then
            CustomMessageBox.ShowDialog(Me, "Please enter your password!", "Password Required", MessageBoxButtonn.Ok, MessageBoxIconn.Exclamation)
        Else
            Try
                cmd = New SqlCommand("SELECT user_id, firstname, lastname, password, user_type, status, image FROM users WHERE username=@1 AND password=@2", conn)
                cmd.Parameters.AddWithValue("@1", txtUsername.Text)
                cmd.Parameters.AddWithValue("@2", MD5HasherSalt.GetMd5Hash(txtPassword.Text))
                dr = cmd.ExecuteReader

                If dr.Read Then

                    If dr("status").Equals(0) Then
                        CustomMessageBox.ShowDialog(Me, "Your account has been disabled. Contact your administrator to enable.", "Disabled Account", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)

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

                    txtUsername.Clear()
                    txtPassword.Clear()

                    GetUpdatedTime()

                    frmMain.Show()

                    Me.Hide()
                Else
                    CustomMessageBox.ShowDialog(Me, "Your username and password is incorrect!", "Authentication Failed", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
                    Attempt()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
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
        cbShowPassword.Checked = False
    End Sub


    Private Sub Attempt()
        _attempts = _attempts + 1

        If _attempts = 3 Then
            CustomMessageBox.ShowDialog(Me, "You have reached the maximum attempts. System will be closed!", "Authentication Failed", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
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

    Private Sub GetUpdatedTime()
        Try
            str = "SELECT time_updated_at FROM data_updated"
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
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

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

End Class