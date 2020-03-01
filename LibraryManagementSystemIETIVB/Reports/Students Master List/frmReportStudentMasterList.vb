Imports Microsoft.Reporting.WinForms

Public Class frmReportStudentMasterList
    Private Sub frmStudentMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.students' table. You can move, or remove it, as needed.
        ConnectionStr()
        Me.studentsTableAdapter.Fill(Me.DataSet1.students)
        cmbSearchBy.SelectedIndex = 0
        PageSettings()
        Parameters()
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub PageSettings()
        Dim ps = New Printing.PageSettings()
        ps.Landscape = True
        ps.Margins.Right = 0
        ps.PaperSize = New Printing.PaperSize("Letter Extra", 900, 1250)
        ps.PaperSize.RawKind = Printing.PaperKind.LetterExtra
        ReportViewer1.SetPageSettings(ps)
    End Sub

    Private Sub Parameters()
        Dim _username As ReportParameter = New ReportParameter("username", userFname + " " + userLname)
        Me.ReportViewer1.LocalReport.SetParameters(_username)
    End Sub

    Private Sub ConnectionStr()
        Me.studentsTableAdapter.Connection.ConnectionString = "Data Source= " + My.Settings.Server + ";Initial Catalog= " + My.Settings.Database + ";Integrated Security=True"
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ConnectionStr()
        If cmbSearchBy.SelectedIndex = 0 Then
            Me.studentsTableAdapter.Fill(Me.DataSet1.students)
        ElseIf cmbSearchBy.SelectedIndex = 1 Then
            Me.studentsTableAdapter.FillByStudentID(Me.DataSet1.students, txtSearch.Text)
        ElseIf cmbSearchBy.SelectedIndex = 2 Then
            Me.studentsTableAdapter.FillByFirstname(Me.DataSet1.students, txtSearch.Text)
        ElseIf cmbSearchBy.SelectedIndex = 3 Then
            Me.studentsTableAdapter.FillByMiddlename(Me.DataSet1.students, txtSearch.Text)
        ElseIf cmbSearchBy.SelectedIndex = 4 Then
            Me.studentsTableAdapter.FillByLastname(Me.DataSet1.students, txtSearch.Text)
        ElseIf cmbSearchBy.SelectedIndex = 5 Then
            Me.studentsTableAdapter.FillByMajor(Me.DataSet1.students, txtSearch.Text)
        End If

        PageSettings()
        Parameters()
        ReportViewer1.RefreshReport()
    End Sub
End Class