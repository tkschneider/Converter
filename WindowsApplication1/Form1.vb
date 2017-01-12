Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Go.Click
        If String.IsNullOrEmpty(pointsBox.Text) Then
            Dim inches As Decimal
            Decimal.TryParse(inchesBox.Text, inches)
            pointsBox.Text = convertoPoints(inches)
            inchesBox.Text = ""
        ElseIf String.IsNullOrEmpty(inchesBox.Text) Then
            Dim points As Decimal
            Decimal.TryParse(pointsBox.Text, points)
            inchesBox.Text = convertToInches(points)
            pointsBox.Text = ""
        End If
    End Sub

    Private Function convertToInches(points As Decimal) As String
        Return (points / 50).ToString
    End Function

    Private Function convertoPoints(inches As Decimal) As String
        Return (inches * 50).ToString
    End Function
End Class
