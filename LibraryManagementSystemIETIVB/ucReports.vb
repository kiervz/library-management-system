Public Class ucReports

    Private Sub btnBooksMasterList_Click(sender As Object, e As EventArgs) Handles btnBooksMasterList.Click
        OpenTransparentForm(Me)
        Dim books_master_list As New frmReportBookMasterList
        books_master_list.ShowDialog(Me)
        CloseTransparentForm()
    End Sub

End Class
