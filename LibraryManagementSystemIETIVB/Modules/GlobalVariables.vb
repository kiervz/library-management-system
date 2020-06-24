Imports System.Data.SqlClient

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

    Public loginout_id As Integer
    Public dateTimeLogin As DateTime
    Public dateTimeLogout As DateTime

    Friend activityIDNo As Integer = 0

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

    Public Sub AN_ActivityLog()
        Try
            str = "SELECT MAX(id) FROM activity_log"
            cmd = New SqlCommand(str, conn)

            If IsDBNull(cmd.ExecuteScalar()) Then
                activityIDNo += 1
            Else
                activityIDNo = CStr(cmd.ExecuteScalar())
                activityIDNo += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RecordActivities(ByVal userID As String, ByVal activities As String, ByVal filter As String)
        Try
            str = "INSERT INTO activity_log (id, user_id, activities, datee, time, filter) VALUES(@id, @user_id, @activities, @datee, @time, @filter)"
            cmd = New SqlCommand(str, conn)
            cmd.Parameters.AddWithValue("@id", activityIDNo)
            cmd.Parameters.AddWithValue("@user_id", userID)
            cmd.Parameters.AddWithValue("@activities", activities)
            cmd.Parameters.AddWithValue("@datee", Date.Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("hh:mm tt"))
            cmd.Parameters.AddWithValue("@filter", filter)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module