<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendSMS
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
        Me.components = New System.ComponentModel.Container()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBorrowersName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSendSMS = New System.Windows.Forms.Button()
        Me.cmbPorts = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(357, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 17)
        Me.btnClose.TabIndex = 199
        Me.btnClose.Text = "[ Close ]"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(58, 168)
        Me.txtPhone.MaxLength = 30
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(322, 23)
        Me.txtPhone.TabIndex = 200
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "Phone Number:"
        '
        'txtBorrowersName
        '
        Me.txtBorrowersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBorrowersName.Enabled = False
        Me.txtBorrowersName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowersName.Location = New System.Drawing.Point(58, 223)
        Me.txtBorrowersName.MaxLength = 100
        Me.txtBorrowersName.Name = "txtBorrowersName"
        Me.txtBorrowersName.Size = New System.Drawing.Size(322, 23)
        Me.txtBorrowersName.TabIndex = 202
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Borrower's Name:"
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(58, 285)
        Me.txtMessage.MaxLength = 170
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(322, 126)
        Me.txtMessage.TabIndex = 204
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Message:"
        '
        'btnSendSMS
        '
        Me.btnSendSMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSendSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendSMS.FlatAppearance.BorderSize = 0
        Me.btnSendSMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSendSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendSMS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendSMS.ForeColor = System.Drawing.Color.White
        Me.btnSendSMS.Location = New System.Drawing.Point(277, 426)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(103, 26)
        Me.btnSendSMS.TabIndex = 206
        Me.btnSendSMS.Text = "SEND"
        Me.btnSendSMS.UseVisualStyleBackColor = False
        '
        'cmbPorts
        '
        Me.cmbPorts.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbPorts.FormattingEnabled = True
        Me.cmbPorts.ItemHeight = 19
        Me.cmbPorts.Location = New System.Drawing.Point(58, 109)
        Me.cmbPorts.Name = "cmbPorts"
        Me.cmbPorts.Size = New System.Drawing.Size(322, 25)
        Me.cmbPorts.TabIndex = 207
        Me.cmbPorts.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "Select Port:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(141, 89)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(0, 17)
        Me.lblPort.TabIndex = 209
        '
        'SerialPort1
        '
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(196, 89)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        Me.lblStatus.TabIndex = 210
        '
        'frmSendSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbPorts)
        Me.Controls.Add(Me.btnSendSMS)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBorrowersName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClose)
        Me.MaximizeBox = False
        Me.Name = "frmSendSMS"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Send SMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnClose As Label
    Friend WithEvents txtPhone As TextBox
    Private WithEvents Label10 As Label
    Friend WithEvents txtBorrowersName As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtMessage As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents btnSendSMS As Button
    Private WithEvents cmbPorts As MetroFramework.Controls.MetroComboBox
    Private WithEvents Label3 As Label
    Private WithEvents lblPort As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Private WithEvents lblStatus As Label
End Class
