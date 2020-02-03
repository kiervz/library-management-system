Public Class frmDatabaseConfiguration

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        ConnDB()

        If isDBConnnected = True Then
            CustomMessageBox.ShowDialog(Me, "Successfully Connected!", "Connected", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Server = txtServerHost.Text
        My.Settings.Database = txtDatabase.Text
        My.Settings.Username = txtUserName.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Save()
        My.Settings.Reload()

        CustomMessageBox.ShowDialog(Me, "Successfully Saved!", "Saved", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub LoadSetting()
        txtServerHost.Text = My.Settings.Server
        txtDatabase.Text = My.Settings.Database
        txtUserName.Text = My.Settings.Username
        txtPassword.Text = My.Settings.Password
    End Sub

    Private Sub frmDatabaseConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSetting()
    End Sub
End Class