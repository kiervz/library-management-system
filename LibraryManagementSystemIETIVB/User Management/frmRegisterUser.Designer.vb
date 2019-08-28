<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterUser
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbFemale = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbMale = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cmbUserType = New MetroFramework.Controls.MetroComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtBday = New MetroFramework.Controls.MetroDateTime()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.cmbQuestion = New MetroFramework.Controls.MetroComboBox()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbCheck1 = New System.Windows.Forms.PictureBox()
        Me.pbCheck2 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl8Characters = New System.Windows.Forms.Label()
        Me.lblUpperCase = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblSpecialCharacter = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCheck1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCheck2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Depth = 0
        Me.rbFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbFemale.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbFemale.Location = New System.Drawing.Point(339, 301)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(0)
        Me.rbFemale.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbFemale.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Ripple = True
        Me.rbFemale.Size = New System.Drawing.Size(74, 30)
        Me.rbFemale.TabIndex = 5
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseCompatibleTextRendering = True
        Me.rbFemale.UseVisualStyleBackColor = False
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Depth = 0
        Me.rbMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMale.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbMale.Location = New System.Drawing.Point(257, 301)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(0)
        Me.rbMale.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbMale.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Ripple = True
        Me.rbMale.Size = New System.Drawing.Size(59, 30)
        Me.rbMale.TabIndex = 4
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseCompatibleTextRendering = True
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Contact No.:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(43, 311)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(70, 20)
        Me.label3.TabIndex = 163
        Me.label3.Text = "Gender:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(43, 264)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 20)
        Me.label5.TabIndex = 162
        Me.label5.Text = "User type:"
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.ItemHeight = 23
        Me.cmbUserType.Items.AddRange(New Object() {"Administrator", "Librarian", "Student Assistant"})
        Me.cmbUserType.Location = New System.Drawing.Point(259, 255)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(269, 29)
        Me.cmbUserType.TabIndex = 3
        Me.cmbUserType.UseSelectable = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(43, 219)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(83, 20)
        Me.label2.TabIndex = 161
        Me.label2.Text = "Lastname:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(43, 137)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 20)
        Me.label1.TabIndex = 160
        Me.label1.Text = "Firstname:"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(469, 391)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(59, 26)
        Me.txtAge.TabIndex = 170
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "Birthday:"
        '
        'dtBday
        '
        Me.dtBday.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtBday.Location = New System.Drawing.Point(259, 392)
        Me.dtBday.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtBday.Name = "dtBday"
        Me.dtBday.Size = New System.Drawing.Size(204, 25)
        Me.dtBday.TabIndex = 7
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.Location = New System.Drawing.Point(43, 530)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(145, 20)
        Me.lblConfirmPass.TabIndex = 176
        Me.lblConfirmPass.Text = "Confirm password:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(41, 486)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(83, 20)
        Me.lblPassword.TabIndex = 175
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(41, 442)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 20)
        Me.lblUsername.TabIndex = 174
        Me.lblUsername.Text = "Username:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(634, 655)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(186, 33)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(634, 616)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(186, 33)
        Me.btnRegister.TabIndex = 16
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(634, 317)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(186, 33)
        Me.btnBrowse.TabIndex = 15
        Me.btnBrowse.Text = "BROWSE IMAGE"
        Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(43, 618)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(129, 20)
        Me.lblAnswer.TabIndex = 184
        Me.lblAnswer.Text = "Security Answer:"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(43, 579)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(139, 20)
        Me.lblQuestion.TabIndex = 182
        Me.lblQuestion.Text = "Security Question:"
        '
        'cmbQuestion
        '
        Me.cmbQuestion.FormattingEnabled = True
        Me.cmbQuestion.ItemHeight = 23
        Me.cmbQuestion.Items.AddRange(New Object() {"What is the name of your favorite teacher?", "What is the name of your first pet?", "What is the name of your first school?", "What is the name of your first gf/bf?", "What is your mother's complete middle name?", "What is your father's complete middle name?", "What city were you born?", "What is yout favorite tourist spot?", "What is your favorite place?", "Who is your favorite teacher?", "Where is your first job?", "Where is your first duty?"})
        Me.cmbQuestion.Location = New System.Drawing.Point(259, 570)
        Me.cmbQuestion.Name = "cmbQuestion"
        Me.cmbQuestion.Size = New System.Drawing.Size(269, 29)
        Me.cmbQuestion.TabIndex = 11
        Me.cmbQuestion.UseSelectable = True
        '
        'pbProfile
        '
        Me.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfile.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.no_image
        Me.pbProfile.Location = New System.Drawing.Point(634, 131)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(186, 172)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 186
        Me.pbProfile.TabStop = False
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(259, 131)
        Me.txtFirstname.MaxLength = 30
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(269, 26)
        Me.txtFirstname.TabIndex = 0
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(259, 213)
        Me.txtLastname.MaxLength = 30
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(269, 26)
        Me.txtLastname.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(259, 347)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(269, 26)
        Me.txtPhone.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(259, 436)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(269, 26)
        Me.txtUsername.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(259, 480)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(269, 26)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(259, 524)
        Me.txtConfirmPass.MaxLength = 16
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(269, 26)
        Me.txtConfirmPass.TabIndex = 10
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'txtAnswer
        '
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(259, 616)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(269, 26)
        Me.txtAnswer.TabIndex = 12
        Me.txtAnswer.UseSystemPasswordChar = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddlename.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(259, 171)
        Me.txtMiddlename.MaxLength = 30
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(269, 26)
        Me.txtMiddlename.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Middlename:"
        '
        'pbCheck1
        '
        Me.pbCheck1.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.check
        Me.pbCheck1.Location = New System.Drawing.Point(506, 483)
        Me.pbCheck1.Name = "pbCheck1"
        Me.pbCheck1.Size = New System.Drawing.Size(19, 19)
        Me.pbCheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCheck1.TabIndex = 206
        Me.pbCheck1.TabStop = False
        Me.pbCheck1.Visible = False
        '
        'pbCheck2
        '
        Me.pbCheck2.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.x
        Me.pbCheck2.Location = New System.Drawing.Point(506, 527)
        Me.pbCheck2.Name = "pbCheck2"
        Me.pbCheck2.Size = New System.Drawing.Size(19, 19)
        Me.pbCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCheck2.TabIndex = 207
        Me.pbCheck2.TabStop = False
        Me.pbCheck2.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl8Characters)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblUpperCase)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSpecialCharacter)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(564, 480)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(311, 74)
        Me.FlowLayoutPanel1.TabIndex = 208
        '
        'lbl8Characters
        '
        Me.lbl8Characters.AutoSize = True
        Me.lbl8Characters.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8Characters.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl8Characters.Location = New System.Drawing.Point(3, 0)
        Me.lbl8Characters.Name = "lbl8Characters"
        Me.lbl8Characters.Size = New System.Drawing.Size(298, 17)
        Me.lbl8Characters.TabIndex = 209
        Me.lbl8Characters.Text = "* Password must atleast 8 characters and above."
        '
        'lblUpperCase
        '
        Me.lblUpperCase.AutoSize = True
        Me.lblUpperCase.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpperCase.ForeColor = System.Drawing.Color.DarkRed
        Me.lblUpperCase.Location = New System.Drawing.Point(3, 17)
        Me.lblUpperCase.Name = "lblUpperCase"
        Me.lblUpperCase.Size = New System.Drawing.Size(228, 17)
        Me.lblUpperCase.TabIndex = 210
        Me.lblUpperCase.Text = "* Password must have an upper case."
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNumber.Location = New System.Drawing.Point(3, 34)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(196, 17)
        Me.lblNumber.TabIndex = 211
        Me.lblNumber.Text = "* Password must have a number"
        '
        'lblSpecialCharacter
        '
        Me.lblSpecialCharacter.AutoSize = True
        Me.lblSpecialCharacter.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecialCharacter.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSpecialCharacter.Location = New System.Drawing.Point(3, 51)
        Me.lblSpecialCharacter.Name = "lblSpecialCharacter"
        Me.lblSpecialCharacter.Size = New System.Drawing.Size(257, 17)
        Me.lblSpecialCharacter.TabIndex = 212
        Me.lblSpecialCharacter.Text = "* Password must have a special character"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Control
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(259, 89)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(117, 26)
        Me.txtUserID.TabIndex = 209
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "User ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(534, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 20)
        Me.Label9.TabIndex = 211
        Me.Label9.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(534, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 20)
        Me.Label11.TabIndex = 213
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(534, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 20)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(534, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 20)
        Me.Label13.TabIndex = 215
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(534, 391)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 20)
        Me.Label14.TabIndex = 216
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(534, 436)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 20)
        Me.Label15.TabIndex = 217
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(534, 480)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 20)
        Me.Label16.TabIndex = 218
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(534, 524)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 20)
        Me.Label17.TabIndex = 219
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(534, 570)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 20)
        Me.Label18.TabIndex = 220
        Me.Label18.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(534, 618)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 20)
        Me.Label19.TabIndex = 221
        Me.Label19.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(44, 670)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(303, 18)
        Me.Label10.TabIndex = 222
        Me.Label10.Text = "Note: All fields with asterisk are required"
        '
        'frmRegisterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 713)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.pbCheck2)
        Me.Controls.Add(Me.pbCheck1)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.cmbQuestion)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtBday)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.Movable = False
        Me.Name = "frmRegisterUser"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "USER REGISTRATION"
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCheck1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCheck2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbFemale As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbMale As MaterialSkin.Controls.MaterialRadioButton
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents cmbUserType As MetroFramework.Controls.MetroComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtBday As MetroFramework.Controls.MetroDateTime
    Private WithEvents lblConfirmPass As System.Windows.Forms.Label
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents lblUsername As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents lblAnswer As System.Windows.Forms.Label
    Private WithEvents lblQuestion As System.Windows.Forms.Label
    Private WithEvents cmbQuestion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents pbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbCheck1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCheck2 As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents lbl8Characters As System.Windows.Forms.Label
    Private WithEvents lblUpperCase As System.Windows.Forms.Label
    Private WithEvents lblNumber As System.Windows.Forms.Label
    Private WithEvents lblSpecialCharacter As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
End Class
