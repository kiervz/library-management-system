﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.txtGracePeriod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdleTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPenaltyPerDay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoDaysAllowed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoBooksAllowed = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtConfirmpass = New System.Windows.Forms.TextBox()
        Me.txtNewpass = New System.Windows.Forms.TextBox()
        Me.txtOldpass = New System.Windows.Forms.TextBox()
        Me.pbCheck2 = New System.Windows.Forms.PictureBox()
        Me.pbCheck1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblUpperCase = New System.Windows.Forms.Label()
        Me.lbl8Characters = New System.Windows.Forms.Label()
        Me.lblSpecialCharacter = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.pbCheck2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCheck1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(56, 34)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1009, 511)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 53
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BackColor = System.Drawing.Color.White
        Me.MetroTabPage2.Controls.Add(Me.txtGracePeriod)
        Me.MetroTabPage2.Controls.Add(Me.Label9)
        Me.MetroTabPage2.Controls.Add(Me.txtIdleTime)
        Me.MetroTabPage2.Controls.Add(Me.Label4)
        Me.MetroTabPage2.Controls.Add(Me.btnSave)
        Me.MetroTabPage2.Controls.Add(Me.txtPenaltyPerDay)
        Me.MetroTabPage2.Controls.Add(Me.Label3)
        Me.MetroTabPage2.Controls.Add(Me.txtNoDaysAllowed)
        Me.MetroTabPage2.Controls.Add(Me.Label2)
        Me.MetroTabPage2.Controls.Add(Me.txtNoBooksAllowed)
        Me.MetroTabPage2.Controls.Add(Me.label1)
        Me.MetroTabPage2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1001, 466)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Options"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'txtGracePeriod
        '
        Me.txtGracePeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGracePeriod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGracePeriod.Location = New System.Drawing.Point(640, 221)
        Me.txtGracePeriod.MaxLength = 30
        Me.txtGracePeriod.Name = "txtGracePeriod"
        Me.txtGracePeriod.Size = New System.Drawing.Size(207, 26)
        Me.txtGracePeriod.TabIndex = 188
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(177, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(295, 20)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Grace period after time in and time out"
        '
        'txtIdleTime
        '
        Me.txtIdleTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdleTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdleTime.Location = New System.Drawing.Point(640, 273)
        Me.txtIdleTime.MaxLength = 30
        Me.txtIdleTime.Name = "txtIdleTime"
        Me.txtIdleTime.Size = New System.Drawing.Size(207, 26)
        Me.txtIdleTime.TabIndex = 187
        Me.txtIdleTime.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 20)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "Maximum idle time in seconds"
        Me.Label4.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(761, 368)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 35)
        Me.btnSave.TabIndex = 185
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPenaltyPerDay
        '
        Me.txtPenaltyPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenaltyPerDay.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyPerDay.Location = New System.Drawing.Point(640, 169)
        Me.txtPenaltyPerDay.MaxLength = 30
        Me.txtPenaltyPerDay.Name = "txtPenaltyPerDay"
        Me.txtPenaltyPerDay.Size = New System.Drawing.Size(207, 26)
        Me.txtPenaltyPerDay.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "Penalty per day"
        '
        'txtNoDaysAllowed
        '
        Me.txtNoDaysAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoDaysAllowed.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDaysAllowed.Location = New System.Drawing.Point(640, 117)
        Me.txtNoDaysAllowed.MaxLength = 30
        Me.txtNoDaysAllowed.Name = "txtNoDaysAllowed"
        Me.txtNoDaysAllowed.Size = New System.Drawing.Size(207, 26)
        Me.txtNoDaysAllowed.TabIndex = 165
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "No. of day(s) allowed "
        '
        'txtNoBooksAllowed
        '
        Me.txtNoBooksAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoBooksAllowed.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoBooksAllowed.Location = New System.Drawing.Point(640, 65)
        Me.txtNoBooksAllowed.MaxLength = 30
        Me.txtNoBooksAllowed.Name = "txtNoBooksAllowed"
        Me.txtNoBooksAllowed.Size = New System.Drawing.Size(207, 26)
        Me.txtNoBooksAllowed.TabIndex = 163
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(177, 71)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(251, 20)
        Me.label1.TabIndex = 164
        Me.label1.Text = "No. of Book(s) allowed to borrow"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BackColor = System.Drawing.Color.White
        Me.MetroTabPage3.Controls.Add(Me.btnSubmit)
        Me.MetroTabPage3.Controls.Add(Me.txtConfirmpass)
        Me.MetroTabPage3.Controls.Add(Me.txtNewpass)
        Me.MetroTabPage3.Controls.Add(Me.txtOldpass)
        Me.MetroTabPage3.Controls.Add(Me.pbCheck2)
        Me.MetroTabPage3.Controls.Add(Me.pbCheck1)
        Me.MetroTabPage3.Controls.Add(Me.Label8)
        Me.MetroTabPage3.Controls.Add(Me.FlowLayoutPanel1)
        Me.MetroTabPage3.Controls.Add(Me.Label5)
        Me.MetroTabPage3.Controls.Add(Me.Label6)
        Me.MetroTabPage3.Controls.Add(Me.Label7)
        Me.MetroTabPage3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(1001, 466)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Change Password"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmit.Location = New System.Drawing.Point(434, 359)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(270, 37)
        Me.btnSubmit.TabIndex = 234
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtConfirmpass
        '
        Me.txtConfirmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmpass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmpass.Location = New System.Drawing.Point(434, 278)
        Me.txtConfirmpass.MaxLength = 30
        Me.txtConfirmpass.Name = "txtConfirmpass"
        Me.txtConfirmpass.Size = New System.Drawing.Size(270, 26)
        Me.txtConfirmpass.TabIndex = 233
        '
        'txtNewpass
        '
        Me.txtNewpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewpass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewpass.Location = New System.Drawing.Point(434, 163)
        Me.txtNewpass.MaxLength = 30
        Me.txtNewpass.Name = "txtNewpass"
        Me.txtNewpass.Size = New System.Drawing.Size(270, 26)
        Me.txtNewpass.TabIndex = 232
        '
        'txtOldpass
        '
        Me.txtOldpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldpass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldpass.Location = New System.Drawing.Point(434, 103)
        Me.txtOldpass.MaxLength = 30
        Me.txtOldpass.Name = "txtOldpass"
        Me.txtOldpass.Size = New System.Drawing.Size(270, 26)
        Me.txtOldpass.TabIndex = 231
        '
        'pbCheck2
        '
        Me.pbCheck2.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.x
        Me.pbCheck2.Location = New System.Drawing.Point(710, 285)
        Me.pbCheck2.Name = "pbCheck2"
        Me.pbCheck2.Size = New System.Drawing.Size(19, 19)
        Me.pbCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCheck2.TabIndex = 230
        Me.pbCheck2.TabStop = False
        Me.pbCheck2.Visible = False
        '
        'pbCheck1
        '
        Me.pbCheck1.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.check
        Me.pbCheck1.Location = New System.Drawing.Point(710, 170)
        Me.pbCheck1.Name = "pbCheck1"
        Me.pbCheck1.Size = New System.Drawing.Size(19, 19)
        Me.pbCheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCheck1.TabIndex = 229
        Me.pbCheck1.TabStop = False
        Me.pbCheck1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(437, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 15)
        Me.Label8.TabIndex = 228
        Me.Label8.Text = "* Confirm your password"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblUpperCase)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl8Characters)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSpecialCharacter)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(434, 198)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(270, 71)
        Me.FlowLayoutPanel1.TabIndex = 226
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.Black
        Me.lblNumber.Location = New System.Drawing.Point(3, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(180, 15)
        Me.lblNumber.TabIndex = 211
        Me.lblNumber.Text = "* Password must have a number."
        '
        'lblUpperCase
        '
        Me.lblUpperCase.AutoSize = True
        Me.lblUpperCase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpperCase.ForeColor = System.Drawing.Color.Black
        Me.lblUpperCase.Location = New System.Drawing.Point(3, 15)
        Me.lblUpperCase.Name = "lblUpperCase"
        Me.lblUpperCase.Size = New System.Drawing.Size(202, 15)
        Me.lblUpperCase.TabIndex = 210
        Me.lblUpperCase.Text = "* Password must have an upper case."
        '
        'lbl8Characters
        '
        Me.lbl8Characters.AutoSize = True
        Me.lbl8Characters.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8Characters.ForeColor = System.Drawing.Color.Black
        Me.lbl8Characters.Location = New System.Drawing.Point(3, 30)
        Me.lbl8Characters.Name = "lbl8Characters"
        Me.lbl8Characters.Size = New System.Drawing.Size(259, 15)
        Me.lbl8Characters.TabIndex = 209
        Me.lbl8Characters.Text = "* Password must atleast 8 characters and above."
        '
        'lblSpecialCharacter
        '
        Me.lblSpecialCharacter.AutoSize = True
        Me.lblSpecialCharacter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecialCharacter.ForeColor = System.Drawing.Color.Black
        Me.lblSpecialCharacter.Location = New System.Drawing.Point(3, 45)
        Me.lblSpecialCharacter.Name = "lblSpecialCharacter"
        Me.lblSpecialCharacter.Size = New System.Drawing.Size(226, 15)
        Me.lblSpecialCharacter.TabIndex = 212
        Me.lblSpecialCharacter.Text = "* Password must have a special character."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(282, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Old Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(282, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 221
        Me.Label6.Text = "New Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(282, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 20)
        Me.Label7.TabIndex = 220
        Me.Label7.Text = "Re type Password:"
        '
        'ucSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "ucSettings"
        Me.Size = New System.Drawing.Size(1126, 599)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.pbCheck2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCheck1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtNoBooksAllowed As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents txtPenaltyPerDay As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents txtNoDaysAllowed As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdleTime As TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents lblNumber As System.Windows.Forms.Label
    Private WithEvents lblUpperCase As System.Windows.Forms.Label
    Private WithEvents lbl8Characters As System.Windows.Forms.Label
    Private WithEvents lblSpecialCharacter As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pbCheck2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCheck1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtOldpass As TextBox
    Friend WithEvents txtNewpass As TextBox
    Friend WithEvents txtConfirmpass As TextBox
    Private WithEvents btnSubmit As Button
    Friend WithEvents txtGracePeriod As TextBox
    Private WithEvents Label9 As Label
End Class
