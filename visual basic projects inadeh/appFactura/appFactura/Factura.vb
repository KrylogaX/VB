Public Class Factura

    Public codigoArticulo As String
    Public descripcion As String
    Public cantidad As Integer
    Public precioUnitario As Decimal

    Public Function consultarSubtotal() As Decimal
        Dim subtotal As Decimal

        subtotal = cantidad * precioUnitario

        Return subtotal
    End Function

    Public Function consultarImpuesto() As Decimal
        Dim impuesto As Decimal

        impuesto = 0.07 * consultarSubtotal()

        Return impuesto
    End Function

    Public Function consultarTOTAL() As Decimal
        Dim total As Decimal

        total = consultarImpuesto() + consultarSubtotal()

        Return total
    End Function

End Class
