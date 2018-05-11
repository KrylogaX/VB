Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCambiaramarillo.Click
        btnSemaforo.BackColor = Color.Yellow

    End Sub

    Private Sub btnCambiarverde_Click(sender As Object, e As EventArgs) Handles btnCambiarverde.Click
        btnSemaforo.BackColor = Color.Green



    End Sub

    Private Sub bntCambiarrojo_Click(sender As Object, e As EventArgs) Handles bntCambiarrojo.Click
        btnSemaforo.BackColor = Color.Tomato


    End Sub

    Private Sub btnSemaforo_Click(sender As Object, e As EventArgs) Handles btnSemaforo.Click

    End Sub
End Class
