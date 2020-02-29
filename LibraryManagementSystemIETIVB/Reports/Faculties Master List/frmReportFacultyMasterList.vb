Imports Microsoft.Reporting.WinForms

Public Class frmReportFacultyMasterList
    Private Sub frmReportFacultyMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.faculties' table. You can move, or remove it, as needed.
        ConnectionStr()
        Me.facultiesTableAdapter.Fill(Me.DataSet1.faculties)
        PageSettings()
        Parameters()
        cmbSearchBy.SelectedIndex = 0
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub PageSettings()
        Dim ps = New Printing.PageSettings()
        ps.Landscape = True
        ps.Margins.Right = 0
        ps.PaperSize = New Printing.PaperSize("Letter Extra", 900, 1200)
        ps.PaperSize.RawKind = Printing.PaperKind.LetterExtra
        ReportViewer1.SetPageSettings(ps)
    End Sub

    Private Sub Parameters()
        Dim _username As ReportParameter = New ReportParameter("username", userFname + " " + userLname)
        Me.ReportViewer1.LocalReport.SetParameters(_username)
    End Sub

    Private Sub ConnectionStr()
        Me.facultiesTableAdapter.Connection.ConnectionString = "Data Source= " + My.Settings.Server + ";Initial Catalog= " + My.Settings.Database + ";Integrated Security=True"
    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchBy.SelectedIndexChanged

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ConnectionStr()
        If cmbSearchBy.SelectedIndex = 0 Then
            Me.facultiesTableAdapter.Fill(Me.DataSet1.faculties)
        ElseIf cmbSearchBy.SelectedIndex = 1 Then
            Me.facultiesTableAdapter.FillByFacultyID(Me.DataSet1.faculties, txtSearch.Text)
        ElseIf cmbSearchBy.SelectedIndex = 2 Then
            Me.facultiesTableAdapter.FillByFirstname(Me.DataSet1.faculties, txtSearch.Text)
        ElseIf cmbSearchBy.SelectedIndex = 3 Then
            Me.facultiesTableAdapter.FillByMiddlename(Me.DataSet1.faculties, txtSearch.Text)
        ElseIf cmbSearchBy.SelectedIndex = 4 Then
            Me.facultiesTableAdapter.FillByLastname(Me.DataSet1.faculties, txtSearch.Text)
        End If

        PageSettings()
        Parameters()
        ReportViewer1.RefreshReport()
    End Sub
End Class