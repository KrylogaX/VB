Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCalcularbono_Click(sender As Object, e As EventArgs) Handles btnCalcularbono.Click
        Dim total, bono As Double
        Dim por As String
        total = txtTotalventas.Text
        If total >= 1000000 Then
            por = "0.01%"
            bono = total * 0.0001
        ElseIf total < 1000000 And total >= 100000
            por = "0.005%"
            bono = total * 0.00005
        Else
            por = "NO HAY NA PA TI"
            bono = total * 0

        End If
        Label2.Text = "Bono: " & por
        lblBono.Text = bono
    End Sub
End Class
