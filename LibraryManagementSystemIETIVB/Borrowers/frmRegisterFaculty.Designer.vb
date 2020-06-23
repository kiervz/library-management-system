<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegisterFaculty
    Inherits MetroFramework.Forms.MetroForm

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
        Me.txtFacultyID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtBday = New MetroFramework.Controls.MetroDateTime()
        Me.btnRegisterSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbFemale = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbMale = New MaterialSkin.Controls.MaterialRadioButton()
        Me.SuspendLayout()
        '
        'txtFacultyID
        '
        Me.txtFacultyID.BackColor = System.Drawing.Color.White
        Me.txtFacultyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFacultyID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacultyID.Location = New System.Drawing.Point(228, 101)
        Me.txtFacultyID.Name = "txtFacultyID"
        Me.txtFacultyID.Size = New System.Drawing.Size(269, 26)
        Me.txtFacultyID.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "* Faculty ID:"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(228, 143)
        Me.txtFirstname.MaxLength = 30
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(269, 26)
        Me.txtFirstname.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(63, 149)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 20)
        Me.label1.TabIndex = 213
        Me.label1.Text = "* Firstname:"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddlename.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(228, 185)
        Me.txtMiddlename.MaxLength = 30
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(269, 26)
        Me.txtMiddlename.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "Middlename:"
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(228, 227)
        Me.txtLastname.MaxLength = 30
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(269, 26)
        Me.txtLastname.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 221
        Me.Label4.Text = "* Lastname:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(63, 278)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 20)
        Me.label5.TabIndex = 223
        Me.label5.Text = "* Gender:"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(438, 314)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(59, 26)
        Me.txtAge.TabIndex = 229
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(63, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 20)
        Me.Label10.TabIndex = 228
        Me.Label10.Text = "* Birthday:"
        '
        'dtBday
        '
        Me.dtBday.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtBday.Location = New System.Drawing.Point(228, 314)
        Me.dtBday.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtBday.Name = "dtBday"
        Me.dtBday.Size = New System.Drawing.Size(204, 25)
        Me.dtBday.TabIndex = 5
        '
        'btnRegisterSave
        '
        Me.btnRegisterSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnRegisterSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegisterSave.FlatAppearance.BorderSize = 0
        Me.btnRegisterSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnRegisterSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterSave.ForeColor = System.Drawing.Color.White
        Me.btnRegisterSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegisterSave.Location = New System.Drawing.Point(368, 421)
        Me.btnRegisterSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegisterSave.Name = "btnRegisterSave"
        Me.btnRegisterSave.Size = New System.Drawing.Size(129, 33)
        Me.btnRegisterSave.TabIndex = 6
        Me.btnRegisterSave.Text = "REGISTER"
        Me.btnRegisterSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegisterSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(515, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 17)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "[ Close ]"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(228, 355)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(269, 26)
        Me.txtPhone.TabIndex = 230
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "Phone:"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Depth = 0
        Me.rbFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbFemale.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbFemale.Location = New System.Drawing.Point(310, 268)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(0)
        Me.rbFemale.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbFemale.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Ripple = True
        Me.rbFemale.Size = New System.Drawing.Size(74, 30)
        Me.rbFemale.TabIndex = 233
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
        Me.rbMale.Location = New System.Drawing.Point(228, 268)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(0)
        Me.rbMale.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbMale.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Ripple = True
        Me.rbMale.Size = New System.Drawing.Size(59, 30)
        Me.rbMale.TabIndex = 232
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseCompatibleTextRendering = True
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'frmRegisterFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegisterSave)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtBday)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFacultyID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmRegisterFaculty"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "FACULTY REGISTRATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFacultyID As TextBox
    Private WithEvents Label8 As Label
    Friend WithEvents txtFirstname As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents txtMiddlename As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents txtLastname As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents label5 As Label
    Friend WithEvents txtAge As TextBox
    Private WithEvents Label10 As Label
    Friend WithEvents dtBday As MetroFramework.Controls.MetroDateTime
    Private WithEvents btnRegisterSave As Button
    Private WithEvents btnClose As Label
    Friend WithEvents txtPhone As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents rbFemale As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbMale As MaterialSkin.Controls.MaterialRadioButton
End Class
