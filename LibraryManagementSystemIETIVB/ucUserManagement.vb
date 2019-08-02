Imports System.Data.SqlClient

Public Class ucUserManagement

    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        Dim a As New LibraryManagementSystemIETIVB.frmTransparent
        Dim b As New LibraryManagementSystemIETIVB.frmRegisterUser
        a.Show()
        b.ShowDialog()
    End Sub

    Private Sub ucUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        FillDGV()
    End Sub

    Private Sub FillDGV()
        Try
            cmd = New SqlCommand("SELECT * FROM tblUserInfo", conn)
            dr = cmd.ExecuteReader

            dgvUserInfo.Rows.Clear()

            While dr.Read
                dgvUserInfo.Rows.Add(dr("UserID"), dr("UserType"), dr("FirstName"), dr("LastName"), dr("Gender"), dr("Username"), dr("Image"), CDate(dr("Birthday")).ToShortDateString())
            End While
        Catch ex As Exception
            Msg(Me, ex.Message, "Error")
        End Try
    End Sub

    Private Sub dgvUserInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserInfo.CellContentClick
        If e.ColumnIndex = 8 Then
            MsgBox("Edit")
        ElseIf e.ColumnIndex = 9 Then
            MsgBox("Delete")
        End If
    End Sub
End Class