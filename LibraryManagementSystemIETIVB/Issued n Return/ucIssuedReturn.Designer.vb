<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucIssuedReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucIssuedReturn))
        Me.dgvBorrows = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtYearSec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbBrowsePic = New System.Windows.Forms.PictureBox()
        Me.lblLookUpBorrowers = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.txtPenaltyDay = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDayAllowed = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBookAllowed = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCallNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panelNoRecord = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ConfirmReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvBorrows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBrowsePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNoRecord.SuspendLayout()
        Me.MaterialContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBorrows
        '
        Me.dgvBorrows.AllowUserToAddRows = False
        Me.dgvBorrows.AllowUserToDeleteRows = False
        Me.dgvBorrows.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBorrows.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBorrows.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvBorrows.BackgroundColor = System.Drawing.Color.White
        Me.dgvBorrows.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBorrows.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBorrows.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrows.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBorrows.ColumnHeadersHeight = 28
        Me.dgvBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBorrows.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrows.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBorrows.EnableHeadersVisualStyles = False
        Me.dgvBorrows.GridColor = System.Drawing.Color.White
        Me.dgvBorrows.Location = New System.Drawing.Point(7, 311)
        Me.dgvBorrows.MultiSelect = False
        Me.dgvBorrows.Name = "dgvBorrows"
        Me.dgvBorrows.ReadOnly = True
        Me.dgvBorrows.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrows.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBorrows.RowHeadersVisible = False
        Me.dgvBorrows.RowHeadersWidth = 23
        Me.dgvBorrows.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBorrows.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBorrows.RowTemplate.Height = 32
        Me.dgvBorrows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrows.ShowCellErrors = False
        Me.dgvBorrows.ShowEditingIcon = False
        Me.dgvBorrows.ShowRowErrors = False
        Me.dgvBorrows.Size = New System.Drawing.Size(1113, 282)
        Me.dgvBorrows.TabIndex = 91
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "ISBN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.HeaderText = "Title"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 290
        '
        'Column4
        '
        Me.Column4.HeaderText = "Author"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 140
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date Borrowed"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 140
        '
        'Column6
        '
        Me.Column6.HeaderText = "Due Date"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 140
        '
        'Column7
        '
        Me.Column7.HeaderText = "Penalty"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 70
        '
        'Column8
        '
        Me.Column8.HeaderText = "Issued By"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Return"
        Me.Column10.Image = CType(resources.GetObject("Column10.Image"), System.Drawing.Image)
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column10.Width = 50
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Teal
        Me.label6.Location = New System.Drawing.Point(202, 16)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(161, 21)
        Me.label6.TabIndex = 92
        Me.label6.Text = "Borrower Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(766, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Book Information"
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBorrowerID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerID.Location = New System.Drawing.Point(153, 67)
        Me.txtBorrowerID.MaxLength = 30
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(211, 26)
        Me.txtBorrowerID.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Borrower ID"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(153, 106)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(383, 26)
        Me.txtName.TabIndex = 163
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Name"
        '
        'txtYearSec
        '
        Me.txtYearSec.BackColor = System.Drawing.SystemColors.Control
        Me.txtYearSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYearSec.Enabled = False
        Me.txtYearSec.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearSec.ForeColor = System.Drawing.Color.Black
        Me.txtYearSec.Location = New System.Drawing.Point(153, 145)
        Me.txtYearSec.MaxLength = 30
        Me.txtYearSec.Name = "txtYearSec"
        Me.txtYearSec.Size = New System.Drawing.Size(383, 26)
        Me.txtYearSec.TabIndex = 165
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Major"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Type"
        '
        'txtPenalty
        '
        Me.txtPenalty.BackColor = System.Drawing.SystemColors.Control
        Me.txtPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenalty.Enabled = False
        Me.txtPenalty.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.ForeColor = System.Drawing.Color.Black
        Me.txtPenalty.Location = New System.Drawing.Point(153, 223)
        Me.txtPenalty.MaxLength = 30
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(383, 26)
        Me.txtPenalty.TabIndex = 169
        Me.txtPenalty.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Penalty"
        '
        'pbBrowsePic
        '
        Me.pbBrowsePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBrowsePic.Image = CType(resources.GetObject("pbBrowsePic.Image"), System.Drawing.Image)
        Me.pbBrowsePic.Location = New System.Drawing.Point(370, 68)
        Me.pbBrowsePic.Name = "pbBrowsePic"
        Me.pbBrowsePic.Size = New System.Drawing.Size(24, 24)
        Me.pbBrowsePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBrowsePic.TabIndex = 184
        Me.pbBrowsePic.TabStop = False
        '
        'lblLookUpBorrowers
        '
        Me.lblLookUpBorrowers.AutoSize = True
        Me.lblLookUpBorrowers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLookUpBorrowers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLookUpBorrowers.ForeColor = System.Drawing.Color.Teal
        Me.lblLookUpBorrowers.Location = New System.Drawing.Point(395, 70)
        Me.lblLookUpBorrowers.Name = "lblLookUpBorrowers"
        Me.lblLookUpBorrowers.Size = New System.Drawing.Size(129, 20)
        Me.lblLookUpBorrowers.TabIndex = 183
        Me.lblLookUpBorrowers.Text = "Lookup Borrowers"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnBorrow)
        Me.Panel1.Controls.Add(Me.txtPenaltyDay)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtDayAllowed)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtBookAllowed)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(7, 271)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1091, 34)
        Me.Panel1.TabIndex = 185
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrow.FlatAppearance.BorderSize = 0
        Me.btnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.ForeColor = System.Drawing.Color.White
        Me.btnBorrow.Location = New System.Drawing.Point(986, 4)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(103, 26)
        Me.btnBorrow.TabIndex = 199
        Me.btnBorrow.Text = "BORROW"
        Me.btnBorrow.UseVisualStyleBackColor = False
        '
        'txtPenaltyDay
        '
        Me.txtPenaltyDay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPenaltyDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenaltyDay.Enabled = False
        Me.txtPenaltyDay.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyDay.Location = New System.Drawing.Point(577, 3)
        Me.txtPenaltyDay.MaxLength = 30
        Me.txtPenaltyDay.Name = "txtPenaltyDay"
        Me.txtPenaltyDay.Size = New System.Drawing.Size(59, 27)
        Me.txtPenaltyDay.TabIndex = 204
        Me.txtPenaltyDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(463, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 17)
        Me.Label16.TabIndex = 203
        Me.Label16.Text = "Penalty Per Day"
        '
        'txtDayAllowed
        '
        Me.txtDayAllowed.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDayAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDayAllowed.Enabled = False
        Me.txtDayAllowed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayAllowed.Location = New System.Drawing.Point(380, 3)
        Me.txtDayAllowed.MaxLength = 30
        Me.txtDayAllowed.Name = "txtDayAllowed"
        Me.txtDayAllowed.Size = New System.Drawing.Size(59, 27)
        Me.txtDayAllowed.TabIndex = 202
        Me.txtDayAllowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(240, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 17)
        Me.Label15.TabIndex = 201
        Me.Label15.Text = "Max Day(s) Allowed"
        '
        'txtBookAllowed
        '
        Me.txtBookAllowed.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBookAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookAllowed.Enabled = False
        Me.txtBookAllowed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookAllowed.Location = New System.Drawing.Point(156, 3)
        Me.txtBookAllowed.MaxLength = 30
        Me.txtBookAllowed.Name = "txtBookAllowed"
        Me.txtBookAllowed.Size = New System.Drawing.Size(59, 27)
        Me.txtBookAllowed.TabIndex = 200
        Me.txtBookAllowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 17)
        Me.Label14.TabIndex = 199
        Me.Label14.Text = "Max Book(s) Allowed"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(929, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 189
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(954, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Lookup Books"
        '
        'txtISBN
        '
        Me.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISBN.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(706, 64)
        Me.txtISBN.MaxLength = 30
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(211, 26)
        Me.txtISBN.TabIndex = 186
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(596, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "ISBN"
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.SystemColors.Control
        Me.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPublisher.Enabled = False
        Me.txtPublisher.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(706, 223)
        Me.txtPublisher.MaxLength = 30
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(383, 26)
        Me.txtPublisher.TabIndex = 196
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(596, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "Publisher"
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.SystemColors.Control
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthor.Enabled = False
        Me.txtAuthor.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(706, 184)
        Me.txtAuthor.MaxLength = 30
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(383, 26)
        Me.txtAuthor.TabIndex = 194
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(596, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Author(s)"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.SystemColors.Control
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(706, 145)
        Me.txtTitle.MaxLength = 30
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(383, 26)
        Me.txtTitle.TabIndex = 192
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(596, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 17)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "Title"
        '
        'txtCallNo
        '
        Me.txtCallNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtCallNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCallNo.Enabled = False
        Me.txtCallNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallNo.Location = New System.Drawing.Point(706, 106)
        Me.txtCallNo.MaxLength = 30
        Me.txtCallNo.Name = "txtCallNo"
        Me.txtCallNo.Size = New System.Drawing.Size(383, 26)
        Me.txtCallNo.TabIndex = 190
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(596, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 17)
        Me.Label13.TabIndex = 191
        Me.Label13.Text = "Call No"
        '
        'panelNoRecord
        '
        Me.panelNoRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.panelNoRecord.Controls.Add(Me.Label17)
        Me.panelNoRecord.Location = New System.Drawing.Point(370, 431)
        Me.panelNoRecord.Name = "panelNoRecord"
        Me.panelNoRecord.Size = New System.Drawing.Size(380, 59)
        Me.panelNoRecord.TabIndex = 199
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(101, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(178, 25)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "No Records Found"
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.SystemColors.Control
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtType.Enabled = False
        Me.txtType.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.ForeColor = System.Drawing.Color.Black
        Me.txtType.Location = New System.Drawing.Point(153, 184)
        Me.txtType.MaxLength = 30
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(383, 26)
        Me.txtType.TabIndex = 200
        '
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfirmReturnToolStripMenuItem1})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(157, 48)
        '
        'ConfirmReturnToolStripMenuItem1
        '
        Me.ConfirmReturnToolStripMenuItem1.Name = "ConfirmReturnToolStripMenuItem1"
        Me.ConfirmReturnToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.ConfirmReturnToolStripMenuItem1.Text = "Confirm Return"
        '
        'ucIssuedReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.panelNoRecord)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCallNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbBrowsePic)
        Me.Controls.Add(Me.lblLookUpBorrowers)
        Me.Controls.Add(Me.txtPenalty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtYearSec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBorrowerID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.dgvBorrows)
        Me.Name = "ucIssuedReturn"
        Me.Size = New System.Drawing.Size(1126, 599)
        CType(Me.dgvBorrows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBrowsePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNoRecord.ResumeLayout(False)
        Me.panelNoRecord.PerformLayout()
        Me.MaterialContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBorrows As DataGridView
    Friend WithEvents label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBorrowerID As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents txtYearSec As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents txtPenalty As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents pbBrowsePic As PictureBox
    Private WithEvents lblLookUpBorrowers As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCallNo As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label14 As Label
    Friend WithEvents txtBookAllowed As TextBox
    Friend WithEvents txtDayAllowed As TextBox
    Private WithEvents Label15 As Label
    Friend WithEvents txtPenaltyDay As TextBox
    Private WithEvents Label16 As Label
    Private WithEvents btnBorrow As Button
    Friend WithEvents panelNoRecord As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewImageColumn
    Friend WithEvents txtType As TextBox
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ConfirmReturnToolStripMenuItem1 As ToolStripMenuItem
End Class
