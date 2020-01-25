<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucFacultyManagement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucFacultyManagement))
        Me.cmbSearchBy = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPleasewait = New System.Windows.Forms.TextBox()
        Me.txtImporting = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblPages = New System.Windows.Forms.Label()
        Me.lblShowingNentries = New System.Windows.Forms.Label()
        Me.txtCurrentPage = New System.Windows.Forms.TextBox()
        Me.dgvFaculties = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnAddFaculty = New System.Windows.Forms.Button()
        Me.btnImportFaculties = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvFaculties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.ItemHeight = 19
        Me.cmbSearchBy.Items.AddRange(New Object() {"Student ID", "Surname", "Firstname", "Middlename", "Course", "Year", "Section"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(10, 35)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.PromptText = "Search By"
        Me.cmbSearchBy.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchBy.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchBy.TabIndex = 69
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
        Me.txtSearch.Location = New System.Drawing.Point(152, 35)
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
        Me.txtSearch.TabIndex = 68
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.UseStyleColors = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtPleasewait)
        Me.Panel1.Controls.Add(Me.txtImporting)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(422, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 128)
        Me.Panel1.TabIndex = 66
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblPages
        '
        Me.lblPages.AutoSize = True
        Me.lblPages.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPages.Location = New System.Drawing.Point(854, 556)
        Me.lblPages.Name = "lblPages"
        Me.lblPages.Size = New System.Drawing.Size(48, 17)
        Me.lblPages.TabIndex = 72
        Me.lblPages.Text = "Page 1"
        '
        'lblShowingNentries
        '
        Me.lblShowingNentries.AutoSize = True
        Me.lblShowingNentries.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowingNentries.Location = New System.Drawing.Point(42, 556)
        Me.lblShowingNentries.Name = "lblShowingNentries"
        Me.lblShowingNentries.Size = New System.Drawing.Size(193, 17)
        Me.lblShowingNentries.TabIndex = 77
        Me.lblShowingNentries.Text = "Showing 1 to 10 of 1000 entries"
        '
        'txtCurrentPage
        '
        Me.txtCurrentPage.BackColor = System.Drawing.Color.White
        Me.txtCurrentPage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrentPage.Enabled = False
        Me.txtCurrentPage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPage.Location = New System.Drawing.Point(511, 555)
        Me.txtCurrentPage.Name = "txtCurrentPage"
        Me.txtCurrentPage.Size = New System.Drawing.Size(77, 20)
        Me.txtCurrentPage.TabIndex = 78
        Me.txtCurrentPage.Text = "Page 1"
        Me.txtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvFaculties
        '
        Me.dgvFaculties.AllowUserToAddRows = False
        Me.dgvFaculties.AllowUserToDeleteRows = False
        Me.dgvFaculties.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFaculties.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFaculties.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvFaculties.BackgroundColor = System.Drawing.Color.White
        Me.dgvFaculties.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFaculties.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFaculties.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFaculties.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFaculties.ColumnHeadersHeight = 28
        Me.dgvFaculties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFaculties.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFaculties.EnableHeadersVisualStyles = False
        Me.dgvFaculties.GridColor = System.Drawing.Color.White
        Me.dgvFaculties.Location = New System.Drawing.Point(10, 66)
        Me.dgvFaculties.MultiSelect = False
        Me.dgvFaculties.Name = "dgvFaculties"
        Me.dgvFaculties.ReadOnly = True
        Me.dgvFaculties.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFaculties.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFaculties.RowHeadersVisible = False
        Me.dgvFaculties.RowHeadersWidth = 23
        Me.dgvFaculties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFaculties.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFaculties.RowTemplate.Height = 32
        Me.dgvFaculties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFaculties.ShowCellErrors = False
        Me.dgvFaculties.ShowEditingIcon = False
        Me.dgvFaculties.ShowRowErrors = False
        Me.dgvFaculties.Size = New System.Drawing.Size(1116, 469)
        Me.dgvFaculties.TabIndex = 90
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Column1"
        Me.DataGridViewImageColumn1.Image = Global.LibraryManagementSystemIETIVB.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
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
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.Location = New System.Drawing.Point(593, 549)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(33, 30)
        Me.btnNext.TabIndex = 71
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Image = CType(resources.GetObject("btnPrev.Image"), System.Drawing.Image)
        Me.btnPrev.Location = New System.Drawing.Point(471, 549)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(33, 30)
        Me.btnPrev.TabIndex = 70
        Me.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrev.UseVisualStyleBackColor = False
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
        Me.btnAddFaculty.Image = CType(resources.GetObject("btnAddFaculty.Image"), System.Drawing.Image)
        Me.btnAddFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddFaculty.Location = New System.Drawing.Point(961, 25)
        Me.btnAddFaculty.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddFaculty.Name = "btnAddFaculty"
        Me.btnAddFaculty.Size = New System.Drawing.Size(130, 35)
        Me.btnAddFaculty.TabIndex = 67
        Me.btnAddFaculty.Text = " ADD FACULTY"
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
        Me.btnImportFaculties.Image = CType(resources.GetObject("btnImportFaculties.Image"), System.Drawing.Image)
        Me.btnImportFaculties.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportFaculties.Location = New System.Drawing.Point(794, 25)
        Me.btnImportFaculties.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImportFaculties.Name = "btnImportFaculties"
        Me.btnImportFaculties.Size = New System.Drawing.Size(160, 35)
        Me.btnImportFaculties.TabIndex = 65
        Me.btnImportFaculties.Text = " IMPORT FACULTIES"
        Me.btnImportFaculties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportFaculties.UseVisualStyleBackColor = False
        '
        'ucFacultyManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCurrentPage)
        Me.Controls.Add(Me.lblShowingNentries)
        Me.Controls.Add(Me.lblPages)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.cmbSearchBy)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAddFaculty)
        Me.Controls.Add(Me.btnImportFaculties)
        Me.Controls.Add(Me.dgvFaculties)
        Me.Name = "ucFacultyManagement"
        Me.Size = New System.Drawing.Size(1126, 599)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvFaculties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmbSearchBy As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Private WithEvents btnAddFaculty As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPleasewait As TextBox
    Friend WithEvents txtImporting As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents btnImportFaculties As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Private WithEvents btnPrev As Button
    Private WithEvents btnNext As Button
    Friend WithEvents lblPages As Label
    Friend WithEvents lblShowingNentries As Label
    Friend WithEvents txtCurrentPage As TextBox
    Friend WithEvents dgvFaculties As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
