Public Class frmPenaltySlip

    Friend borrow_id As String

    Private Sub frmPenaltySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1, borrow_id)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class