<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBorrowers
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBorrowers))
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.PanelStudentImport = New System.Windows.Forms.Panel()
        Me.txtPleasewaitS = New System.Windows.Forms.TextBox()
        Me.txtImportingS = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLoanHistoryStudent = New System.Windows.Forms.Button()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.PanelFacultyImport = New System.Windows.Forms.Panel()
        Me.txtPleasewait = New System.Windows.Forms.TextBox()
        Me.txtImporting = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLoanHistoryFaculty = New System.Windows.Forms.Button()
        Me.lblShowingNentries = New System.Windows.Forms.Label()
        Me.dgvFaculties = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnImportStudent = New System.Windows.Forms.Button()
        Me.cmbSearchStudent = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchStudent = New MetroFramework.Controls.MetroTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAddFaculty = New System.Windows.Forms.Button()
        Me.btnImportFaculties = New System.Windows.Forms.Button()
        Me.cmbSearchFaculty = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchFaculty = New MetroFramework.Controls.MetroTextBox()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.PanelStudentImport.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.PanelFacultyImport.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFaculties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(4, 67)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1120, 529)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 53
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.PanelStudentImport)
        Me.MetroTabPage1.Controls.Add(Me.btnLoanHistoryStudent)
        Me.MetroTabPage1.Controls.Add(Me.lblTotalStudents)
        Me.MetroTabPage1.Controls.Add(Me.dgvStudents)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1112, 484)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Student Management"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'PanelStudentImport
        '
        Me.PanelStudentImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.PanelStudentImport.Controls.Add(Me.txtPleasewaitS)
        Me.PanelStudentImport.Controls.Add(Me.txtImportingS)
        Me.PanelStudentImport.Controls.Add(Me.PictureBox1)
        Me.PanelStudentImport.Location = New System.Drawing.Point(408, 152)
        Me.PanelStudentImport.Name = "PanelStudentImport"
        Me.PanelStudentImport.Size = New System.Drawing.Size(238, 128)
        Me.PanelStudentImport.TabIndex = 90
        '
        'txtPleasewaitS
        '
        Me.txtPleasewaitS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtPleasewaitS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPleasewaitS.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPleasewaitS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPleasewaitS.ForeColor = System.Drawing.Color.White
        Me.txtPleasewaitS.Location = New System.Drawing.Point(2, 103)
        Me.txtPleasewaitS.Multiline = True
        Me.txtPleasewaitS.Name = "txtPleasewaitS"
        Me.txtPleasewaitS.Size = New System.Drawing.Size(235, 22)
        Me.txtPleasewaitS.TabIndex = 2
        Me.txtPleasewaitS.Text = "Please wait..."
        Me.txtPleasewaitS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImportingS
        '
        Me.txtImportingS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtImportingS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImportingS.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtImportingS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtImportingS.ForeColor = System.Drawing.Color.White
        Me.txtImportingS.Location = New System.Drawing.Point(3, 79)
        Me.txtImportingS.Multiline = True
        Me.txtImportingS.Name = "txtImportingS"
        Me.txtImportingS.Size = New System.Drawing.Size(235, 22)
        Me.txtImportingS.TabIndex = 1
        Me.txtImportingS.Text = "Importing 0 records"
        Me.txtImportingS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(71, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnLoanHistoryStudent
        '
        Me.btnLoanHistoryStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLoanHistoryStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanHistoryStudent.FlatAppearance.BorderSize = 0
        Me.btnLoanHistoryStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLoanHistoryStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoanHistoryStudent.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanHistoryStudent.ForeColor = System.Drawing.Color.White
        Me.btnLoanHistoryStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoanHistoryStudent.Location = New System.Drawing.Point(969, 446)
        Me.btnLoanHistoryStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLoanHistoryStudent.Name = "btnLoanHistoryStudent"
        Me.btnLoanHistoryStudent.Size = New System.Drawing.Size(121, 32)
        Me.btnLoanHistoryStudent.TabIndex = 95
        Me.btnLoanHistoryStudent.Text = "   Loan History"
        Me.btnLoanHistoryStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoanHistoryStudent.UseVisualStyleBackColor = False
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.BackColor = System.Drawing.Color.White
        Me.lblTotalStudents.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblTotalStudents.Location = New System.Drawing.Point(6, 453)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(218, 20)
        Me.lblTotalStudents.TabIndex = 92
        Me.lblTotalStudents.Text = "Showing 1 to 10 of 1000 entries"
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
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column9, Me.Column10})
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
        Me.dgvStudents.Location = New System.Drawing.Point(1, 7)
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
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvStudents.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStudents.RowTemplate.Height = 32
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.ShowCellErrors = False
        Me.dgvStudents.ShowEditingIcon = False
        Me.dgvStudents.ShowRowErrors = False
        Me.dgvStudents.Size = New System.Drawing.Size(1113, 429)
        Me.dgvStudents.TabIndex = 91
        '
        'Column1
        '
        Me.Column1.HeaderText = "Student ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Firstname"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 210
        '
        'Column3
        '
        Me.Column3.HeaderText = "Middlename"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 210
        '
        'Column4
        '
        Me.Column4.HeaderText = "Lastname"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 210
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gender"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Major"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column9
        '
        Me.Column9.HeaderText = "Edit"
        Me.Column9.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.edit
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "Delete"
        Me.Column10.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.delete
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column10.Width = 50
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.PanelFacultyImport)
        Me.MetroTabPage2.Controls.Add(Me.btnLoanHistoryFaculty)
        Me.MetroTabPage2.Controls.Add(Me.lblShowingNentries)
        Me.MetroTabPage2.Controls.Add(Me.dgvFaculties)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1112, 484)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Faculty Management"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'PanelFacultyImport
        '
        Me.PanelFacultyImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.PanelFacultyImport.Controls.Add(Me.txtPleasewait)
        Me.PanelFacultyImport.Controls.Add(Me.txtImporting)
        Me.PanelFacultyImport.Controls.Add(Me.PictureBox2)
        Me.PanelFacultyImport.Location = New System.Drawing.Point(408, 152)
        Me.PanelFacultyImport.Name = "PanelFacultyImport"
        Me.PanelFacultyImport.Size = New System.Drawing.Size(238, 128)
        Me.PanelFacultyImport.TabIndex = 91
        '
        'txtPleasewait
        '
        Me.txtPleasewait.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtPleasewait.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPleasewait.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPleasewait.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPleasewait.ForeColor = System.Drawing.Color.White
        Me.txtPleasewait.Location = New System.Drawing.Point(2, 103)
        Me.txtPleasewait.Multiline = True
        Me.txtPleasewait.Name = "txtPleasewait"
        Me.txtPleasewait.ReadOnly = True
        Me.txtPleasewait.Size = New System.Drawing.Size(235, 22)
        Me.txtPleasewait.TabIndex = 2
        Me.txtPleasewait.Text = "Please wait..."
        Me.txtPleasewait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImporting
        '
        Me.txtImporting.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.txtImporting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImporting.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtImporting.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtImporting.ForeColor = System.Drawing.Color.White
        Me.txtImporting.Location = New System.Drawing.Point(3, 79)
        Me.txtImporting.Multiline = True
        Me.txtImporting.Name = "txtImporting"
        Me.txtImporting.ReadOnly = True
        Me.txtImporting.Size = New System.Drawing.Size(235, 22)
        Me.txtImporting.TabIndex = 1
        Me.txtImporting.Text = "Importing 0 records"
        Me.txtImporting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(71, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'btnLoanHistoryFaculty
        '
        Me.btnLoanHistoryFaculty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoanHistoryFaculty.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLoanHistoryFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanHistoryFaculty.FlatAppearance.BorderSize = 0
        Me.btnLoanHistoryFaculty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLoanHistoryFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoanHistoryFaculty.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanHistoryFaculty.ForeColor = System.Drawing.Color.White
        Me.btnLoanHistoryFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoanHistoryFaculty.Location = New System.Drawing.Point(969, 446)
        Me.btnLoanHistoryFaculty.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLoanHistoryFaculty.Name = "btnLoanHistoryFaculty"
        Me.btnLoanHistoryFaculty.Size = New System.Drawing.Size(121, 32)
        Me.btnLoanHistoryFaculty.TabIndex = 94
        Me.btnLoanHistoryFaculty.Text = "   Loan History"
        Me.btnLoanHistoryFaculty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoanHistoryFaculty.UseVisualStyleBackColor = False
        '
        'lblShowingNentries
        '
        Me.lblShowingNentries.AutoSize = True
        Me.lblShowingNentries.BackColor = System.Drawing.Color.White
        Me.lblShowingNentries.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblShowingNentries.Location = New System.Drawing.Point(6, 453)
        Me.lblShowingNentries.Name = "lblShowingNentries"
        Me.lblShowingNentries.Size = New System.Drawing.Size(218, 20)
        Me.lblShowingNentries.TabIndex = 93
        Me.lblShowingNentries.Text = "Showing 1 to 10 of 1000 entries"
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
        Me.dgvFaculties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2})
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
        Me.dgvFaculties.Location = New System.Drawing.Point(1, 7)
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
        Me.dgvFaculties.Size = New System.Drawing.Size(1113, 425)
        Me.dgvFaculties.TabIndex = 92
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Edit"
        Me.DataGridViewImageColumn1.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Delete"
        Me.DataGridViewImageColumn2.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.delete
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 50
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
        Me.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStudent.Location = New System.Drawing.Point(985, 25)
        Me.btnAddStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(113, 35)
        Me.btnAddStudent.TabIndex = 62
        Me.btnAddStudent.Text = "ADD STUDENT"
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
        Me.btnImportStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportStudent.Location = New System.Drawing.Point(835, 25)
        Me.btnImportStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImportStudent.Name = "btnImportStudent"
        Me.btnImportStudent.Size = New System.Drawing.Size(143, 35)
        Me.btnImportStudent.TabIndex = 61
        Me.btnImportStudent.Text = "IMPORT STUDENTS"
        Me.btnImportStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportStudent.UseVisualStyleBackColor = False
        '
        'cmbSearchStudent
        '
        Me.cmbSearchStudent.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchStudent.FormattingEnabled = True
        Me.cmbSearchStudent.ItemHeight = 19
        Me.cmbSearchStudent.Items.AddRange(New Object() {"Select All", "Student ID", "Surname", "Firstname", "Middlename", "Major"})
        Me.cmbSearchStudent.Location = New System.Drawing.Point(9, 35)
        Me.cmbSearchStudent.Name = "cmbSearchStudent"
        Me.cmbSearchStudent.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchStudent.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchStudent.TabIndex = 64
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
        Me.txtSearchStudent.Location = New System.Drawing.Point(151, 35)
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
        Me.txtSearchStudent.TabIndex = 63
        Me.txtSearchStudent.UseSelectable = True
        Me.txtSearchStudent.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchStudent.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAddFaculty
        '
        Me.btnAddFaculty.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAddFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFaculty.FlatAppearance.BorderSize = 0
        Me.btnAddFaculty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAddFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFaculty.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFaculty.ForeColor = System.Drawing.Color.White
        Me.btnAddFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddFaculty.Location = New System.Drawing.Point(985, 25)
        Me.btnAddFaculty.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddFaculty.Name = "btnAddFaculty"
        Me.btnAddFaculty.Size = New System.Drawing.Size(113, 35)
        Me.btnAddFaculty.TabIndex = 69
        Me.btnAddFaculty.Text = "ADD FACULTY"
        Me.btnAddFaculty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddFaculty.UseVisualStyleBackColor = False
        '
        'btnImportFaculties
        '
        Me.btnImportFaculties.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnImportFaculties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportFaculties.FlatAppearance.BorderSize = 0
        Me.btnImportFaculties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnImportFaculties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportFaculties.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportFaculties.ForeColor = System.Drawing.Color.White
        Me.btnImportFaculties.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportFaculties.Location = New System.Drawing.Point(835, 25)
        Me.btnImportFaculties.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImportFaculties.Name = "btnImportFaculties"
        Me.btnImportFaculties.Size = New System.Drawing.Size(143, 35)
        Me.btnImportFaculties.TabIndex = 68
        Me.btnImportFaculties.Text = "IMPORT FACULTIES"
        Me.btnImportFaculties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportFaculties.UseVisualStyleBackColor = False
        '
        'cmbSearchFaculty
        '
        Me.cmbSearchFaculty.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchFaculty.FormattingEnabled = True
        Me.cmbSearchFaculty.ItemHeight = 19
        Me.cmbSearchFaculty.Items.AddRange(New Object() {"Select All", "Faculty ID", "Surname", "Firstname", "Middlename"})
        Me.cmbSearchFaculty.Location = New System.Drawing.Point(9, 35)
        Me.cmbSearchFaculty.Name = "cmbSearchFaculty"
        Me.cmbSearchFaculty.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchFaculty.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchFaculty.TabIndex = 70
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
        Me.txtSearchFaculty.Location = New System.Drawing.Point(151, 35)
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
        Me.txtSearchFaculty.TabIndex = 71
        Me.txtSearchFaculty.UseSelectable = True
        Me.txtSearchFaculty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchFaculty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Edit"
        Me.DataGridViewImageColumn3.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.edit
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.Width = 50
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = "Delete"
        Me.DataGridViewImageColumn4.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.delete
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn4.Width = 50
        '
        'ucBorrowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.btnAddFaculty)
        Me.Controls.Add(Me.txtSearchStudent)
        Me.Controls.Add(Me.txtSearchFaculty)
        Me.Controls.Add(Me.cmbSearchStudent)
        Me.Controls.Add(Me.cmbSearchFaculty)
        Me.Controls.Add(Me.btnImportStudent)
        Me.Controls.Add(Me.btnImportFaculties)
        Me.Name = "ucBorrowers"
        Me.Size = New System.Drawing.Size(1126, 599)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.PanelStudentImport.ResumeLayout(False)
        Me.PanelStudentImport.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.PanelFacultyImport.ResumeLayout(False)
        Me.PanelFacultyImport.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFaculties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PanelStudentImport As Panel
    Friend WithEvents txtPleasewaitS As TextBox
    Friend WithEvents txtImportingS As TextBox
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents PanelFacultyImport As Panel
    Friend WithEvents txtPleasewait As TextBox
    Friend WithEvents txtImporting As TextBox
    Friend WithEvents dgvFaculties As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Private WithEvents btnAddStudent As Button
    Private WithEvents btnImportStudent As Button
    Private WithEvents cmbSearchStudent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchStudent As MetroFramework.Controls.MetroTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Private WithEvents btnAddFaculty As Button
    Private WithEvents btnImportFaculties As Button
    Friend WithEvents lblShowingNentries As Label
    Private WithEvents btnLoanHistoryFaculty As Button
    Private WithEvents btnLoanHistoryStudent As Button
    Private WithEvents cmbSearchFaculty As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchFaculty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
    Friend WithEvents Column10 As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
