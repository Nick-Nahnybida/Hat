Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intCount As Integer

        For intCount = 16 To 328 ' (int intCount = 16; intCunt <= 328; intCount++)
            picKoala.Left = intCount
        Next
    End Sub
End Class
