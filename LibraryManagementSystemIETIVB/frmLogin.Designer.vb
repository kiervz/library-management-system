Imports MetroFramework

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblNextAttempt = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cbShowPassword = New MetroFramework.Controls.MetroCheckBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picCarousel = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarousel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(717, 190)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(253, 25)
        Me.label4.TabIndex = 12
        Me.label4.Text = "LOGIN YOUR ACCOUNT"
        '
        'lblNextAttempt
        '
        Me.lblNextAttempt.AutoSize = True
        Me.lblNextAttempt.BackColor = System.Drawing.Color.Transparent
        Me.lblNextAttempt.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextAttempt.ForeColor = System.Drawing.Color.Maroon
        Me.lblNextAttempt.Location = New System.Drawing.Point(717, 273)
        Me.lblNextAttempt.Name = "lblNextAttempt"
        Me.lblNextAttempt.Size = New System.Drawing.Size(215, 16)
        Me.lblNextAttempt.TabIndex = 14
        Me.lblNextAttempt.Text = "Time remaining for the next attempt:"
        Me.lblNextAttempt.Visible = False
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.BackColor = System.Drawing.Color.Transparent
        Me.lblRemainingTime.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingTime.ForeColor = System.Drawing.Color.Maroon
        Me.lblRemainingTime.Location = New System.Drawing.Point(935, 271)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(32, 18)
        Me.lblRemainingTime.TabIndex = 15
        Me.lblRemainingTime.Text = "120"
        Me.lblRemainingTime.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(717, 303)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(82, 18)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Depth = 0
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Hint = ""
        Me.txtUsername.Location = New System.Drawing.Point(722, 331)
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(246, 23)
        Me.txtUsername.TabIndex = 17
        Me.txtUsername.Text = "kiervs"
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(717, 376)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 18)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Hint = ""
        Me.txtPassword.Location = New System.Drawing.Point(722, 404)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(246, 23)
        Me.txtPassword.TabIndex = 19
        Me.txtPassword.Text = "Password@1123"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(720, 462)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(248, 39)
        Me.btnLogin.TabIndex = 21
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'timer1
        '
        Me.timer1.Enabled = True
        Me.timer1.Interval = 2000
        '
        'timer2
        '
        '
        'cbShowPassword
        '
        Me.cbShowPassword.AutoSize = True
        Me.cbShowPassword.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.cbShowPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cbShowPassword.Location = New System.Drawing.Point(850, 433)
        Me.cbShowPassword.Name = "cbShowPassword"
        Me.cbShowPassword.Size = New System.Drawing.Size(109, 15)
        Me.cbShowPassword.TabIndex = 23
        Me.cbShowPassword.Text = "Show Password"
        Me.cbShowPassword.UseCustomForeColor = True
        Me.cbShowPassword.UseSelectable = True
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.ietilogo
        Me.pictureBox2.Location = New System.Drawing.Point(762, 33)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(163, 143)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 11
        Me.pictureBox2.TabStop = False
        '
        'picCarousel
        '
        Me.picCarousel.Image = CType(resources.GetObject("picCarousel.Image"), System.Drawing.Image)
        Me.picCarousel.Location = New System.Drawing.Point(-2, 5)
        Me.picCarousel.Name = "picCarousel"
        Me.picCarousel.Size = New System.Drawing.Size(684, 559)
        Me.picCarousel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarousel.TabIndex = 1
        Me.picCarousel.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 564)
        Me.Controls.Add(Me.cbShowPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblRemainingTime)
        Me.Controls.Add(Me.lblNextAttempt)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.picCarousel)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmLogin"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Login"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCarousel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents lblNextAttempt As System.Windows.Forms.Label
    Private WithEvents lblRemainingTime As System.Windows.Forms.Label
    Private WithEvents lblUsername As System.Windows.Forms.Label
    Private WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents timer2 As System.Windows.Forms.Timer
    Friend WithEvents cbShowPassword As MetroFramework.Controls.MetroCheckBox
    Private WithEvents picCarousel As System.Windows.Forms.PictureBox

End Class
