Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objAuto As New Auto
        Dim objAuto2 As New Auto

        objAuto.year = 1990
        objAuto.marca = "Tesla"
        objAuto.kilometraje = 1000

        objAuto.encenderMotor()

        objAuto2.year = 2000
        objAuto2.marca = "Suzuki"
        objAuto2.kilometraje = 10000




    End Sub
End Class
