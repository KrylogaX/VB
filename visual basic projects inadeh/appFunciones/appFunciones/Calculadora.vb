Module Calculadora
    Function Sumar(ByRef n1 As Integer, n2 As Integer) As Integer
        Dim sum As Integer

        sum = n1 + n2

        Return sum

    End Function

    Function resta(ByRef n1 As Integer, n2 As Integer) As Integer
        Dim sum As Integer

        sum = n1 - n2

        Return sum

    End Function

    Function multi(ByRef n1 As Integer, n2 As Integer) As Integer
        Dim sum As Integer

        sum = n1 * n2

        Return sum

    End Function
    Function Dividir(ByRef n1 As Integer, n2 As Integer) As Integer
        Dim sum As Integer

        sum = n1 / n2

        Return sum

    End Function

    Function numerosPares(cantidad As Integer) As Integer()
        Dim arrPares(cantidad - 1), i As Integer
        For i = 0 To cantidad - 1
            arrPares(i) = (i + 1) * 2
        Next

        Return arrPares

    End Function
End Module
