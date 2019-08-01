Public Class frmLogin

    Private imageNumber As Integer = 1
    Private totalAttempt As Integer = 0

    Private Sub LoadNextImage()
        If imageNumber = 5 Then
            imageNumber = 1
        End If

        picCarousel.ImageLocation = String.Format("Images\" + CStr(imageNumber) + ".jpg")
        imageNumber = imageNumber + 1
    End Sub


    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        LoadNextImage()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Me.Hide()
        frmMain.ShowDialog()
    End Sub
End Class