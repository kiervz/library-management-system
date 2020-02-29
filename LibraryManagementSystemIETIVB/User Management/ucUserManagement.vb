Imports System.Data.SqlClient

Public Class ucUserManagement


    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        OpenTransparentForm(Me)
        Dim b As New frmRegisterUser
        b.ShowDialog(Me)
    End Sub

    Private Sub ucUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        Timer1.Start()
    End Sub

    Friend Sub FillDGV()
        Try

            If userID = "UID00001" Then
                str = "SELECT * FROM users WHERE status = '1'"
            Else
                str = "SELECT * FROM users WHERE status = '1' AND user_id <> 'UID00001'"
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

    Friend Sub FillDGVArchived()
        Try
            cmd = New SqlCommand("SELECT * FROM users WHERE status = '0'", conn)
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
        str = "UPDATE users SET status = '" + CStr(status) + "' WHERE user_id = '" + user_id + "'"
        cmd = New SqlCommand(str, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub dgvUserInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserInfo.CellContentClick
        Dim i As Integer = dgvUserInfo.CurrentRow.Index
        Dim tempUserID As String = dgvUserInfo.Item(0, i).Value
        Dim tempUserType As String = dgvUserInfo.Item(1, i).Value

        'When you click update button in datagridview
        If e.ColumnIndex = 6 Then
            OpenTransparentForm(Me)

            Dim update_user As New frmUpdateUser
            update_user.GetUserID(tempUserID)
            update_user.ShowDialog(Me)

        ElseIf e.ColumnIndex = 7 Then 'When you click delete button in datagridview

            'When you delete your own account
            If tempUserID = userID Then
                Msg(Me, "You can't delete your account!", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'When you delete the other librarian
            If tempUserType = "Librarian" And userID <> "UID00001" Then
                Msg(Me, "You can't delete other librarian!", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Delete " + tempUserID + "?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If mes = DialogResult.Yes Then

                Dim confirmPass As New frmPasswordConfirmation
                confirmPass.ShowDialog()

                If isPasswordCorrect = True Then

                    Try
                        DeleteRestoreUser(tempUserID, 0)

                        Msg(Me, "Record successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FillDGV()
                        FillDGVArchived()

                        isPasswordCorrect = False
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error")
                    End Try
                Else
                    Msg(Me, "Autentication Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
    End Sub

    Private Sub dgvArchived_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchived.CellContentClick
        Dim i As Integer = dgvArchived.CurrentRow.Index
        Dim tempUserID As String = dgvArchived.Item(0, i).Value

        'When you click restore button
        If e.ColumnIndex = 6 Then

            Dim mes As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Restore " + tempUserID + "?", "Restore Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If mes = DialogResult.Yes Then

                Dim confirmPass As New frmPasswordConfirmation
                confirmPass.ShowDialog()

                If isPasswordCorrect = True Then
                    Try

                        DeleteRestoreUser(tempUserID, 1)

                        Msg(Me, "Record successfully restored!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FillDGVArchived()
                        FillDGV()
                        isPasswordCorrect = False

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error")
                    End Try
                Else
                    Msg(Me, "Autentication Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If txtSearch.Text.Length = 1 Then
            FillDGV()
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                'Manage User
                If MetroTabControl1.SelectedIndex = 0 Then
                    If cmbSearchBy.SelectedIndex = 0 Then
                        If userID = "UID00001" Then
                            str = "SELECT * FROM users WHERE status = '1' AND user_id LIKE '%" + txtSearch.Text + "%'"
                        Else
                            str = "SELECT * FROM users WHERE status = '1' AND user_id LIKE '%" + txtSearch.Text + "%' AND user_id <> 'UID00001'"
                        End If
                    ElseIf cmbSearchBy.SelectedIndex = 1 Then
                        If userID = "UID00001" Then
                            str = "SELECT * FROM users WHERE status = '1' AND (CONCAT(firstname, ' ', middlename, ' ', lastname) LIKE '%" + txtSearch.Text + "%' OR  CONCAT(Firstname, ' ', lastname) LIKE '%" + txtSearch.Text + "%' OR  CONCAT(Firstname, ' ', middlename) LIKE '%" + txtSearch.Text + "%')"
                        Else
                            str = "SELECT * FROM users WHERE status = '1' AND (CONCAT(firstname, ' ', middlename, ' ', lastname) LIKE '%" + txtSearch.Text + "%' OR  CONCAT(Firstname, ' ', lastname) LIKE '%" + txtSearch.Text + "%' OR  CONCAT(Firstname, ' ', middlename) LIKE '%" + txtSearch.Text + "%')  AND user_id <> 'UID00001'"
                        End If
                    Else
                        str = "SELECT * FROM users WHERE status = '1'"
                    End If

                    DisplayGridView(str)

                    'Archived User
                Else
                    If cmbSearchBy.SelectedIndex = 0 Then
                        str = "SELECT * FROM users WHERE status = '0' AND user_id LIKE '%" + txtSearch.Text + "%'"
                    ElseIf cmbSearchBy.SelectedIndex = 1 Then
                        str = "SELECT * FROM users WHERE status = '0' AND (CONCAT(firstname, ' ', middlename, ' ', lastname) LIKE '%" + txtSearch.Text + "%' OR  CONCAT(Firstname, ' ', lastname) LIKE '%" + txtSearch.Text + "%' OR  CONCAT(Firstname, ' ', middlename) LIKE '%" + txtSearch.Text + "%')"
                    Else
                        str = "SELECT * FROM users WHERE status = '0'"
                    End If

                    DisplayGridView(str)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        If cmbSearchBy.SelectedIndex = 2 Then
            cmbUserType.BringToFront()
        Else
            cmbUserType.SendToBack()
        End If
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedIndexChanged
        Try
            'Manage User
            If MetroTabControl1.SelectedIndex = 0 Then
                If cmbUserType.SelectedIndex = 0 Then
                    If userID = "UID00001" Then
                        str = "SELECT * FROM users WHERE status = '1'"
                    Else
                        str = "SELECT * FROM users WHERE status = '1' AND user_id <> 'UID00001'"
                    End If
                Else
                    If userID = "UID00001" Then
                        str = "SELECT * FROM users WHERE status = '1' AND user_type = '" + cmbUserType.Text + "'"
                    Else
                        str = "SELECT * FROM users WHERE status = '1' AND user_type = '" + cmbUserType.Text + "' AND user_id <> 'UID00001'"
                    End If
                End If

                'Archived User
            Else
                If cmbUserType.SelectedIndex = 0 Then
                    str = "SELECT * FROM users WHERE status = '0'"
                Else
                    str = "SELECT * FROM users WHERE status = '0' AND user_type = '" + cmbUserType.Text + "'"
                End If
            End If

            DisplayGridView(str)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub DisplayGridView(query As String)
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader

        If MetroTabControl1.SelectedIndex = 0 Then
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
        Else
            dgvArchived.Rows.Clear()

            While dr.Read
                dgvArchived.Rows.Add(dr("user_id"), dr("user_type"), dr("firstname") + " " + dr("middlename") + " " + dr("lastname"), dr("gender"), dr("username"), CDate(dr("birthday")).ToShortDateString())
            End While

            dr.Close()
            cmd.Dispose()

            If dgvArchived.RowCount = 0 Then
                panelNoArchived.BringToFront()
            Else
                panelNoArchived.SendToBack()
            End If
        End If
    End Sub

End Class