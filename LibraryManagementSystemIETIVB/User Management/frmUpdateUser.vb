Public Class frmUpdateUser


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
        Me.Hide()
    End Sub

    'if the RegisterUser form is closed the transparent form will be closed as well
    Private Sub frmUpdateUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
    End Sub

    Private Sub frmUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMale.Checked = True
    End Sub

End Class