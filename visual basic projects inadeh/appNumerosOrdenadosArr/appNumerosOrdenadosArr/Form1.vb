Public Class Form1
    Dim arrNumeros(), arrDescendiente(), cantidadElementos As Integer

    Private Sub btnDescendente_Click(sender As Object, e As EventArgs) Handles btnDescendente.Click
        Dim i, k, mayor As Integer
        'i = arrNumeros.Length
        ListBox1.Items.Clear()
        If cantidadElementos = 0 Then
            MsgBox("El arreglo no tiene elementos")
        Else
            For i = 0 To cantidadElementos - 1
                For k = 0 To cantidadElementos - 1
                    If arrDescendiente(i) > arrDescendiente(k) Then
                        mayor = arrDescendiente(i)
                        arrDescendiente(i) = arrDescendiente(k)
                        arrDescendiente(k) = mayor
                    End If
                Next
            Next
            For i = 0 To cantidadElementos - 1
                ListBox1.Items.Add(arrDescendiente(i))
            Next
        End If
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim numero As Integer
        numero = tbxIngresar.Text

        ReDim Preserve arrNumeros(cantidadElementos)
        ReDim Preserve arrDescendiente(cantidadElementos)

        arrNumeros(cantidadElementos) = numero
        arrDescendiente(cantidadElementos) = numero
        cantidadElementos = cantidadElementos + 1
        tbxIngresar.Clear()
        tbxIngresar.Focus()
    End Sub
End Class
