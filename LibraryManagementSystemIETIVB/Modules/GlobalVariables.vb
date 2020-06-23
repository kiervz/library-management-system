Module GlobalVariables

    Public userID As String
    Public userFname As String
    Public userLname As String
    Public userImage As String
    Public userPassword As String
    Public userType As String
    Public isPasswordCorrect As Boolean = False
    Public isExpandedPanel As Boolean = False
    Public UserLogTime As DateTime
    Public isSystemIDLE As Boolean = False
    Public isIDLEPasswordCorrect As Boolean = False
    Public idlePasswordAttempts As Integer = 0
    Public isFacultiesImporting As Boolean = False
    Public isStudentsImporting As Boolean = False
    Public borrower_id As String
    Public book_id As String
    Public book_isbn As String
    Public is_reload As Boolean = False

    Public Sub OpenTransparentForm(owner As IWin32Window)
        Dim a As New frmTransparent
        a.Show(owner)
    End Sub

    Public Sub CloseTransparentForm()
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        If a IsNot Nothing Then
            a.Close()
        End If
    End Sub

    Public Sub KeyPressLetterOnly(e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

    Public Sub KeyPressNumberOnly(e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Public Sub KeyPressLetterNumberOnly(e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

End Module