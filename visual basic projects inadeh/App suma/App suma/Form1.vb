Public Class Form1
    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        Dim numero As Integer
        Dim numero2 As Integer
        Dim suma As Integer

        numero = 450
        numero2 = 20
        suma = numero + numero2
        MsgBox(numero)
        MsgBox("+")
        MsgBox(numero2)
        MsgBox(suma)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmultiplicacion.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim mul As Integer
        n1 = 20
        n2 = 4
        mul = n1 * n2
        MsgBox(n1)
        MsgBox("*")
        MsgBox(n2)
        MsgBox(mul)
    End Sub

    Private Sub btnsaludo_Click(sender As Object, e As EventArgs) Handles btnsaludo.Click
        Dim gimenes As String
        gimenes = "pedro"
        MsgBox(gimenes)
    End Sub

    Private Sub btnamigo_Click(sender As Object, e As EventArgs) Handles btnamigo.Click
        Dim saludo, n As String
        saludo = "santiago"
        n = "te carreo esta noche?"
        MsgBox(saludo & " " & n)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saludo, n As String
        saludo = "hola"
        MsgBox(saludo)
        n = InputBox("favor ingrese su nombre")
        MsgBox(saludo & " " & n)

    End Sub
End Class
