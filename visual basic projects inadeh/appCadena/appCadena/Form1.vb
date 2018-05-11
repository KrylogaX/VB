Public Class Form1
    Dim letra As Char
    Private Sub btnCantidad_Click(sender As Object, e As EventArgs) Handles btnCantidad.Click
        lblMensaje.Text = "Caracteres: " & txbPalabra.Text.Length
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCanta.Click
        Dim i, cant As Integer

        For i = 0 To txbPalabra.Text.Length - 1
            If txbPalabra.Text(i) = "a" Then
                cant += 1
            End If
        Next
        lblA.Text = "a minusculas: " & cant
    End Sub

    Public Sub btnCantidadpreg_Click(sender As Object, e As EventArgs) Handles btnCantidadpreg.Click
        Dim i, cant As Integer
        letra = InputBox("Que letra desea buscar la cantidad")

        For i = 0 To txbPalabra.Text.Length - 1
            If txbPalabra.Text(i) = letra Then
                cant += 1
            End If
        Next
        lblCantPreg.Text = "Cantidad de " & letra & ": " & cant
    End Sub

    Private Sub txbPalabra_TextChanged(sender As Object, e As EventArgs) Handles txbPalabra.TextChanged
        Dim i, cant, cant1 As Integer

        For i = 0 To txbPalabra.Text.Length - 1
            If txbPalabra.Text(i) = "a" Then
                cant += 1
            End If
        Next
        lblA.Text = "a minusculas: " & cant
        lblMensaje.Text = "Caracteres: " & txbPalabra.Text.Length

        For i = 0 To txbPalabra.Text.Length - 1
            If txbPalabra.Text(i) = letra Then
                cant1 += 1
            End If
        Next
        lblCantPreg.Text = "Cantidad de " & letra & ": " & cant1
    End Sub
End Class
