Imports MetroFramework.Forms

Module CustomMessageBox

    Private Declare Auto Function MessageBeep Lib "user32.dll" (ByVal wType As Int32) As Int32

    Private Const _MB_ICONEXCLAMATION = &H30&
    Private Const _MB_ICONHAND = &H10& 'Danger
    Private Const _MB_ICONINFORMATION = &H40&
    Private Const _MB_ICONMASK = &HF0&
    Private Const _MB_ICONQUESTION = &H20&

    Friend Enum MessageBoxButtonn As Integer
        Ok = 0
        OkCancel = 1
        YesNo = 2
        YesCancel = 3
    End Enum

    Friend Enum MessageBoxIconn As Integer
        Question = 0
        Information = 1
        Success = 2
        Exclamation = 3
        Danger = 4
    End Enum

    Public Function ShowDialog(owner As IWin32Window, message As String, title As String, Optional msgButton As MessageBoxButtonn = MessageBoxButtonn.Ok, Optional msgIcon As MessageBoxIconn = MessageBoxIconn.Information)
        Dim color As New Color

        If msgIcon = MessageBoxIconn.Question Then
            MessageBeep(_MB_ICONQUESTION)
            color = Color.Gray
        ElseIf msgIcon = MessageBoxIconn.Information Then
            MessageBeep(_MB_ICONINFORMATION)
            color = Color.FromArgb(52, 152, 219)
        ElseIf msgIcon = MessageBoxIconn.Success Then
            MessageBeep(_MB_ICONINFORMATION)
            color = Color.FromArgb(26, 188, 156)
        ElseIf msgIcon = MessageBoxIconn.Exclamation Then
            MessageBeep(_MB_ICONEXCLAMATION)
            color = Color.FromArgb(211, 84, 0) 'Color Orange
        ElseIf msgIcon = MessageBoxIconn.Danger Then
            MessageBeep(_MB_ICONHAND)
            color = Color.FromArgb(192, 57, 43) 'Color Red
        End If


        Dim btnFirst As New Button
        With btnFirst
            If msgIcon = MessageBoxIconn.Danger Then
                .BackColor = Color.FromArgb(240, 240, 240)
                .ForeColor = Color.FromArgb(64, 64, 64)
            Else
                .BackColor = color
                .ForeColor = Color.White
            End If
            .Cursor = Cursors.Hand
            .FlatAppearance.BorderSize = 0
            .FlatStyle = FlatStyle.Flat
            .Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
            .Location = New Point(358, 153)
            .Name = "btnFirst"
            .Size = New Size(90, 28)
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
            .Location = New System.Drawing.Point(454, 153)
            .Name = "btnSecond"
            .Size = New System.Drawing.Size(90, 28)
            .UseCompatibleTextRendering = True
            .UseVisualStyleBackColor = True
        End With


        Dim form As New MetroForm
        With form
            .AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            .ClientSize = New System.Drawing.Size(577, 199)
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
        End With


        Dim panelTop As New Panel
        With panelTop
            .BackColor = color
            .Location = New System.Drawing.Point(0, 0)
            .Name = "panelTop"
            .Size = New System.Drawing.Size(577, 31)
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
            .Size = New System.Drawing.Size(445, 85)
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
            ElseIf msgIcon = MessageBoxIconn.Information Then
                imageIcon = My.Resources.Resources.info
            ElseIf msgIcon = MessageBoxIconn.Success Then
                imageIcon = My.Resources.Resources.success
            ElseIf msgIcon = MessageBoxIconn.Exclamation Then
                imageIcon = My.Resources.Resources.exclamationx60
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

        Return form.ShowDialog(owner)
    End Function

End Module
