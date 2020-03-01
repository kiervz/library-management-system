<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBooksList
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.cmbSearchBy = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.cmbCategories = New MetroFramework.Controls.MetroComboBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(988, 16)
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
        Me.Label10.Location = New System.Drawing.Point(25, 624)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 18)
        Me.Label10.TabIndex = 240
        Me.Label10.Text = "Note: Double click to select borrower"
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.White
        Me.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvBooks.ColumnHeadersHeight = 37
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column3, Me.Column4, Me.Column6, Me.Column8, Me.Column7, Me.Column2})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvBooks.EnableHeadersVisualStyles = False
        Me.dgvBooks.GridColor = System.Drawing.Color.White
        Me.dgvBooks.Location = New System.Drawing.Point(25, 101)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvBooks.RowHeadersVisible = False
        Me.dgvBooks.RowHeadersWidth = 23
        Me.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBooks.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvBooks.RowTemplate.Height = 32
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.ShowCellErrors = False
        Me.dgvBooks.ShowEditingIcon = False
        Me.dgvBooks.ShowRowErrors = False
        Me.dgvBooks.Size = New System.Drawing.Size(1025, 508)
        Me.dgvBooks.TabIndex = 241
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.ItemHeight = 19
        Me.cmbSearchBy.Items.AddRange(New Object() {"Select All", "ISBN", "Title", "Author", "Publisher", "Category"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(678, 70)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchBy.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchBy.TabIndex = 243
        Me.cmbSearchBy.UseSelectable = True
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(180, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(820, 70)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(204, 25)
        Me.txtSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.txtSearch.TabIndex = 242
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.UseStyleColors = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cmbCategories
        '
        Me.cmbCategories.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbCategories.FormattingEnabled = True
        Me.cmbCategories.ItemHeight = 19
        Me.cmbCategories.Items.AddRange(New Object() {"Select All", "ISBN", "Title", "Author", "Publisher", "Category"})
        Me.cmbCategories.Location = New System.Drawing.Point(820, 70)
        Me.cmbCategories.Name = "cmbCategories"
        Me.cmbCategories.Size = New System.Drawing.Size(204, 25)
        Me.cmbCategories.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbCategories.TabIndex = 244
        Me.cmbCategories.UseSelectable = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "Call No"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 110
        '
        'Column3
        '
        Me.Column3.HeaderText = "Title"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Author"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 180
        '
        'Column6
        '
        Me.Column6.HeaderText = "Category"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column8
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column8.HeaderText = "Copies"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
        '
        'Column7
        '
        Me.Column7.HeaderText = "Year Published"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "ISBN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 110
        '
        'frmBooksList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 657)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbSearchBy)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbCategories)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmBooksList"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Book List"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnClose As Label
    Private WithEvents Label10 As Label
    Friend WithEvents dgvBooks As DataGridView
    Private WithEvents cmbSearchBy As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Private WithEvents cmbCategories As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
