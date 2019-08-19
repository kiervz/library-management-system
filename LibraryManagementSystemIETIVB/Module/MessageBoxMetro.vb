Imports MetroFramework

Module MessageBoxMetro

    Public Sub Msg(owner As IWin32Window, message As String, title As String, Optional button As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information, Optional height As Integer = 130)
        MetroMessageBox.Show(owner, message, title, button, icon, height)
    End Sub

End Module