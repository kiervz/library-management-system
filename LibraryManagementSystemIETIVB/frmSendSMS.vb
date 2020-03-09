Imports System.IO.Ports
Imports System.Management

Public Class frmSendSMS

    Friend borrower_phone As String
    Private rcv_data As String = ""

    Private Sub frmSendSMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")

        For i As Integer = 0 To ports.Length - 1
            cmbPorts.Items.Add(ports(i))
        Next
        cmbPorts.SelectedIndex = 0

        If borrower_phone.Length > 0 Then
            Dim phone As String
            phone = borrower_phone.Substring(0, 1)
            If Not phone = "0" Then
                txtPhone.Text = "0" + borrower_phone
            End If
        End If
    End Sub

    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo")) & " - " & queryObj("Description") & ""
                End If
            Next
        Catch ex As ManagementException
            MsgBox(ex.Message)
            Return ""
        End Try
        Return modems
    End Function

    Private Sub cmbPorts_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPorts.SelectedValueChanged
        lblPort.Text = Trim(Mid(cmbPorts.Text, 1, 5))

        Try
            With SerialPort1
                .PortName = lblPort.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With

            If SerialPort1.IsOpen Then
                lblStatus.Text = "(Connected)"
            Else
                lblStatus.Text = "(Not Connected)"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub serialport1_datareceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim data_in As String = ""
        Dim num_bytes As Integer = SerialPort1.BytesToRead

        For i As Integer = 1 To num_bytes
            data_in &= Chr(SerialPort1.ReadChar)
        Next
        test(data_in)
    End Sub

    Private Sub test(ByVal in_data As String)
        rcv_data &= in_data
    End Sub

    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click
        If txtMessage.Text.Length > 0 And txtPhone.Text.Length > 0 Then
            If lblStatus.Text = "(Connected)" Then
                With SerialPort1
                    .Write("AT" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .Write("AT+CMGF=1" & vbCrLf)
                    .Write("AT+CMGS=" & Chr(34) & txtPhone.Text & Chr(34) & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .Write(txtMessage.Text & Chr(26))
                    Threading.Thread.Sleep(1000)
                End With

                If rcv_data.ToString.Contains(">") Then
                    MessageBox.Show("Message Sent!")
                Else
                    MessageBox.Show("Message Not Sent!")
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class