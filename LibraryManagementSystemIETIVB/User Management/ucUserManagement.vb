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

        If isExpandedPanel = True Then
            panelNoRecord.Location = New Point(357, 241)
        Else
            panelNoRecord.Location = New Point(261, 241)
        End If
    End Sub

    Private Sub FillDGV()
        Try
            cmd = New SqlCommand("SELECT * FROM tblUserInfo", conn)
            dr = cmd.ExecuteReader

            dgvUserInfo.Rows.Clear()

            While dr.Read
                dgvUserInfo.Rows.Add(dr("UserID"), dr("UserType"), dr("FirstName"), dr("LastName"), dr("Gender"), dr("Username"), dr("Image"), CDate(dr("Birthday")).ToShortDateString())
            End While

            If dgvUserInfo.RowCount = 0 Then
                panelNoRecord.BringToFront()
            Else
                panelNoRecord.SendToBack()
            End If
        Catch ex As Exception
            Msg(Me, ex.Message, "Error")
        End Try
    End Sub

    Private Sub dgvUserInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserInfo.CellContentClick
        Dim i As Integer = dgvUserInfo.CurrentRow.Index
        Dim tempUserID As String = dgvUserInfo.Item(0, i).Value

        If e.ColumnIndex = 8 Then
            Dim a As New frmTransparent
            Dim b As New frmUpdateUser
            a.Show(Me)
            b.ShowDialog(Me)

        ElseIf e.ColumnIndex = 9 Then
            CustomMessageBox.ShowDialog("Are you sure you want to Delete " + tempUserID + "?", "Delete Record", MessageBoxButtonn.YesNo, MessageBoxIconn.Danger)

            If msgBoxButtonClick = DialogResult.Yes Then
                MsgBox("Yes")
            End If
        End If
    End Sub

    Private Sub ucUserManagement_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If isExpandedPanel = True Then
            panelNoRecord.Location = New Point(261, 241)
        Else
            panelNoRecord.Location = New Point(357, 241)
        End If
    End Sub

End Class