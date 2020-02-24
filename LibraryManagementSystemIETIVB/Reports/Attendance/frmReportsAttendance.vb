Imports Microsoft.Reporting.WinForms

Public Class frmReportsAttendance
    Private Sub frmReportsAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.dtAttendance' table. You can move, or remove it, as needed.
        Me.dtAttendanceTableAdapter.Connection.ConnectionString = "Data Source= " + My.Settings.Server + ";Initial Catalog= " + My.Settings.Database + ";Integrated Security=True"
        Me.dtAttendanceTableAdapter.FillByDate(Me.DataSet1.dtAttendance, dtFrom.Value, dtTo.Value)
        PageSettings()
        Parameters()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'TODO: This line of code loads data into the 'DataSet1.dtAttendance' table. You can move, or remove it, as needed.
        Me.dtAttendanceTableAdapter.FillByDate(Me.DataSet1.dtAttendance, dtFrom.Value, dtTo.Value)
        PageSettings()
        Parameters()
        Me.ReportViewer1.RefreshReport()
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
        Dim _date_from As ReportParameter = New ReportParameter("date_from", dtFrom.Value)
        Dim _date_to As ReportParameter = New ReportParameter("date_to", dtTo.Value)
        Me.ReportViewer1.LocalReport.SetParameters(_username)
        Me.ReportViewer1.LocalReport.SetParameters(_date_from)
        Me.ReportViewer1.LocalReport.SetParameters(_date_to)
    End Sub

End Class