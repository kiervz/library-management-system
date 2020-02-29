Public Class frmSetSystemIdle

    Private Sub txtIdleTime_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdleTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtIdleTime.Text.Length = 0 Or txtIdleTime.Text = "0" Then
                Msg(Me, "Maximum Idle Time must be larger than 0.", "Idle Time", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                My.Settings.IdleTime = txtIdleTime.Text
                My.Settings.Save()
                My.Settings.Reload()
                'Me.Controls.Clear() 'removes all the controls on the form
                'InitializeComponent() 'load all the controls again
                'frmMain.frmMain_Load(e, e) 'Load everything in your form load event again
                Notifier()
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSystemIdle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdleTime.Text = My.Settings.IdleTime
        txtIdleTime.Focus()
    End Sub


    Private Sub Notifier()
        PopupNotifier1.Image = My.Resources.infox60
        PopupNotifier1.TitleText = "System Idle"
        PopupNotifier1.ContentText = "System idle has been set to " + txtIdleTime.Text + " second(s)."
        PopupNotifier1.Popup()
    End Sub

    Private Sub txtIdleTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdleTime.KeyPress
        KeyPressNumberOnly(e)
    End Sub
End Class