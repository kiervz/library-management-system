Imports System.Data.SqlClient

Public Class frmUpdateUser

    Private user_id As String

    Public Sub GetUserID(user_id As String)
        Me.user_id = user_id
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
        Me.Hide()
    End Sub

    'if the RegisterUser form is closed the transparent form will be closed as well
    Private Sub frmUpdateUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim a As frmTransparent = Application.OpenForms("frmTransparent")
        a.Close()
    End Sub

    Private Sub frmUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB()
        rbMale.Checked = True

        Try

            str = "SELECT firstname,middlename,lastname,user_type,gender,phone,birthday FROM tblUserInfo WHERE user_id = '" + user_id + "'"
            cmd = New SqlCommand(str, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then

                txtFirstname.Text = dr("firstname")
                txtMiddlename.Text = dr("middlename")
                txtLastname.Text = dr("lastname")
                cmbUserType.Text = dr("user_type")
                txtPhone.Text = dr("phone")
                If dr("gender") = "Male" Then
                    rbMale.Checked = True
                Else
                    rbFemale.Checked = True
                End If
                dtBday.Value = CDate(dr("birthday"))
            End If
        Catch ex As Exception
            CustomMessageBox.ShowDialog(Me, ex.Message, "Exception")
        End Try
    End Sub

    Private Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year

        If dob > Today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age
        Return age
    End Function

    Private Sub dtBday_ValueChanged(sender As Object, e As EventArgs) Handles dtBday.ValueChanged
        GetCurrentAge(dtBday.Value)
    End Sub
End Class