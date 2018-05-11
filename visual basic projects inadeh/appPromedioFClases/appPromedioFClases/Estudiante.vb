Public Class Estudiante

    Public cedula As String
    Public nombre As String
    Public sexo As Char
    Public notas(3) As Integer

    Public Function consultarPromFinal() As Decimal
        Dim i As Integer
        Dim prom As Decimal

        For i = 0 To 3
            prom = prom + notas(i)
        Next

        Return prom / 3
    End Function

End Class
