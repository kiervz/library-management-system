Imports System.Data.SqlClient

Module ConnString

    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public str As String

    Public Sub ConnDB()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.ConnectionString = "Server=DESKTOP-CLAUDE\SQLEXPRESS; database=maghanoy_library_lmsieti; Trusted_connection=true; MultipleActiveResultSets=true;"
            conn.Open()
            'MsgBox("Connected Successful")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module