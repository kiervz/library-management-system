Imports MetroFramework

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblNextAttempt = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cbShowPassword = New MetroFramework.Controls.MetroCheckBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picCarousel = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarousel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(703, 169)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(253, 25)
        Me.label4.TabIndex = 12
        Me.label4.Text = "LOGIN YOUR ACCOUNT"
        '
        'lblNextAttempt
        '
        Me.lblNextAttempt.AutoSize = True
        Me.lblNextAttempt.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblNextAttempt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextAttempt.ForeColor = System.Drawing.Color.Maroon
        Me.lblNextAttempt.Location = New System.Drawing.Point(724, 250)
        Me.lblNextAttempt.Name = "lblNextAttempt"
        Me.lblNextAttempt.Size = New System.Drawing.Size(203, 15)
        Me.lblNextAttempt.TabIndex = 14
        Me.lblNextAttempt.Text = "Time remaining for the next attempt:"
        Me.lblNextAttempt.Visible = False
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblRemainingTime.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingTime.ForeColor = System.Drawing.Color.Maroon
        Me.lblRemainingTime.Location = New System.Drawing.Point(928, 247)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(31, 20)
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
        Me.lblUsername.Location = New System.Drawing.Point(704, 284)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(82, 18)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(704, 357)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 18)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(707, 459)
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
        Me.cbShowPassword.Location = New System.Drawing.Point(846, 410)
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
        Me.pictureBox2.Location = New System.Drawing.Point(761, 28)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(146, 133)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 11
        Me.pictureBox2.TabStop = False
        '
        'picCarousel
        '
        Me.picCarousel.Image = CType(resources.GetObject("picCarousel.Image"), System.Drawing.Image)
        Me.picCarousel.Location = New System.Drawing.Point(-2, 5)
        Me.picCarousel.Name = "picCarousel"
        Me.picCarousel.Size = New System.Drawing.Size(666, 559)
        Me.picCarousel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarousel.TabIndex = 1
        Me.picCarousel.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.PictureBox3.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.circledx
        Me.PictureBox3.Location = New System.Drawing.Point(694, 242)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.errorbg
        Me.PictureBox1.Location = New System.Drawing.Point(690, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(707, 305)
        Me.txtUsername.MaxLength = 100
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(248, 26)
        Me.txtUsername.TabIndex = 28
        Me.txtUsername.Text = "kiervs"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(707, 378)
        Me.txtPassword.MaxLength = 100
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(248, 26)
        Me.txtPassword.TabIndex = 29
        Me.txtPassword.Text = "Password@1123"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 531)
        Me.Controls.Add(Me.lblRemainingTime)
        Me.Controls.Add(Me.lblNextAttempt)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbShowPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.picCarousel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents lblNextAttempt As System.Windows.Forms.Label
    Private WithEvents lblRemainingTime As System.Windows.Forms.Label
    Private WithEvents lblUsername As System.Windows.Forms.Label
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents timer2 As System.Windows.Forms.Timer
    Friend WithEvents cbShowPassword As MetroFramework.Controls.MetroCheckBox
    Private WithEvents picCarousel As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
