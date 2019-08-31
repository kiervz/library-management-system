<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateUser
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
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cmbUserType = New MetroFramework.Controls.MetroComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtBday = New MetroFramework.Controls.MetroDateTime()
        Me.rbFemale = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbMale = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(259, 105)
        Me.txtFirstname.MaxLength = 30
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(269, 26)
        Me.txtFirstname.TabIndex = 189
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(43, 111)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 20)
        Me.label1.TabIndex = 188
        Me.label1.Text = "Firstname:"
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(259, 196)
        Me.txtLastname.MaxLength = 30
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(269, 26)
        Me.txtLastname.TabIndex = 193
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(43, 250)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 20)
        Me.label5.TabIndex = 192
        Me.label5.Text = "User type:"
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.ItemHeight = 23
        Me.cmbUserType.Items.AddRange(New Object() {"Administrator", "Librarian", "Student Assistant"})
        Me.cmbUserType.Location = New System.Drawing.Point(259, 241)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(269, 29)
        Me.cmbUserType.TabIndex = 190
        Me.cmbUserType.UseSelectable = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(43, 202)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(83, 20)
        Me.label2.TabIndex = 191
        Me.label2.Text = "Lastname:"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(259, 335)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(269, 26)
        Me.txtPhone.TabIndex = 201
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(469, 383)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(59, 26)
        Me.txtAge.TabIndex = 200
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 199
        Me.Label6.Text = "Birthday:"
        '
        'dtBday
        '
        Me.dtBday.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtBday.Location = New System.Drawing.Point(259, 384)
        Me.dtBday.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtBday.Name = "dtBday"
        Me.dtBday.Size = New System.Drawing.Size(204, 25)
        Me.dtBday.TabIndex = 198
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Depth = 0
        Me.rbFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbFemale.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbFemale.Location = New System.Drawing.Point(339, 290)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(0)
        Me.rbFemale.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbFemale.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Ripple = True
        Me.rbFemale.Size = New System.Drawing.Size(74, 30)
        Me.rbFemale.TabIndex = 197
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
        Me.rbMale.Location = New System.Drawing.Point(257, 290)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(0)
        Me.rbMale.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbMale.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Ripple = True
        Me.rbMale.Size = New System.Drawing.Size(59, 30)
        Me.rbMale.TabIndex = 196
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseCompatibleTextRendering = True
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "Contact No.:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(43, 300)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(70, 20)
        Me.label3.TabIndex = 194
        Me.label3.Text = "Gender:"
        '
        'pbProfile
        '
        Me.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfile.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.no_image
        Me.pbProfile.Location = New System.Drawing.Point(634, 95)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(186, 172)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 203
        Me.pbProfile.TabStop = False
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
        Me.btnBrowse.Location = New System.Drawing.Point(634, 281)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(186, 33)
        Me.btnBrowse.TabIndex = 202
        Me.btnBrowse.Text = "BROWSE FILE"
        Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(705, 435)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(115, 33)
        Me.btnUpdate.TabIndex = 205
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
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
        Me.btnCancel.Location = New System.Drawing.Point(587, 435)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 33)
        Me.btnCancel.TabIndex = 204
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddlename.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(259, 150)
        Me.txtMiddlename.MaxLength = 30
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(269, 26)
        Me.txtMiddlename.TabIndex = 207
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Middlename:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(534, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 20)
        Me.Label8.TabIndex = 208
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(534, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 20)
        Me.Label9.TabIndex = 209
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(534, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 20)
        Me.Label10.TabIndex = 210
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(534, 335)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 20)
        Me.Label11.TabIndex = 211
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(534, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 20)
        Me.Label12.TabIndex = 212
        Me.Label12.Text = "*"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(23, 441)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(303, 18)
        Me.Label13.TabIndex = 213
        Me.Label13.Text = "Note: All fields with asterisk are required"
        '
        'frmUpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtBday)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.Movable = False
        Me.Name = "frmUpdateUser"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "UPDATE USER"
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents cmbUserType As MetroFramework.Controls.MetroComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtBday As MetroFramework.Controls.MetroDateTime
    Friend WithEvents rbFemale As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbMale As MaterialSkin.Controls.MaterialRadioButton
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents pbProfile As System.Windows.Forms.PictureBox
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents btnUpdate As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents Label13 As System.Windows.Forms.Label
End Class
