Public Class Form1
    Dim objEstudiante As New Estudiante

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        objEstudiante.cedula = txbCedula.Text
        objEstudiante.nombre = txbNombre.Text
        objEstudiante.sexo = txbSexo.Text

        objEstudiante.notas(0) = txbNota1.Text
        objEstudiante.notas(1) = txbNota2.Text
        objEstudiante.notas(2) = txbNota3.Text

        txbProm.Text = objEstudiante.consultarPromFinal()

        MsgBox("El estudiante " & objEstudiante.nombre & " de cedula " & objEstudiante.cedula & " y sexo " & objEstudiante.sexo & " tiene un promedio de " & objEstudiante.consultarPromFinal)
    End Sub
End Class
