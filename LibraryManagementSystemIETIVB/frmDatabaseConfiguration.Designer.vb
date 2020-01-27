<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatabaseConfiguration
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
        Me.txtDatabase = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtUserName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtServerHost = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDatabase
        '
        Me.txtDatabase.Depth = 0
        Me.txtDatabase.Hint = ""
        Me.txtDatabase.Location = New System.Drawing.Point(158, 227)
        Me.txtDatabase.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatabase.SelectedText = ""
        Me.txtDatabase.SelectionLength = 0
        Me.txtDatabase.SelectionStart = 0
        Me.txtDatabase.Size = New System.Drawing.Size(202, 23)
        Me.txtDatabase.TabIndex = 57
        Me.txtDatabase.UseSystemPasswordChar = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.Teal
        Me.label10.Location = New System.Drawing.Point(49, 233)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(82, 16)
        Me.label10.TabIndex = 56
        Me.label10.Text = "Database:"
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = ""
        Me.txtPassword.Location = New System.Drawing.Point(158, 188)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(202, 23)
        Me.txtPassword.TabIndex = 55
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Teal
        Me.label9.Location = New System.Drawing.Point(49, 194)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(83, 16)
        Me.label9.TabIndex = 54
        Me.label9.Text = "Password:"
        '
        'txtUserName
        '
        Me.txtUserName.Depth = 0
        Me.txtUserName.Hint = ""
        Me.txtUserName.Location = New System.Drawing.Point(158, 149)
        Me.txtUserName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.SelectionLength = 0
        Me.txtUserName.SelectionStart = 0
        Me.txtUserName.Size = New System.Drawing.Size(202, 23)
        Me.txtUserName.TabIndex = 53
        Me.txtUserName.UseSystemPasswordChar = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Teal
        Me.label8.Location = New System.Drawing.Point(49, 155)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(87, 16)
        Me.label8.TabIndex = 52
        Me.label8.Text = "Username:"
        '
        'txtServerHost
        '
        Me.txtServerHost.Depth = 0
        Me.txtServerHost.Hint = ""
        Me.txtServerHost.Location = New System.Drawing.Point(158, 111)
        Me.txtServerHost.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtServerHost.Name = "txtServerHost"
        Me.txtServerHost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServerHost.SelectedText = ""
        Me.txtServerHost.SelectionLength = 0
        Me.txtServerHost.SelectionStart = 0
        Me.txtServerHost.Size = New System.Drawing.Size(202, 23)
        Me.txtServerHost.TabIndex = 51
        Me.txtServerHost.UseSystemPasswordChar = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Teal
        Me.label6.Location = New System.Drawing.Point(49, 117)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(99, 16)
        Me.label6.TabIndex = 50
        Me.label6.Text = "Server Host:"
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.Teal
        Me.btnTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTest.FlatAppearance.BorderSize = 0
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.Location = New System.Drawing.Point(62, 308)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(88, 32)
        Me.btnTest.TabIndex = 58
        Me.btnTest.Text = "TEST"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(167, 308)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Teal
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(272, 308)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmDatabaseConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 381)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txtServerHost)
        Me.Controls.Add(Me.label6)
        Me.MaximizeBox = False
        Me.Name = "frmDatabaseConfiguration"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Database Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDatabase As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label10 As Label
    Private WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label9 As Label
    Private WithEvents txtUserName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label8 As Label
    Private WithEvents txtServerHost As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label6 As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
