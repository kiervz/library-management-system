Public Class FormMsgBox


    Public Sub SetMessage(ByVal message As String)
        Me.txtMessage.Text = message
    End Sub

    Public Sub SetFirstButton(ByVal btn1 As String)
        Me.btnFirst.Text = btn1
    End Sub

    Public Sub SetSecondButton(ByVal btn2 As String)
        Me.btnSecond.Text = btn2
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnSecond.Click
        Me.Hide()
    End Sub
End Class