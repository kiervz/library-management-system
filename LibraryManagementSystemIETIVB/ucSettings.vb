Public Class ucSettings

    Private Sub ucSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNoBooksAllowed.Text = My.Settings.no_books_allow
        txtNoDaysAllowed.Text = My.Settings.no_days_allow
        txtPenaltyPerDay.Text = My.Settings.penalty_per_day
        'txtIdleTime.Text = My.Settings.IdleTime
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.no_books_allow = txtNoBooksAllowed.Text
        My.Settings.no_days_allow = txtNoDaysAllowed.Text
        My.Settings.penalty_per_day = txtPenaltyPerDay.Text
        'My.Settings.IdleTime = txtIdleTime.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

    End Sub
End Class