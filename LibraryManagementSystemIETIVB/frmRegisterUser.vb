Public Class frmRegisterUser

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
        Me.Hide()
    End Sub

End Class