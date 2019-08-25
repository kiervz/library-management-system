Imports System.Data.SqlClient

Public Class ucUserManagement


    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        Dim a As New frmTransparent
        Dim b As New frmRegisterUser
        a.Show(Me)
        b.ShowDialog(Me)
    End Sub

    Private Sub ucUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        FillDGV()
        FillDGVArchived()
    End Sub

    Public Sub FillDGV()
        Try
            cmd = New SqlCommand("SELECT * FROM tblUserInfo WHERE status = '1'", conn)
            dr = cmd.ExecuteReader

            dgvUserInfo.Rows.Clear()

            While dr.Read
                dgvUserInfo.Rows.Add(dr("user_id"), dr("user_type"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), dr("gender"), dr("username"), CDate(dr("birthday")).ToShortDateString())
            End While

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

            If dgvUserInfo.RowCount = 0 Then
                panelNoRecord.BringToFront()
            Else
                panelNoRecord.SendToBack()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub dgvUserInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim i As Integer = dgvUserInfo.CurrentRow.Index
        Dim tempUserID As String = dgvUserInfo.Item(0, i).Value

        If e.ColumnIndex = 6 Then
            Dim a As New frmTransparent
            a.Show(Me)

            Dim update_user As New frmUpdateUser
            update_user.GetUserID(tempUserID)
            update_user.ShowDialog(Me)

        ElseIf e.ColumnIndex = 7 Then
            CustomMessageBox.ShowDialog(Me, "Are you sure you want to Delete " + tempUserID + "?", "Delete Record", MessageBoxButtonn.YesNo, MessageBoxIconn.Danger)

            If msgBoxButtonClick = DialogResult.Yes Then

                Dim confirmPass As New frmPasswordConfirmation
                confirmPass.ShowDialog()

                If isPasswordCorrect = True Then

                    Try
                        str = "UPDATE tblUserInfo SET status = '0' WHERE user_id = '" + tempUserID + "'"
                        cmd = New SqlCommand(str, conn)
                        cmd.ExecuteNonQuery()

                        CustomMessageBox.ShowDialog(Me, "Record successfully deleted!", "Deleted", MessageBoxButtonn.Ok, MessageBoxIconn.Information)
                        FillDGV()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error")
                    End Try
                Else
                    CustomMessageBox.ShowDialog(Me, "Autentication Failed!", "Failed", MessageBoxButtonn.Ok, MessageBoxIconn.Danger)
                End If

            End If
        End If
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        If MetroTabControl1.SelectedIndex = 0 Then
            frmMain.lblTitle.Text = "Users Management\Manage User"
        Else
            frmMain.lblTitle.Text = "Users Management\Archived User"
        End If
    End Sub
End Class