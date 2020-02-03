<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterStudent
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.txtStudentID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSection = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtCourse = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtLastname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtMiddlename = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtFirstname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cmbGender = New Guna.UI.WinForms.GunaComboBox()
        Me.txtAge = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.dtBday = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "Student ID:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(63, 149)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 20)
        Me.label1.TabIndex = 213
        Me.label1.Text = "Firstname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "Middlename:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 221
        Me.Label4.Text = "Lastname:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(63, 260)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(70, 20)
        Me.label5.TabIndex = 223
        Me.label5.Text = "Gender:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(63, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 228
        Me.Label10.Text = "Birthday:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(63, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 20)
        Me.Label11.TabIndex = 232
        Me.Label11.Text = "Course:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 331)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 20)
        Me.Label13.TabIndex = 234
        Me.Label13.Text = "Year:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 367)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 236
        Me.Label15.Text = "Section:"
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
        Me.btnRegister.Location = New System.Drawing.Point(398, 453)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(113, 33)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(516, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 17)
        Me.btnClose.TabIndex = 237
        Me.btnClose.Text = "[ Close ]"
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.White
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentID.LineColor = System.Drawing.Color.Gainsboro
        Me.txtStudentID.Location = New System.Drawing.Point(228, 101)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.Size = New System.Drawing.Size(269, 26)
        Me.txtStudentID.TabIndex = 238
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.Color.White
        Me.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSection.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtSection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSection.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSection.Location = New System.Drawing.Point(228, 361)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSection.Size = New System.Drawing.Size(269, 26)
        Me.txtSection.TabIndex = 239
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.Color.White
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCourse.LineColor = System.Drawing.Color.Gainsboro
        Me.txtCourse.Location = New System.Drawing.Point(228, 325)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourse.Size = New System.Drawing.Size(102, 26)
        Me.txtCourse.TabIndex = 240
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastname.LineColor = System.Drawing.Color.Gainsboro
        Me.txtLastname.Location = New System.Drawing.Point(228, 215)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.Size = New System.Drawing.Size(269, 26)
        Me.txtLastname.TabIndex = 241
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BackColor = System.Drawing.Color.White
        Me.txtMiddlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddlename.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtMiddlename.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiddlename.LineColor = System.Drawing.Color.Gainsboro
        Me.txtMiddlename.Location = New System.Drawing.Point(228, 179)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddlename.Size = New System.Drawing.Size(269, 26)
        Me.txtMiddlename.TabIndex = 242
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstname.LineColor = System.Drawing.Color.Gainsboro
        Me.txtFirstname.Location = New System.Drawing.Point(228, 143)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.Size = New System.Drawing.Size(269, 26)
        Me.txtFirstname.TabIndex = 243
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.BaseColor = System.Drawing.Color.White
        Me.cmbGender.BorderColor = System.Drawing.Color.Silver
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGender.ForeColor = System.Drawing.Color.Black
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(228, 254)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cmbGender.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbGender.Size = New System.Drawing.Size(269, 26)
        Me.cmbGender.TabIndex = 244
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAge.LineColor = System.Drawing.Color.Gainsboro
        Me.txtAge.Location = New System.Drawing.Point(438, 289)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.Size = New System.Drawing.Size(59, 26)
        Me.txtAge.TabIndex = 245
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.GunaComboBox1.Location = New System.Drawing.Point(438, 324)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox1.Size = New System.Drawing.Size(59, 26)
        Me.GunaComboBox1.TabIndex = 246
        '
        'dtBday
        '
        Me.dtBday.BaseColor = System.Drawing.Color.White
        Me.dtBday.BorderColor = System.Drawing.Color.Silver
        Me.dtBday.CustomFormat = Nothing
        Me.dtBday.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtBday.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.dtBday.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtBday.ForeColor = System.Drawing.Color.Black
        Me.dtBday.Location = New System.Drawing.Point(228, 290)
        Me.dtBday.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtBday.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtBday.Name = "dtBday"
        Me.dtBday.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtBday.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtBday.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtBday.OnPressedColor = System.Drawing.Color.Black
        Me.dtBday.Size = New System.Drawing.Size(204, 25)
        Me.dtBday.TabIndex = 247
        Me.dtBday.Text = "Sunday, February 2, 2020"
        Me.dtBday.Value = New Date(2020, 2, 2, 19, 11, 13, 372)
        '
        'frmRegisterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtBday)
        Me.Controls.Add(Me.GunaComboBox1)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmRegisterStudent"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "STUDENT REGISTRATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label8 As Label
    Private WithEvents label1 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label15 As Label
    Private WithEvents btnRegister As Button
    Private WithEvents btnClose As Label
    Friend WithEvents txtStudentID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSection As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtCourse As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtLastname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtMiddlename As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtFirstname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cmbGender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtAge As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dtBday As Guna.UI.WinForms.GunaDateTimePicker
End Class
