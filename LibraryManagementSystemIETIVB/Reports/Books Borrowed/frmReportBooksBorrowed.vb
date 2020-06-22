Imports Microsoft.Reporting.WinForms

Public Class frmReportBooksBorrowed
    Private Sub frmReportBooksBorrowed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbBorrowed' table. You can move, or remove it, as needed.
        Me.tbBorrowedTableAdapter.Connection.ConnectionString = "Data Source= " + My.Settings.Server + ";Initial Catalog= " + My.Settings.Database + ";Integrated Security=True"
        Me.tbBorrowedTableAdapter.Fill(Me.DataSet1.tbBorrowed)
        PageSetting()
        Parameters()
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub PageSetting()
        Dim ps = New Printing.PageSettings()
        ps.Landscape = True
        ps.Margins.Right = 0
        ps.PaperSize = New Printing.PaperSize("Letter Extra", 900, 1300)
        ps.PaperSize.RawKind = Printing.PaperKind.LetterExtra
        ReportViewer1.SetPageSettings(ps)
    End Sub

    Private Sub Parameters()
        Dim _username As ReportParameter = New ReportParameter("username", userFname + " " + userLname)
        Me.ReportViewer1.LocalReport.SetParameters(_username)
    End Sub
End Class