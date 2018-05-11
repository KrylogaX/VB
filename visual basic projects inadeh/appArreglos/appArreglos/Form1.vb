Public Class Form1
    Dim arrNumeros(4) As Integer

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim i As Integer

        For i = 0 To 4
            arrNumeros(i) = InputBox("Ingrese el valor del elemento " & i + 1)
        Next
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer
        lbxNumeros.Items.Clear()
        For i = 0 To 4
            lbxNumeros.Items.Add(arrNumeros(i))
        Next
    End Sub

    Private Sub btnSumatoria_Click(sender As Object, e As EventArgs) Handles btnSumatoria.Click
        Dim sum, i As Integer
        sum = 0
        i = 0
        For i = 0 To 4
            sum = sum + arrNumeros(i)
        Next
        MsgBox(sum)

    End Sub

    Private Sub btnPromedio_Click(sender As Object, e As EventArgs) Handles btnPromedio.Click
        Dim sum, i As Integer
        sum = 0
        i = 0
        For i = 0 To 4
            sum = sum + arrNumeros(i)
        Next
        MsgBox(sum / 5)
    End Sub

    Private Sub btnPares_Click(sender As Object, e As EventArgs) Handles btnPares.Click
        Dim pares, i As Integer
        For i = 0 To 4
            If (arrNumeros(i) Mod 2 = 0) Then
                pares = pares + 1
            End If
        Next
        MsgBox(pares)
    End Sub

    Private Sub btnImpares_Click(sender As Object, e As EventArgs) Handles btnImpares.Click
        Dim impares, i As Integer
        For i = 0 To 4
            If (arrNumeros(i) Mod 2 > 0) Then
                impares = impares + 1
            End If
        Next
        MsgBox(impares)
    End Sub
End Class
