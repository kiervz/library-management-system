﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBorrowerList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmbSearchStudent = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchStudent = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.cmbSearchFaculty = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchFaculty = New MetroFramework.Controls.MetroTextBox()
        Me.dgvFaculties = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.dgvFaculties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudents.ColumnHeadersHeight = 28
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudents.EnableHeadersVisualStyles = False
        Me.dgvStudents.GridColor = System.Drawing.Color.White
        Me.dgvStudents.Location = New System.Drawing.Point(6, 40)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowHeadersWidth = 23
        Me.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvStudents.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStudents.RowTemplate.Height = 32
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.ShowCellErrors = False
        Me.dgvStudents.ShowEditingIcon = False
        Me.dgvStudents.ShowRowErrors = False
        Me.dgvStudents.Size = New System.Drawing.Size(1015, 424)
        Me.dgvStudents.TabIndex = 90
        '
        'Column1
        '
        Me.Column1.HeaderText = "Student ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Firstname"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 230
        '
        'Column3
        '
        Me.Column3.HeaderText = "Middlename"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 230
        '
        'Column4
        '
        Me.Column4.HeaderText = "Lastname"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 230
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gender"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Major"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1029, 526)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 91
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.cmbSearchStudent)
        Me.MetroTabPage1.Controls.Add(Me.txtSearchStudent)
        Me.MetroTabPage1.Controls.Add(Me.dgvStudents)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1021, 481)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Students"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'cmbSearchStudent
        '
        Me.cmbSearchStudent.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchStudent.FormattingEnabled = True
        Me.cmbSearchStudent.ItemHeight = 19
        Me.cmbSearchStudent.Items.AddRange(New Object() {"Student ID", "Surname", "Firstname", "Middlename", "Major"})
        Me.cmbSearchStudent.Location = New System.Drawing.Point(615, 9)
        Me.cmbSearchStudent.Name = "cmbSearchStudent"
        Me.cmbSearchStudent.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchStudent.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchStudent.TabIndex = 92
        Me.cmbSearchStudent.UseSelectable = True
        '
        'txtSearchStudent
        '
        '
        '
        '
        Me.txtSearchStudent.CustomButton.Image = Nothing
        Me.txtSearchStudent.CustomButton.Location = New System.Drawing.Point(216, 1)
        Me.txtSearchStudent.CustomButton.Name = ""
        Me.txtSearchStudent.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSearchStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchStudent.CustomButton.TabIndex = 1
        Me.txtSearchStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchStudent.CustomButton.UseSelectable = True
        Me.txtSearchStudent.CustomButton.Visible = False
        Me.txtSearchStudent.Lines = New String(-1) {}
        Me.txtSearchStudent.Location = New System.Drawing.Point(757, 9)
        Me.txtSearchStudent.MaxLength = 50
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchStudent.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchStudent.SelectedText = ""
        Me.txtSearchStudent.SelectionLength = 0
        Me.txtSearchStudent.SelectionStart = 0
        Me.txtSearchStudent.ShortcutsEnabled = True
        Me.txtSearchStudent.Size = New System.Drawing.Size(240, 25)
        Me.txtSearchStudent.Style = MetroFramework.MetroColorStyle.Teal
        Me.txtSearchStudent.TabIndex = 91
        Me.txtSearchStudent.UseSelectable = True
        Me.txtSearchStudent.UseStyleColors = True
        Me.txtSearchStudent.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchStudent.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.cmbSearchFaculty)
        Me.MetroTabPage2.Controls.Add(Me.txtSearchFaculty)
        Me.MetroTabPage2.Controls.Add(Me.dgvFaculties)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1021, 481)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Faculties"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'cmbSearchFaculty
        '
        Me.cmbSearchFaculty.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchFaculty.FormattingEnabled = True
        Me.cmbSearchFaculty.ItemHeight = 19
        Me.cmbSearchFaculty.Items.AddRange(New Object() {"Faculty ID", "Surname", "Firstname", "Middlename"})
        Me.cmbSearchFaculty.Location = New System.Drawing.Point(615, 9)
        Me.cmbSearchFaculty.Name = "cmbSearchFaculty"
        Me.cmbSearchFaculty.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchFaculty.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchFaculty.TabIndex = 93
        Me.cmbSearchFaculty.UseSelectable = True
        '
        'txtSearchFaculty
        '
        '
        '
        '
        Me.txtSearchFaculty.CustomButton.Image = Nothing
        Me.txtSearchFaculty.CustomButton.Location = New System.Drawing.Point(216, 1)
        Me.txtSearchFaculty.CustomButton.Name = ""
        Me.txtSearchFaculty.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSearchFaculty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchFaculty.CustomButton.TabIndex = 1
        Me.txtSearchFaculty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchFaculty.CustomButton.UseSelectable = True
        Me.txtSearchFaculty.CustomButton.Visible = False
        Me.txtSearchFaculty.Lines = New String(-1) {}
        Me.txtSearchFaculty.Location = New System.Drawing.Point(757, 9)
        Me.txtSearchFaculty.MaxLength = 50
        Me.txtSearchFaculty.Name = "txtSearchFaculty"
        Me.txtSearchFaculty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchFaculty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchFaculty.SelectedText = ""
        Me.txtSearchFaculty.SelectionLength = 0
        Me.txtSearchFaculty.SelectionStart = 0
        Me.txtSearchFaculty.ShortcutsEnabled = True
        Me.txtSearchFaculty.Size = New System.Drawing.Size(240, 25)
        Me.txtSearchFaculty.Style = MetroFramework.MetroColorStyle.Teal
        Me.txtSearchFaculty.TabIndex = 92
        Me.txtSearchFaculty.UseSelectable = True
        Me.txtSearchFaculty.UseStyleColors = True
        Me.txtSearchFaculty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchFaculty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvFaculties
        '
        Me.dgvFaculties.AllowUserToAddRows = False
        Me.dgvFaculties.AllowUserToDeleteRows = False
        Me.dgvFaculties.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFaculties.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFaculties.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvFaculties.BackgroundColor = System.Drawing.Color.White
        Me.dgvFaculties.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFaculties.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFaculties.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFaculties.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFaculties.ColumnHeadersHeight = 28
        Me.dgvFaculties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFaculties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFaculties.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvFaculties.EnableHeadersVisualStyles = False
        Me.dgvFaculties.GridColor = System.Drawing.Color.White
        Me.dgvFaculties.Location = New System.Drawing.Point(6, 40)
        Me.dgvFaculties.MultiSelect = False
        Me.dgvFaculties.Name = "dgvFaculties"
        Me.dgvFaculties.ReadOnly = True
        Me.dgvFaculties.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFaculties.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvFaculties.RowHeadersVisible = False
        Me.dgvFaculties.RowHeadersWidth = 23
        Me.dgvFaculties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFaculties.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvFaculties.RowTemplate.Height = 32
        Me.dgvFaculties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFaculties.ShowCellErrors = False
        Me.dgvFaculties.ShowEditingIcon = False
        Me.dgvFaculties.ShowRowErrors = False
        Me.dgvFaculties.Size = New System.Drawing.Size(1015, 424)
        Me.dgvFaculties.TabIndex = 91
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Faculty ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 230
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Middlename"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 230
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lastname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 230
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Birthday"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(994, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 17)
        Me.btnClose.TabIndex = 239
        Me.btnClose.Text = "[ Close ]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(30, 602)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 18)
        Me.Label10.TabIndex = 240
        Me.Label10.Text = "Note: Double click to select borrower"
        '
        'frmBorrowerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmBorrowerList"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Borrower List"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        CType(Me.dgvFaculties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvFaculties As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Private WithEvents btnClose As Label
    Private WithEvents Label10 As Label
    Private WithEvents cmbSearchFaculty As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchFaculty As MetroFramework.Controls.MetroTextBox
    Private WithEvents cmbSearchStudent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchStudent As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
