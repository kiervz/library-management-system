Public Class frmUpdateUser

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
        Me.Hide()
    End Sub

    Private Sub frmUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMale.Checked = True
    End Sub
End Class