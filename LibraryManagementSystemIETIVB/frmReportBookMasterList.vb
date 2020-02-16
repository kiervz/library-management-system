
Public Class frmReportBookMasterList
    Private Sub frmReportBookMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DataSet1.dtBooks' table. You can move, or remove it, as needed.
        Me.dtBooksTableAdapter.Fill(Me.DataSet1.dtBooks)

        Dim ps = New Printing.PageSettings()
        ps.Landscape = True
        ps.Margins.Right = 0
        ps.PaperSize = New Printing.PaperSize("Letter Extra", 900, 1200)
        ps.PaperSize.RawKind = Printing.PaperKind.LetterExtra
        ReportViewer1.SetPageSettings(ps)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class