Module arreglos
    Function cargar() As Integer()
        Dim arr(5) As Integer
        Dim i As Integer
        For i = 0 To 4
            arr(i) = InputBox("Indtroduzca un numero")
        Next

        Return arr
    End Function

    Sub sumararreglos(a1() As Integer, a2() As Integer, r() As Integer)
        Dim cantidad As Integer
        Dim i As Integer
        cantidad = a1.Length

        For i = 0 To cantidad - 1
            r(i) = a1(i) + a2(i)
        Next
    End Sub

    Sub arrProm(prom() As Integer)
        Dim cantidad As Integer
        Dim i, promedio As Integer
        cantidad = prom.Length

        For i = 0 To cantidad - 1
            promedio = prom(i) + promedio
        Next
        promedio = promedio / cantidad

        MsgBox("El promedio es " & promedio)
    End Sub

End Module
