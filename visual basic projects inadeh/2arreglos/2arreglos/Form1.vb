Public Class Form1
    Dim arreglo1(4), arreglo2(4) As Integer

    Private Sub btnArreglo2_Click(sender As Object, e As EventArgs) Handles btnArreglo2.Click
        Dim i As Integer
        For i = 0 To 3
            arreglo2(i) = InputBox("Ingrese el elemento # " & i + 1)

        Next
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer
        lbxArreglo1.Items.Clear()
        lbxArreglo2.Items.Clear()
        For i = 0 To 3
            lbxArreglo1.Items.Add(arreglo1(i))
        Next
        For i = 0 To 3
            lbxArreglo2.Items.Add(arreglo2(i))
        Next
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim i, suma(4) As Integer
        lbxSumar.Items.Clear()
        For i = 0 To 3
            suma(i) = arreglo1(i) + arreglo2(i)
            lbxSumar.Items.Add(suma(i))
        Next
    End Sub

    Private Sub btnArreglo1_Click(sender As Object, e As EventArgs) Handles btnArreglo1.Click
        Dim i As Integer
        For i = 0 To 3
            arreglo1(i) = InputBox("Ingrese el elemento # " & i + 1)

        Next
    End Sub
End Class
