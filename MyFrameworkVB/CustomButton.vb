Imports System.Windows.Forms
Imports System.Drawing

Public Class CustomButton
    Inherits Button

    Public Sub CustomButton()
        Me.BackColor = System.Drawing.Color.FromArgb(0, 162, 166)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 170, 173)
        Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(23, 23, 23)
        Me.Image = My.Resources.dashboard
        Me.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Location = New System.Drawing.Point(4, 284)
        Me.Size = New System.Drawing.Size(230, 45)
        Me.TabIndex = 18
        Me.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UseVisualStyleBackColor = True
    End Sub

End Class
