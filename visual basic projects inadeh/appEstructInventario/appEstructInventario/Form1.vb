Public Class Form1
    Dim arrArticulo() As tipoInventario
    Dim cantidadArticulo As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ReDim Preserve arrArticulo(cantidadArticulo)

        arrArticulo(cantidadArticulo).codigo = tbxCodigo.Text
        arrArticulo(cantidadArticulo).descripcion = tbxDescripcion.Text
        arrArticulo(cantidadArticulo).precioUnitario = tbxPrecioUnidad.Text
        arrArticulo(cantidadArticulo).cantidad = tbxCantidad.Text
        arrArticulo(cantidadArticulo).precioTotal = arrArticulo(cantidadArticulo).cantidad * arrArticulo(cantidadArticulo).precioUnitario


        cantidadArticulo += 1

        tbxCantidad.Clear()
        tbxCodigo.Clear()
        tbxDescripcion.Clear()
        tbxPrecioUnidad.Clear()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        lbxLista.Items.Clear()
        If cantidadArticulo = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadArticulo - 1

                lbxLista.Items.Add("Codigo: " & arrArticulo(i).codigo)
                lbxLista.Items.Add("Descripcion: " & arrArticulo(i).descripcion)
                lbxLista.Items.Add("Precio Unitario: " & arrArticulo(i).precioUnitario)
                lbxLista.Items.Add("Cantidad: " & arrArticulo(i).cantidad)
                lbxLista.Items.Add("Precio Total: " & arrArticulo(i).precioTotal)
                lbxLista.Items.Add("")

            Next
        End If
    End Sub

End Class

Structure tipoInventario
    Dim codigo, precioUnitario, cantidad, precioTotal As Double
    Dim descripcion, raza, nombreAmo As String
    'precioTotal = prepcioUnitario * cantidad
End Structure
