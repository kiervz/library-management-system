<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.btnSecond = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.panelTop.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(577, 31)
        Me.panelTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(166, 15)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Library Management System"
        '
        'pbIcon
        '
        Me.pbIcon.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.alert
        Me.pbIcon.Location = New System.Drawing.Point(23, 58)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(58, 55)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIcon.TabIndex = 3
        Me.pbIcon.TabStop = False
        '
        'btnSecond
        '
        Me.btnSecond.AutoEllipsis = True
        Me.btnSecond.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSecond.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecond.FlatAppearance.BorderSize = 0
        Me.btnSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecond.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecond.ForeColor = System.Drawing.Color.White
        Me.btnSecond.Location = New System.Drawing.Point(454, 153)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(90, 28)
        Me.btnSecond.TabIndex = 4
        Me.btnSecond.Text = "CA&NCEL"
        Me.btnSecond.UseCompatibleTextRendering = True
        Me.btnSecond.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.AutoEllipsis = True
        Me.btnFirst.BackColor = System.Drawing.SystemColors.Control
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.FlatAppearance.BorderSize = 0
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFirst.Location = New System.Drawing.Point(358, 153)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(90, 28)
        Me.btnFirst.TabIndex = 5
        Me.btnFirst.Text = "&YES"
        Me.btnFirst.UseCompatibleTextRendering = True
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.White
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMessage.Enabled = False
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.Black
        Me.txtMessage.Location = New System.Drawing.Point(99, 62)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(445, 85)
        Me.txtMessage.TabIndex = 7
        Me.txtMessage.Text = "Are you sure you want to Delete?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnSecond)
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.panelTop)
        Me.DisplayHeader = False
        Me.KeyPreview = True
        Me.Movable = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMessageBox"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents btnSecond As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
End Class
