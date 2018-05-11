Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b, a, triangulo As Double



        b = InputBox("ingrese la b")
        a = InputBox("ingrese la a")
        triangulo = b * a / 2
        MsgBox("el area del triangulo es: " & triangulo)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim l, cuadrado As Double

        l = InputBox("ingrese la l")

        cuadrado = l * l
        MsgBox("el area del cuadrado es: " & cuadrado)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim b, a, rectangulo As Double



        b = InputBox("ingrese la b")
        a = InputBox("ingrese la a")
        rectangulo = b * a
        MsgBox("el area del rectangulo es: " & rectangulo)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r, circunferencia As Double


        r = InputBox("ingrese la r")

        circunferencia = 3.1416 * (r ^ 2)
        MsgBox("el area de la circunferencia es: " & circunferencia)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim l, h, pentagono As Double


        l = InputBox("ingrese la l")
        h = InputBox("ingrese la h")
        pentagono = l * 5 * h / 2
        MsgBox("el area de la pentagono es: " & pentagono)
    End Sub
End Class
