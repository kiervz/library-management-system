Module GlobalVariables

    Public userid As String
    Public fname As String
    Public lname As String
    Public userImage As String
    Public userType As String


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


End Module