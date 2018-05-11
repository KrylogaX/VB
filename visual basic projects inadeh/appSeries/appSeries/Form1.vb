Public Class Form1
    Private Sub btnGenerarNumeros_Click(sender As Object, e As EventArgs) Handles btnGenerarNumeros.Click
        Dim i As Integer
        Dim cuantos As Integer

        cuantos = InputBox("Cuantos numeros desea generar?")
        If cuantos > 0 Then
            i = 1
            lbxNumeros.Items.Clear()
            While i <= cuantos
                lbxNumeros.Items.Add(i)
                i += 1
            End While
        ElseIf cuantos < 0
            MsgBox("El numero que introdujo es negativo")
        End If
    End Sub

    Private Sub btnGenerarNumerosPares_Click(sender As Object, e As EventArgs) Handles btnGenerarNumerosPares.Click
        Dim i As Integer
        Dim cuantos As Long
        Dim num As Integer
        cuantos = InputBox("Cuantos numeros pares desea generar?")
        If cuantos > 0 Then
            num = 0
            i = 1
            lbxPares.Items.Clear()
            While i <= cuantos
                num += 2
                lbxPares.Items.Add(num)
                i += 1
            End While
        ElseIf cuantos < 0
            MsgBox("El numero que introdujo es negativo")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerarNumImpares.Click
        Dim i As Integer
        Dim cuantos As Long
        Dim num As Integer
        cuantos = InputBox("Cuantos numeros pares desea generar?")
        If cuantos > 0 Then
            num = -1
            i = 1
            lbxImpares.Items.Clear()
            While i <= cuantos
                num += 2
                lbxImpares.Items.Add(num)
                i += 1
            End While
        ElseIf cuantos < 0
            MsgBox("El numero que introdujo es negativo")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFracciones.Click
        Dim i As Integer
        Dim cuantos As Long
        Dim num, num2 As Integer
        Dim content As String
        content = num & "/" & num2
        cuantos = InputBox("Cuantas fracciones pares desea generar?")

        If cuantos > 0 Then
            num = -1
            num2 = 0
            i = 1
            lbxFracciones.Items.Clear()
            While i <= cuantos
                num += 2
                num2 += 2
                content = num & "/" & num2
                lbxFracciones.Items.Add(content)
                i += 1
            End While
        ElseIf cuantos < 0
            MsgBox("El numero que introdujo es negativo")
        End If
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        Dim i As Integer
        Dim num, res As Integer
        Dim content As String

        num = InputBox("Que tabla de multiplicar desea generar?")

        If num >= 0 Then
            i = 1
            lbxTabla.Items.Clear()
            Do Until i > 12
                res = num * i
                content = num & "*" & i & "=" & res
                lbxTabla.Items.Add(content)
                i += 1
            Loop
        ElseIf num < 0
            MsgBox("El numero que introdujo es negativo")
        End If
    End Sub

    Private Sub btnSeries_Click(sender As Object, e As EventArgs) Handles btnSeries.Click

        Dim i As Integer
        Dim serie, num, res, total As Integer

        serie = InputBox("Que numero de serie desea generar?")
        num = InputBox("Cuantos numero de la serie desea generar?")

        If num >= 0 Then

            lbxSeries.Items.Clear()

            Do While i < num

                res += serie
                lbxSeries.Items.Add(res)
                total += res
                i += 1

            Loop
        ElseIf num < 0
            MsgBox("El numero que introdujo es negativo")
        End If
        lblTotal.Text = "Total: " & total
    End Sub

    Private Sub btnFibonacci_Click(sender As Object, e As EventArgs) Handles btnFibonacci.Click
        Dim i = 0, ultimo, penultimo, num As Integer

        num = txtFibonacci.Text

        If num >= 0 Then

            lbxFibonacci.Items.Clear()

            Do While i < num

                If i = 0 Or i = 1 Then
                    lbxFibonacci.Items.Add(i)
                Else
                    penultimo = lbxFibonacci.Items(i - 2)
                    ultimo = lbxFibonacci.Items(i - 1)
                    lbxFibonacci.Items.Add(ultimo + penultimo)
                End If

                i += 1

            Loop
        ElseIf i < 0
            MsgBox("El numero que introdujo es negativo")
        End If

    End Sub

    Private Sub btnDesdeHasta_Click(sender As Object, e As EventArgs) Handles btnDesdeHasta.Click

        Dim i As Integer

        If txtbDesde.Text >= 0 Or txtbHasta.Text >= 0 Then

            lbxDesdeHasta.Items.Clear()

            For i = txtbDesde.Text To txtbHasta.Text
                lbxDesdeHasta.Items.Add(i)
            Next
        ElseIf txtbDesde.Text < 0 Or txtbHasta.Text < 0
            MsgBox("El numero que introdujo es negativo")
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSerieCuadrada.Click
        Dim i, j As Integer
        Dim res As String

        If txtbSerieCuadrada.Text >= 0 Then

            lbxSerieCuadrada.Items.Clear()

            For i = 1 To txtbSerieCuadrada.Text
                res = ""

                For j = 1 To txtbSerieCuadrada.Text

                    res = res & j

                Next
                lbxSerieCuadrada.Items.Add(res)
            Next
        ElseIf txtbDesde.Text < 0 Or txtbHasta.Text < 0
            MsgBox("El numero que introdujo es negativo")
        End If
    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
        Dim i, j As Integer
        Dim res As String

        If txtbTriangulo.Text >= 0 Then

            lbxTriangulo.Items.Clear()

            For i = 1 To txtbTriangulo.Text
                res = ""

                For j = 1 To i

                    res = res & "*  "

                Next
                lbxTriangulo.Items.Add(res)
            Next
        ElseIf txtbDesde.Text < 0 Or txtbHasta.Text < 0
            MsgBox("El numero que introdujo es negativo")
        End If
    End Sub
End Class
