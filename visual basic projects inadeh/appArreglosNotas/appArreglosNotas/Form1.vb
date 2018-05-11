Public Class Form1
    Dim nombres(5) As String
    Dim notas(5) As Decimal
    Private Sub btnNombres_Click(sender As Object, e As EventArgs) Handles btnNombres.Click
        Dim i As Integer
        For i = 0 To 4
            nombres(i) = InputBox("Introduzca el nombre del estudiante #" & i + 1)
            notas(i) = InputBox("introduzca la nota del estudiante #" & i + 1)
        Next
    End Sub

    Private Sub lbxMostrar_Click(sender As Object, e As EventArgs) Handles lbxMostrar.Click
        Dim i As Integer
        lbxInfo.Items.Clear()
        For i = 0 To 4
            lbxInfo.Items.Add(nombres(i) & " = " & notas(i))
        Next
    End Sub

    Private Sub btnReprobados_Click(sender As Object, e As EventArgs) Handles btnReprobados.Click
        Dim i As Integer
        lbxInfo.Items.Clear()
        For i = 0 To 4
            If notas(i) <= 60 Then
                lbxInfo.Items.Add(nombres(i) & " = " & notas(i))
            End If
        Next
    End Sub

    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        Dim i, mayor As Integer
        lbxInfo.Items.Clear()
        mayor = notas(1)
        For i = 0 To 4
            If notas(i) > mayor Then
                mayor = notas(i)
            End If
        Next

        For i = 0 To 4
            If notas(i) = mayor Then
                lbxInfo.Items.Add(nombres(i) & " = " & notas(i))
            End If
        Next
    End Sub
End Class
