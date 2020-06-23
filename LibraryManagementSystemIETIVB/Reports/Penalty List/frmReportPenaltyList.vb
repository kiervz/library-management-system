Imports Microsoft.Reporting.WinForms

Public Class frmReportPenaltyList
    Private Sub frmReportPenaltyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.dtPenaltyList' table. You can move, or remove it, as needed.
        Me.dtPenaltyListTableAdapter.Fill(Me.DataSet1.dtPenaltyList)
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