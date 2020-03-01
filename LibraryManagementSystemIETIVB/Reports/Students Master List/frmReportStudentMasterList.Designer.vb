<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportStudentMasterList
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.studentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New LibraryManagementSystemIETIVB.DataSet1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.cmbSearchBy = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.studentsTableAdapter = New LibraryManagementSystemIETIVB.DataSet1TableAdapters.studentsTableAdapter()
        CType(Me.studentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'studentsBindingSource
        '
        Me.studentsBindingSource.DataMember = "students"
        Me.studentsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 32)
        Me.Panel1.TabIndex = 3
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoad.Location = New System.Drawing.Point(880, 3)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(67, 25)
        Me.btnLoad.TabIndex = 73
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(684, 3)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(193, 25)
        Me.txtSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.txtSearch.TabIndex = 56
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.UseStyleColors = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.ItemHeight = 19
        Me.cmbSearchBy.Items.AddRange(New Object() {"Select All", "Student ID", "Firstname", "Middlename", "Lastname", "Major"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(546, 3)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(132, 25)
        Me.cmbSearchBy.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbSearchBy.TabIndex = 55
        Me.cmbSearchBy.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(464, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FILTER BY:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.studentsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LibraryManagementSystemIETIVB.ReportStudentMasterList.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 92)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1006, 470)
        Me.ReportViewer1.TabIndex = 4
        '
        'studentsTableAdapter
        '
        Me.studentsTableAdapter.ClearBeforeFill = True
        '
        'frmReportStudentMasterList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 582)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "frmReportStudentMasterList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Student Master List"
        CType(Me.studentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents studentsBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents studentsTableAdapter As DataSet1TableAdapters.studentsTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents cmbSearchBy As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Private WithEvents btnLoad As Button
End Class
