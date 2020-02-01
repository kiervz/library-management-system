<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
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
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
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
        'txtIdleTime
        '
        Me.txtIdleTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdleTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdleTime.Location = New System.Drawing.Point(640, 233)
        Me.txtIdleTime.MaxLength = 30
        Me.txtIdleTime.Name = "txtIdleTime"
        Me.txtIdleTime.Size = New System.Drawing.Size(207, 26)
        Me.txtIdleTime.TabIndex = 187
        Me.txtIdleTime.Text = "300"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 20)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "Maximum idle time in seconds"
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
        Me.btnSave.Location = New System.Drawing.Point(761, 309)
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
        Me.txtPenaltyPerDay.Location = New System.Drawing.Point(640, 177)
        Me.txtPenaltyPerDay.MaxLength = 30
        Me.txtPenaltyPerDay.Name = "txtPenaltyPerDay"
        Me.txtPenaltyPerDay.Size = New System.Drawing.Size(207, 26)
        Me.txtPenaltyPerDay.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "Penalty per day"
        '
        'txtNoDaysAllowed
        '
        Me.txtNoDaysAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoDaysAllowed.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDaysAllowed.Location = New System.Drawing.Point(640, 121)
        Me.txtNoDaysAllowed.MaxLength = 30
        Me.txtNoDaysAllowed.Name = "txtNoDaysAllowed"
        Me.txtNoDaysAllowed.Size = New System.Drawing.Size(207, 26)
        Me.txtNoDaysAllowed.TabIndex = 165
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "No. of days allowed "
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
        Me.label1.Size = New System.Drawing.Size(248, 20)
        Me.label1.TabIndex = 164
        Me.label1.Text = "No. of Book/s allowed to borrow"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BackColor = System.Drawing.Color.White
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
End Class
