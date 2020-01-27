Imports System.Data.SqlClient

Module ConnString

    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public str As String

    Public isDBConnnected As Boolean = False

    Public Sub ConnDB()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            'DBMSSOCN=TCP/IP is how to use TCP/IP instead of Named Pipes.
            conn.ConnectionString = "Server=" + My.Settings.Server + "; User ID=" + My.Settings.Username + "; Password=" + My.Settings.Password + "; Initial Catalog=" + My.Settings.Database + "; Trusted_connection=False; MultipleActiveResultSets=true;"
            conn.Open()
            isDBConnnected = True
        Catch ex As Exception
            isDBConnnected = False
            MessageBox.Show("Connection Failed! Please contact the administrator.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module