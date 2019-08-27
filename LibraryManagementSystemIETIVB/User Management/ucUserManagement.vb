Imports System.Data.SqlClient

Public Class ucUserManagement


    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        Dim a As New frmTransparent
        Dim b As New frmRegisterUser
        a.Show(Me)
        b.ShowDialog(Me)
        a.Dispose()
        b.Dispose()
    End Sub

    Private Sub ucUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        FillDGV()
        FillDGVArchived()
    End Sub

    Public Sub FillDGV()
        Try

            If userID = "UID00001" Then
                str = "SELECT * FROM tblUserInfo WHERE status = '1'"
            Else
                str = "SELECT * FROM tblUserInfo WHERE status = '1' AND user_id <> 'UID00001'"
            End If

            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            dgvUserInfo.Rows.Clear()

            While dr.Read
                dgvUserInfo.Rows.Add(dr("user_id"), dr("user_type"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), dr("gender"), dr("username"), CDate(dr("birthday")).ToShortDateString())
            End While

            dr.Close()
            cmd.Dispose()

            If dgvUserInfo.RowCount = 0 Then
                panelNoRecord.BringToFront()
            Else
                panelNoRecord.SendToBack()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Public Sub FillDGVArchived()
        Try
            cmd = New SqlCommand("SELECT * FROM tblUserInfo WHERE status = '0'", conn)
            dr = cmd.ExecuteReader

            dgvArchived.Rows.Clear()

            While dr.Read
                dgvArchived.Rows.Add(dr("user_id"), dr("user_type"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), dr("gender"), dr("username"), CDate(dr("birthday")).ToShortDateString())
            End While

            If dgvArchived.RowCount = 0 Then
                panelNoArchived.BringToFront()
            Else
                panelNoArchived.SendToBack()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub DeleteRestoreUser(user_id As String, status As Integer)
        str = "UPDATE tblUserInfo SET status = '" + CStr(status) + "' WHERE user_id = '" + user_id + "'"
        cmd = New SqlCommand(str, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub dgvUserInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserInfo.CellContentClick
        Dim i As Integer = dgvUserInfo.CurrentRow.Index
        Dim tempUserID As String = dgvUserInfo.Item(0, i).Value

        If e.ColumnIndex = 6 Then
            Dim a As New frmTransparent
            a.Show(Me)

            Dim update_user As New frmUpdateUser
            update_user.GetUserID(tempUserID)
            update_user.ShowDialog(Me)

        ElseIf e.ColumnIndex = 7 Then
            If tempUserID = userID Then
                CustomMessageBox.ShowDialog(Me, "You can't delete your account!", "Unable to Delete", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
                Exit Sub
            End If

            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Delete " + tempUserID + "?", "Delete Record", MessageBoxButtonn.YesNo, MessageBoxIconn.Danger)

            If msgBoxButtonClick = DialogResult.Yes Then

                Dim confirmPass As New frmPasswordConfirmation
                confirmPass.ShowDialog()

                If isPasswordCorrect = True Then

                    Try
                        DeleteRestoreUser(tempUserID, 0)

                        CustomMessageBox.ShowDialog(Me, "Record successfully deleted!", "Deleted", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                        FillDGV()
                        FillDGVArchived()

                        isPasswordCorrect = False
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error")
                    End Try
                Else
                    CustomMessageBox.ShowDialog(Me, "Autentication Failed!", "Failed", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
                End If

            End If
        End If
    End Sub

    Private Sub dgvArchived_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchived.CellContentClick
        Dim i As Integer = dgvArchived.CurrentRow.Index
        Dim tempUserID As String = dgvArchived.Item(0, i).Value

        If e.ColumnIndex = 6 Then
            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Restore " + tempUserID + "?", "Restore Record", MessageBoxButtonn.YesNo, MessageBoxIconn.Question)

            If msgBoxButtonClick = DialogResult.Yes Then

                Dim confirmPass As New frmPasswordConfirmation
                confirmPass.ShowDialog()

                If isPasswordCorrect = True Then
                    Try
                       
                        DeleteRestoreUser(tempUserID, 1)

                        CustomMessageBox.ShowDialog(Me, "Record successfully restored!", "Restored", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                        FillDGVArchived()
                        FillDGV()
                        isPasswordCorrect = False

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error")
                    End Try
                Else
                    CustomMessageBox.ShowDialog(Me, "Autentication Failed!", "Failed", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
                End If

            End If

        End If
    End Sub

End Class