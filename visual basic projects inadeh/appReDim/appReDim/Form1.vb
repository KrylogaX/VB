Public Class Form1

    Dim arrNumeros(), cantidadElementos As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim numero As Integer
        numero = tbxIngresar.Text

        'cantidadElementos = arrNumeros.Length
        'redimensionando el arreglo, notese el "preserve" , sirve para que no se pierdan los datos que habia en el arreglo
        ReDim Preserve arrNumeros(cantidadElementos)

        arrNumeros(cantidadElementos) = numero

        cantidadElementos = cantidadElementos + 1
        tbxIngresar.Clear()
        tbxIngresar.Focus()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer
        'i = arrNumeros.Length
        ListBox1.Items.Clear()
        If cantidadElementos = 0 Then
            MsgBox("El arreglo no tiene elementos")
        Else
            For i = 0 To cantidadElementos - 1

                ListBox1.Items.Add(arrNumeros(i))
            Next
        End If

    End Sub
End Class
