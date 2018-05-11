Public Class formOperaciones
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        a = InputBox("Ingrese el primer numero")
        b = InputBox("ingrese el segundo numero")
        c = a + b
        MsgBox(a & " + " & b & " = " & c)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim a As Integer
        Dim b As Integer
        a = 2
        b = 2
        MsgBox(a)
        MsgBox("*")
        MsgBox(b)
        MsgBox("=")
        b = a * b
        MsgBox(b)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim a As Integer
        Dim b As Integer
        a = 2
        b = 2
        MsgBox(a)
        MsgBox("-")
        MsgBox(b)
        MsgBox("=")
        b = a - b
        MsgBox(b)
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim a As Integer
        Dim b As Integer
        a = 2
        b = 2
        MsgBox(a)
        MsgBox("/")
        MsgBox(b)
        MsgBox("=")
        b = a / b
        MsgBox(b)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnSalida.Click
        Dim miVar As String
        miVar = "Paquita la del Barrio"
        MsgBox(miVar)
    End Sub

    Private Sub btnAmigo_Click(sender As Object, e As EventArgs) Handles btnSaludarAmigo.Click
        Dim a As String
        Dim b As String
        a = "Hola"
        b = "Edwin"
        MsgBox(a & " " & b)
    End Sub

    Private Sub btnSaludo2_Click(sender As Object, e As EventArgs) Handles btnSaludo2.Click
        Dim a As String
        Dim b As String
        a = "Hola"
        b = InputBox("Ingrese el nombre de su amigo")
        MsgBox(a & " " & b)
    End Sub
End Class
