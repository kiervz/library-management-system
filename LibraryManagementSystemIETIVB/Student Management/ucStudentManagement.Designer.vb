﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucStudentManagement))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPleasewait = New System.Windows.Forms.TextBox()
        Me.txtImporting = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvStudents = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbSearchBy = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnImportStudent = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtPleasewait)
        Me.Panel1.Controls.Add(Me.txtImporting)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(422, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 128)
        Me.Panel1.TabIndex = 59
        '
        'txtPleasewait
        '
        Me.txtPleasewait.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtPleasewait.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPleasewait.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPleasewait.ForeColor = System.Drawing.Color.White
        Me.txtPleasewait.Location = New System.Drawing.Point(2, 103)
        Me.txtPleasewait.Multiline = True
        Me.txtPleasewait.Name = "txtPleasewait"
        Me.txtPleasewait.Size = New System.Drawing.Size(235, 22)
        Me.txtPleasewait.TabIndex = 2
        Me.txtPleasewait.Text = "Please wait..."
        Me.txtPleasewait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImporting
        '
        Me.txtImporting.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtImporting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImporting.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtImporting.ForeColor = System.Drawing.Color.White
        Me.txtImporting.Location = New System.Drawing.Point(3, 79)
        Me.txtImporting.Multiline = True
        Me.txtImporting.Name = "txtImporting"
        Me.txtImporting.Size = New System.Drawing.Size(235, 22)
        Me.txtImporting.TabIndex = 1
        Me.txtImporting.Text = "Importing 0 records"
        Me.txtImporting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(71, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudents.ColumnHeadersHeight = 28
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column3, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudents.EnableHeadersVisualStyles = False
        Me.dgvStudents.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvStudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudents.Location = New System.Drawing.Point(10, 76)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowHeadersWidth = 23
        Me.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvStudents.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStudents.RowTemplate.Height = 32
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.ShowCellErrors = False
        Me.dgvStudents.ShowEditingIcon = False
        Me.dgvStudents.ShowRowErrors = False
        Me.dgvStudents.Size = New System.Drawing.Size(1116, 483)
        Me.dgvStudents.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvStudents.TabIndex = 57
        Me.dgvStudents.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 61
        '
        'Column2
        '
        Me.Column2.HeaderText = "Student ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Firstname"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 190
        '
        'Column5
        '
        Me.Column5.HeaderText = "Middlename"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 190
        '
        'Column3
        '
        Me.Column3.HeaderText = "Surname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 190
        '
        'Column6
        '
        Me.Column6.HeaderText = "Gender"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "Course"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 90
        '
        'Column8
        '
        Me.Column8.HeaderText = "Year"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 90
        '
        'Column9
        '
        Me.Column9.HeaderText = "Section"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 90
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "STUDENT MANAGEMENT"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.ItemHeight = 19
        Me.cmbSearchBy.Items.AddRange(New Object() {"Student ID", "Surname", "Firstname", "Middlename", "Course", "Year", "Section"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(10, 43)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.PromptText = "Search By"
        Me.cmbSearchBy.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchBy.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchBy.TabIndex = 62
        Me.cmbSearchBy.UseSelectable = True
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(216, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(152, 43)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(240, 25)
        Me.txtSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.txtSearch.TabIndex = 61
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.UseStyleColors = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStudent.FlatAppearance.BorderSize = 0
        Me.btnAddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudent.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.Color.White
        Me.btnAddStudent.Image = CType(resources.GetObject("btnAddStudent.Image"), System.Drawing.Image)
        Me.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStudent.Location = New System.Drawing.Point(961, 33)
        Me.btnAddStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(130, 35)
        Me.btnAddStudent.TabIndex = 60
        Me.btnAddStudent.Text = " ADD STUDENT"
        Me.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnImportStudent
        '
        Me.btnImportStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnImportStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportStudent.FlatAppearance.BorderSize = 0
        Me.btnImportStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnImportStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportStudent.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportStudent.ForeColor = System.Drawing.Color.White
        Me.btnImportStudent.Image = CType(resources.GetObject("btnImportStudent.Image"), System.Drawing.Image)
        Me.btnImportStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportStudent.Location = New System.Drawing.Point(799, 33)
        Me.btnImportStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImportStudent.Name = "btnImportStudent"
        Me.btnImportStudent.Size = New System.Drawing.Size(156, 35)
        Me.btnImportStudent.TabIndex = 58
        Me.btnImportStudent.Text = " IMPORT STUDENTS"
        Me.btnImportStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportStudent.UseVisualStyleBackColor = False
        '
        'ucStudentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbSearchBy)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnImportStudent)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucStudentManagement"
        Me.Size = New System.Drawing.Size(1126, 599)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPleasewait As TextBox
    Friend WithEvents txtImporting As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents btnImportStudent As Button
    Friend WithEvents dgvStudents As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Private WithEvents btnAddStudent As Button
    Private WithEvents cmbSearchBy As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
End Class
