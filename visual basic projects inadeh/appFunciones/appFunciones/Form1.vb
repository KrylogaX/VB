Public Class Form1

    Dim arr1(), arr2(), arreglo(5) As Integer
    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim numero1, numero2, resultado As Integer

        numero1 = tbxIngresar1.Text
        numero2 = tbxIngresar2.Text

        resultado = Calculadora.resta(numero1, numero2)

        MsgBox("El resultado es " & resultado)
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim numero1, numero2, resultado As Integer

        numero1 = tbxIngresar1.Text
        numero2 = tbxIngresar2.Text

        resultado = Calculadora.multi(numero1, numero2)

        MsgBox("El resultado es " & resultado)
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim numero1, numero2, resultado As Integer

        numero1 = tbxIngresar1.Text
        numero2 = tbxIngresar2.Text

        resultado = Calculadora.Dividir(numero1, numero2)

        MsgBox("El resultado es " & resultado)
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim numero1, numero2, resultado As Integer

        numero1 = tbxIngresar1.Text
        numero2 = tbxIngresar2.Text

        resultado = Calculadora.Sumar(numero1, numero2)

        MsgBox("El resultado es " & resultado)
    End Sub

    Private Sub btnPromedio_Click(sender As Object, e As EventArgs) Handles btnPromedio.Click

        arreglos.arrProm(arreglo)
    End Sub

    Private Sub tbxArreglo_Click(sender As Object, e As EventArgs) Handles tbxArreglo.Click
        Dim i, cantidad As Integer
        arreglo = arreglos.cargar()

        lbxMostrar.Items.Clear()

        For i = 0 To cantidad - 1
            lbxMostrar.Items.Add(arreglo(i))
        Next

    End Sub

    Private Sub btnCantidad_Click(sender As Object, e As EventArgs) Handles btnCantidad.Click
        Dim cantidad, arrP(), i As Integer

        cantidad = InputBox("Cuantos?")

        arrP = Calculadora.numerosPares(cantidad)
        lbxMostrar.Items.Clear()

        For i = 0 To cantidad - 1
            lbxMostrar.Items.Add(arrP(i))
        Next
    End Sub


End Class
