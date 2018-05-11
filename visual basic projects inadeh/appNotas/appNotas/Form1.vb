Public Class Form1
    Private Sub btnEvaluar_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        Dim a As Integer
        Dim x As Char
        a = txtNotas.Text

        If a = 100 Or a >= 91 Then
            x = "A"

            lblNotafinal.ForeColor = Color.Blue
        ElseIf a < 91 And a >= 81
            x = "B"
            lblNotafinal.ForeColor = Color.Green
        ElseIf a < 81 And a >= 71
            x = "C"
            lblNotafinal.ForeColor = Color.Yellow
        ElseIf a < 71 And a >= 61
            x = "D"
            lblNotafinal.ForeColor = Color.Orange
        ElseIf a < 61
            x = "F"
            lblNotafinal.ForeColor = Color.Red
        End If

        lblNotafinal.Text = x
    End Sub
End Class
