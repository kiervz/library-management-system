Imports MetroFramework.Forms
Imports System.Runtime.InteropServices

Module CustomMessageBox
    <DllImport("user32.dll")> _
    Private Function MessageBeep(ByVal uType As UInt32) As Boolean
    End Function

    Private Declare Auto Function MessageBeep Lib "user32.dll" ( _
    ByVal wType As Int32 _
    ) As Int32

    Private Const MB_ICONASTERISK As Int32 = &H40 ' Information.
    Private Const MB_ICONEXCLAMATION As Int32 = &H30 ' Ausrufezeichen.
    Private Const MB_ICONHAND As Int32 = &H10 ' Stopschild.
    Private Const MB_ICONQUESTION As Int32 = &H20 ' Fragezeichen.
    Private Const MB_OK As Int32 = &H0 ' Standard-OK.

    Friend Enum MessageBoxButtonn As Integer
        Ok = 0
        OkCancel = 1
        YesNo = 2
        YesCancel = 3
    End Enum

    Friend Enum MessageBoxIconn As Integer
        Question = 0
        Primary = 1
        Success = 2
        Warning = 3
        Danger = 4
    End Enum

    Public Function ShowDialog(message As String, title As String, msgButton As MessageBoxButtonn, msgIcon As MessageBoxIconn)

        Dim color As New Color

        If msgIcon = MessageBoxIconn.Question Then
            MessageBeep(MB_ICONASTERISK)
            color = Drawing.Color.Gray
        ElseIf msgIcon = MessageBoxIconn.Primary Then
            MessageBeep(MB_OK)
            color = System.Drawing.Color.FromArgb(52, 152, 219)
        ElseIf msgIcon = MessageBoxIconn.Success Then
            MessageBeep(MB_ICONHAND)
            color = System.Drawing.Color.FromArgb(26, 188, 156)
        ElseIf msgIcon = MessageBoxIconn.Warning Then
            MessageBeep(MB_ICONASTERISK)
            color = System.Drawing.Color.FromArgb(211, 84, 0)
        ElseIf msgIcon = MessageBoxIconn.Danger Then
            MessageBeep(MB_ICONEXCLAMATION)
            color = System.Drawing.Color.FromArgb(192, 57, 43)
        End If


        Dim btnFirst As New Button
        With btnFirst
            If msgIcon = MessageBoxIconn.Danger Then
                .BackColor = Drawing.Color.FromArgb(240, 240, 240)
                .ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
            Else
                .BackColor = color
                .ForeColor = Drawing.Color.White
            End If
            .Cursor = System.Windows.Forms.Cursors.Hand
            .FlatAppearance.BorderSize = 0
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
            .Location = New System.Drawing.Point(290, 122)
            .Name = "btnFirst"
            .Size = New System.Drawing.Size(90, 28)
            .UseCompatibleTextRendering = True
            .UseVisualStyleBackColor = True
        End With

        Dim btnSecond As New Button
        With btnSecond
            .BackColor = color
            .Cursor = System.Windows.Forms.Cursors.Hand
            .FlatAppearance.BorderSize = 0
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
            .ForeColor = System.Drawing.Color.White
            .Location = New System.Drawing.Point(386, 122)
            .Name = "btnSecond"
            .Size = New System.Drawing.Size(90, 28)
            .UseCompatibleTextRendering = True
            .UseVisualStyleBackColor = True
        End With


        Dim form As New MetroForm
        With form
            .AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            .ClientSize = New System.Drawing.Size(550, 160)
            .ControlBox = False
            .DisplayHeader = False
            .KeyPreview = True
            .Movable = False
            .Name = "CustomMessageBox"
            .Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
            .Resizable = False
            .ShowIcon = False
            .ShowInTaskbar = False
            .Text = "frmMessageBox"
            .StartPosition = FormStartPosition.CenterScreen
            .TopMost = True
        End With


        Dim panelTop As New Panel
        With panelTop
            .BackColor = color
            .Location = New System.Drawing.Point(0, 0)
            .Name = "panelTop"
            .Size = New System.Drawing.Size(550, 31)
        End With


        Dim txtMessage As New TextBox
        With txtMessage
            .BackColor = System.Drawing.Color.White
            .BorderStyle = System.Windows.Forms.BorderStyle.None
            .Enabled = False
            .Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular)
            .ForeColor = System.Drawing.Color.Black
            .Location = New System.Drawing.Point(99, 62)
            .Multiline = True
            .Name = "txtMessage"
            .Size = New System.Drawing.Size(413, 55)
            .Text = message
            .TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        End With

        Dim pbIcon As New PictureBox
        With pbIcon
            Dim imageIcon As Image = My.Resources.Resources.info

            If msgIcon = MessageBoxIconn.Danger Then
                imageIcon = My.Resources.Resources._error
            ElseIf msgIcon = MessageBoxIconn.Question Then
                imageIcon = My.Resources.Resources.help
            ElseIf msgIcon = MessageBoxIconn.Primary Then
                imageIcon = My.Resources.Resources.info
            ElseIf msgIcon = MessageBoxIconn.Success Then
                imageIcon = My.Resources.Resources.success
            ElseIf msgIcon = MessageBoxIconn.Warning Then
                imageIcon = My.Resources.Resources.info
            End If

            .Image = imageIcon
            .Location = New System.Drawing.Point(23, 58)
            .Name = "pbIcon"
            .Size = New System.Drawing.Size(58, 55)
            .SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            .TabStop = False
        End With

        Dim lblTitle As New Label
        With lblTitle
            .BackColor = color
            .AutoSize = True
            .Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            .ForeColor = System.Drawing.Color.White
            .Location = New System.Drawing.Point(12, 8)
            .Name = "lblTitle"
            .Size = New System.Drawing.Size(166, 15)
            .Text = title
        End With


        If msgButton = MessageBoxButtonn.Ok Then
            btnSecond.Text = "OK"
            form.Controls.Add(btnSecond)
        ElseIf msgButton = MessageBoxButtonn.OkCancel Then
            btnFirst.Text = "OK"
            btnSecond.Text = "CANCEL"
            form.Controls.Add(btnFirst)
            form.Controls.Add(btnSecond)
        ElseIf msgButton = MessageBoxButtonn.YesCancel Then
            btnFirst.Text = "YES"
            btnSecond.Text = "CANCEL"
            form.Controls.Add(btnFirst)
            form.Controls.Add(btnSecond)
        ElseIf msgButton = MessageBoxButtonn.YesNo Then
            btnFirst.Text = "YES"
            btnSecond.Text = "NO"
            form.Controls.Add(btnFirst)
            form.Controls.Add(btnSecond)
        End If

        Dim btnFirstDialogResult As DialogResult = DialogResult.OK
        Dim btnSecondDialogResult As DialogResult = DialogResult.OK

        AddHandler btnFirst.Click, Sub(s, ea)
                                       If msgButton = MessageBoxButtonn.Ok Then
                                           btnFirstDialogResult = DialogResult.OK
                                       ElseIf msgButton = MessageBoxButtonn.OkCancel Then
                                           btnFirstDialogResult = DialogResult.OK
                                       ElseIf msgButton = MessageBoxButtonn.YesCancel Then
                                           btnFirstDialogResult = DialogResult.Yes
                                       ElseIf msgButton = MessageBoxButtonn.YesNo Then
                                           btnFirstDialogResult = DialogResult.Yes
                                       End If
                                       msgBoxButtonClick = btnFirstDialogResult
                                       form.Close()
                                   End Sub

        AddHandler btnSecond.Click, Sub(s, ea)
                                        If msgButton = MessageBoxButtonn.Ok Then
                                            btnSecondDialogResult = DialogResult.OK
                                        ElseIf msgButton = MessageBoxButtonn.OkCancel Then
                                            btnSecondDialogResult = DialogResult.Cancel
                                        ElseIf msgButton = MessageBoxButtonn.YesCancel Then
                                            btnSecondDialogResult = DialogResult.Cancel
                                        ElseIf msgButton = MessageBoxButtonn.YesNo Then
                                            btnSecondDialogResult = DialogResult.No
                                        End If
                                        msgBoxButtonClick = btnSecondDialogResult
                                        form.Close()
                                    End Sub

        form.Controls.Add(lblTitle)
        form.Controls.Add(panelTop)
        form.Controls.Add(txtMessage)
        form.Controls.Add(pbIcon)

        Return form.ShowDialog()

    End Function

End Module
