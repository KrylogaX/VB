Public Class Form1
    Dim objFactura As New Factura

    Private Sub btnSubtotal_Click(sender As Object, e As EventArgs) Handles btnSubtotal.Click

        objFactura.codigoArticulo = txbCodigo.Text
        objFactura.cantidad = txbCantidad.Text
        objFactura.descripcion = txbDescripcion.Text
        objFactura.precioUnitario = txbPrecioUnit.Text

        MsgBox("El subtotal del Articulo " & objFactura.descripcion & " es: " & objFactura.consultarSubtotal())

    End Sub

    Private Sub btnImpuesto_Click(sender As Object, e As EventArgs) Handles btnImpuesto.Click

        objFactura.codigoArticulo = txbCodigo.Text
        objFactura.cantidad = txbCantidad.Text
        objFactura.descripcion = txbDescripcion.Text
        objFactura.precioUnitario = txbPrecioUnit.Text

        MsgBox("El subtotal del Articulo " & objFactura.descripcion & " es: " & objFactura.consultarImpuesto())
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        objFactura.codigoArticulo = txbCodigo.Text
        objFactura.cantidad = txbCantidad.Text
        objFactura.descripcion = txbDescripcion.Text
        objFactura.precioUnitario = txbPrecioUnit.Text

        MsgBox("El subtotal del Articulo " & objFactura.descripcion & " es: " & objFactura.consultarTOTAL())
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        objFactura.codigoArticulo = txbCodigo.Text
        objFactura.cantidad = txbCantidad.Text
        objFactura.descripcion = txbDescripcion.Text
        objFactura.precioUnitario = txbPrecioUnit.Text

        txbSubtotal.Text = objFactura.consultarSubtotal()
        txbImpuesto.Text = objFactura.consultarImpuesto()
        txbTotal.Text = objFactura.consultarTOTAL()

    End Sub



End Class
