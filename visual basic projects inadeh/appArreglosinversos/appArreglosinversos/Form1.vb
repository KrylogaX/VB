Public Class Form1
    Dim arreglo1(5), arreglo2(5) As Integer
    Private Sub btnCargar1_Click(sender As Object, e As EventArgs) Handles btnCargar1.Click
        Dim i As Integer
        For i = 0 To 4
            arreglo1(i) = InputBox("Ingrese el elemento # " & i + 1)

        Next
    End Sub

    Private Sub btnCargar2_Click(sender As Object, e As EventArgs) Handles btnCargar2.Click
        Dim i As Integer
        For i = 0 To 4
            arreglo2(i) = InputBox("Ingrese el elemento # " & i + 1)

        Next
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer
        lbxArreglo1.Items.Clear()
        lbxArreglo2.Items.Clear()
        For i = 0 To 4
            lbxArreglo1.Items.Add(arreglo1(i))
        Next
        For i = 0 To 4
            lbxArreglo2.Items.Add(arreglo2(i))
        Next
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim i, suma, j As Integer
        j = 4
        lbxSuma.Items.Clear()
        For i = 0 To 4
            suma = arreglo1(i) + arreglo2(j)
            lbxSuma.Items.Add(suma)
            j -= 1
        Next
    End Sub
End Class
