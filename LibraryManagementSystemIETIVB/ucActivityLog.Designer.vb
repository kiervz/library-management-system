<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucActivityLog
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
        Me.dgvLoginout = New MetroFramework.Controls.MetroGrid()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtDate = New MetroFramework.Controls.MetroDateTime()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFilterBy = New MetroFramework.Controls.MetroComboBox()
        Me.dgvActivityLog = New MetroFramework.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.dgvLoginout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.dgvActivityLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(10, 67)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1106, 486)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 53
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.dgvLoginout)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1098, 441)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Log In && Out History"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'dgvLoginout
        '
        Me.dgvLoginout.AllowUserToAddRows = False
        Me.dgvLoginout.AllowUserToDeleteRows = False
        Me.dgvLoginout.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvLoginout.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLoginout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLoginout.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLoginout.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLoginout.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvLoginout.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoginout.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLoginout.ColumnHeadersHeight = 28
        Me.dgvLoginout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLoginout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLoginout.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLoginout.EnableHeadersVisualStyles = False
        Me.dgvLoginout.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvLoginout.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLoginout.Location = New System.Drawing.Point(1, 7)
        Me.dgvLoginout.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvLoginout.MultiSelect = False
        Me.dgvLoginout.Name = "dgvLoginout"
        Me.dgvLoginout.ReadOnly = True
        Me.dgvLoginout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoginout.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLoginout.RowHeadersVisible = False
        Me.dgvLoginout.RowHeadersWidth = 23
        Me.dgvLoginout.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvLoginout.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLoginout.RowTemplate.Height = 32
        Me.dgvLoginout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoginout.ShowCellErrors = False
        Me.dgvLoginout.ShowEditingIcon = False
        Me.dgvLoginout.ShowRowErrors = False
        Me.dgvLoginout.Size = New System.Drawing.Size(1092, 423)
        Me.dgvLoginout.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvLoginout.TabIndex = 50
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Label1)
        Me.MetroTabPage2.Controls.Add(Me.dtDate)
        Me.MetroTabPage2.Controls.Add(Me.Label3)
        Me.MetroTabPage2.Controls.Add(Me.cmbFilterBy)
        Me.MetroTabPage2.Controls.Add(Me.dgvActivityLog)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1098, 441)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Activity Log"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(917, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Date:"
        '
        'dtDate
        '
        Me.dtDate.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(972, 3)
        Me.dtDate.MinimumSize = New System.Drawing.Size(4, 25)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(98, 25)
        Me.dtDate.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Filter By:"
        '
        'cmbFilterBy
        '
        Me.cmbFilterBy.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbFilterBy.FormattingEnabled = True
        Me.cmbFilterBy.ItemHeight = 19
        Me.cmbFilterBy.Items.AddRange(New Object() {"All", "User Management", "Borrower Management", "Book Entry", "Issued && Return", "Attendance Report", "Books Inventory Report", "Borrowed Books Report", "Faculty Master List Report", "Student Master List Report", "Penalty List Report"})
        Me.cmbFilterBy.Location = New System.Drawing.Point(108, 2)
        Me.cmbFilterBy.Name = "cmbFilterBy"
        Me.cmbFilterBy.Size = New System.Drawing.Size(239, 25)
        Me.cmbFilterBy.TabIndex = 208
        Me.cmbFilterBy.UseSelectable = True
        '
        'dgvActivityLog
        '
        Me.dgvActivityLog.AllowUserToAddRows = False
        Me.dgvActivityLog.AllowUserToDeleteRows = False
        Me.dgvActivityLog.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvActivityLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvActivityLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActivityLog.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivityLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvActivityLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvActivityLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivityLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvActivityLog.ColumnHeadersHeight = 28
        Me.dgvActivityLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvActivityLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActivityLog.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvActivityLog.EnableHeadersVisualStyles = False
        Me.dgvActivityLog.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvActivityLog.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivityLog.Location = New System.Drawing.Point(1, 31)
        Me.dgvActivityLog.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvActivityLog.MultiSelect = False
        Me.dgvActivityLog.Name = "dgvActivityLog"
        Me.dgvActivityLog.ReadOnly = True
        Me.dgvActivityLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivityLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvActivityLog.RowHeadersVisible = False
        Me.dgvActivityLog.RowHeadersWidth = 23
        Me.dgvActivityLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvActivityLog.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvActivityLog.RowTemplate.Height = 32
        Me.dgvActivityLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivityLog.ShowCellErrors = False
        Me.dgvActivityLog.ShowEditingIcon = False
        Me.dgvActivityLog.ShowRowErrors = False
        Me.dgvActivityLog.Size = New System.Drawing.Size(1092, 392)
        Me.dgvActivityLog.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvActivityLog.TabIndex = 51
        '
        'Column7
        '
        Me.Column7.HeaderText = "#"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Process By"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 170
        '
        'Column9
        '
        Me.Column9.HeaderText = "Activities"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 500
        '
        'Column10
        '
        Me.Column10.HeaderText = "Date"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 150
        '
        'Column11
        '
        Me.Column11.HeaderText = "Time"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "User ID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 370
        '
        'Column3
        '
        Me.Column3.HeaderText = "Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Time In"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Time Out"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'ucActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "ucActivityLog"
        Me.Size = New System.Drawing.Size(1126, 599)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.dgvLoginout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.dgvActivityLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvLoginout As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvActivityLog As MetroFramework.Controls.MetroGrid
    Private WithEvents cmbFilterBy As MetroFramework.Controls.MetroComboBox
    Private WithEvents Label3 As Label
    Friend WithEvents dtDate As MetroFramework.Controls.MetroDateTime
    Private WithEvents Label1 As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
