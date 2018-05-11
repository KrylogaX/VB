Module Costos
    Function subtotal(cm As Integer) As Decimal

        If cm <= 1 Then
            Return 100
        Else
            Return 100 + ((cm - 1) * 10)
        End If
    End Function

    Function impuesto(st As Decimal) As Decimal

        Return st * 0.07

    End Function

    Function total(imp As Decimal, subt As Decimal) As Decimal

        Return imp + subt

    End Function
End Module
