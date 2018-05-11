Public Class formAreas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
        Dim h, b, a As Double
        b = InputBox("Ingrese la base")
        h = InputBox("Ingrese la altura")
        a = (b * h) / 2
        MsgBox("El area del triangulo es " & a)
    End Sub

    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click
        Dim l, a As Double
        l = InputBox("Ingrese el tamaño de un lado")
        a = l * l
        MsgBox("El area del cuadrado es " & a)
    End Sub

    Private Sub btnRectangulo_Click(sender As Object, e As EventArgs) Handles btnRectangulo.Click
        Dim h, b, a As Double
        b = InputBox("Ingrese la base")
        h = InputBox("Ingrese la altura")
        a = b * h
        MsgBox("El area del rectangulo es " & a)
    End Sub

    Private Sub btnCirculo_Click(sender As Object, e As EventArgs) Handles btnCirculo.Click
        Dim r, a As Double
        r = InputBox("Ingrese el radio")
        a = Math.PI * (r * r)
        MsgBox("El area del circulo es " & a)
    End Sub

    Private Sub btnPentagono_Click(sender As Object, e As EventArgs) Handles btnPentagono.Click
        Dim l, a As Double
        l = InputBox("Ingrese el tamaño de un lado")
        a = 5 * (l * l)
        MsgBox("El area del pentagono es " & a)
    End Sub

    Private Sub btnFormula_Click(sender As Object, e As EventArgs) Handles btnFormula.Click
        Dim a, b, c, r As Double
        a = InputBox("Ingrese a")
        b = InputBox("Ingrese b")
        c = InputBox("Ingrese c")
        r = ((Math.Pow(b, 2)) - (4 * a * c)) / (2 * a)
        MsgBox("El Resultado de la formula es " & a)
    End Sub
End Class
