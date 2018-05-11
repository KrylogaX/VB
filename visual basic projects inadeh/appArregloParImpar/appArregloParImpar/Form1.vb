Public Class Form1
    Dim arreglo(10) As Integer
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim i, par, impar As Integer
        lbxArreglo.Items.Clear()
        par = 0
        impar = 0

        For i = 0 To 9
            arreglo(i) = InputBox("Ingrese el elemento # " & i + 1)
        Next

        For i = 0 To 9
            lbxArreglo.Items.Add(arreglo(i))
        Next

        For i = 0 To 9
            If arreglo(i) Mod 2 = 0 Then
                par += 1
            Else
                impar += 1
            End If
        Next

        lblImpar.Text = "Impares: " & impar
        lblPar.Text = "Pares: " & par

    End Sub

    Private Sub btnPares_Click(sender As Object, e As EventArgs) Handles btnPares.Click
        Dim i As Integer
        lbxArreglo.Items.Clear()
        For i = 0 To 9
            If arreglo(i) Mod 2 = 0 Then
                lbxArreglo.Items.Add(arreglo(i))
            End If

        Next
    End Sub

    Private Sub btnImpares_Click(sender As Object, e As EventArgs) Handles btnImpares.Click
        Dim i As Integer
        lbxArreglo.Items.Clear()
        For i = 0 To 9
            If arreglo(i) Mod 2 = 0 Then

            Else
                lbxArreglo.Items.Add(arreglo(i))
            End If

        Next
    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        Dim i As Integer
        lbxArreglo.Items.Clear()
        For i = 0 To 9

            lbxArreglo.Items.Add(arreglo(i))

        Next
    End Sub

    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        Dim i, mayor As Integer
        lbxArreglo.Items.Clear()
        mayor = arreglo(1)
        For i = 0 To 9
            If arreglo(i) > mayor Then
                mayor = arreglo(i)
            End If
        Next
        lbxArreglo.Items.Add(mayor)
    End Sub
End Class
