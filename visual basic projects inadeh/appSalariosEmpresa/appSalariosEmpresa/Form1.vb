Public Class Form1
    Dim nombres(10) As String
    Dim salarioNeto(10) As Double
    Private Sub btnCaptar_Click(sender As Object, e As EventArgs) Handles btnCaptar.Click
        Dim i As Integer
        For i = 0 To 9
            nombres(i) = InputBox("Ingrese el nombre del empleado # " & i + 1)
            salarioNeto(i) = InputBox("Ingrese el salario neto del empleado # " & i + 1)
        Next
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer
        lbxSalarios.Items.Clear()
        lbxSalarios.Items.Clear()
        For i = 0 To 9
            lbxSalarios.Items.Add(nombres(i) & " - " & salarioNeto(i))
        Next
    End Sub
End Class
