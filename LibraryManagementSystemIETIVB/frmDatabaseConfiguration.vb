Imports System.Configuration


Public Class frmDatabaseConfiguration

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        ConnDB()

        If isDBConnnected = True Then
            Msg(Me, "Successfully Connected!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Server = txtServerHost.Text
        My.Settings.Database = txtDatabase.Text
        My.Settings.Username = txtUserName.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Save()
        My.Settings.Reload()

        Msg(Me, "Successfully Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

End Class