Public Class Form1
    Dim arrestudiante() As tipoestudiante
    Dim cantidadestudiante As Integer



    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ReDim Preserve arrestudiante(cantidadestudiante)

        arrestudiante(cantidadestudiante).nombre = txt1.Text
        arrestudiante(cantidadestudiante).nota1 = txt2.Text
        arrestudiante(cantidadestudiante).nota2 = txt3.Text
        arrestudiante(cantidadestudiante).nota3 = txt4.Text

        arrestudiante(cantidadestudiante).notaF = (arrestudiante(cantidadestudiante).nota1 + arrestudiante(cantidadestudiante).nota2 + arrestudiante(cantidadestudiante).nota3) / 3

        cantidadestudiante += 1

        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim i As Integer
        lbx1.Items.Clear()
        For i = 0 To cantidadestudiante - 1

            lbx1.Items.Add(arrestudiante(i).nombre & "   " & arrestudiante(i).notaF)

            lbx1.Items.Add("")
        Next
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim i As Integer
        lbx1.Items.Clear()
        lbx1.Items.Add("REPROBADOS")
        lbx1.Items.Add("")
        For i = 0 To cantidadestudiante - 1
            If arrestudiante(i).notaF < 71 Then
                lbx1.Items.Add(arrestudiante(i).nombre & "   " & arrestudiante(i).notaF)

                lbx1.Items.Add("")

            End If

        Next
    End Sub
End Class
Structure tipoestudiante
    Dim nombre As String
    Dim notaF, nota1, nota2, nota3 As Integer
End Structure
