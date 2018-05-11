Public Class Form1
    Private Sub btnParimpar_Click(sender As Object, e As EventArgs) Handles btnParimpar.Click
        Dim a As Double

        a = txtNumero.Text

        If a = 0 Then
            MsgBox("Su numero es cero")
        ElseIf a Mod 2 = 0 Then
            MsgBox("Su numero es par")
        Else
            MsgBox("Su numero es impar")
        End If
    End Sub
End Class
