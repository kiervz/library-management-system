
Imports Microsoft.Reporting.WinForms

Public Class frmReportBookMasterList
    Private Sub frmReportBookMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DataSet1.dtBooks' table. You can move, or remove it, as needed.
        Me.dtBooksTableAdapter.Connection.ConnectionString = "Data Source= " + My.Settings.Server + ";Initial Catalog= " + My.Settings.Database + ";Integrated Security=True"
        Me.dtBooksTableAdapter.Fill(Me.DataSet1.dtBooks)
        Dim ps = New Printing.PageSettings()
        ps.Landscape = True
        ps.Margins.Right = 0
        ps.PaperSize = New Printing.PaperSize("Letter Extra", 900, 1300)
        ps.PaperSize.RawKind = Printing.PaperKind.LetterExtra
        ReportViewer1.SetPageSettings(ps)

        Dim _username As ReportParameter = New ReportParameter("username", userFname + " " + userLname)
        Me.ReportViewer1.LocalReport.SetParameters(_username)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class