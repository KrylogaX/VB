Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        MsgBox("Hiciste Click en el boton")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPreguntarNombre.Click
        Dim a As String
        a= InputBox("Cual es su nombre")
        MsgBox("Su nombre es: " & a)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox.TextChanged

    End Sub

    Private Sub btnLeertitulo_Click(sender As Object, e As EventArgs) Handles btnLeertitulo.Click

        MsgBox("El titulo es " & lblMensaje.Text)


    End Sub

    Private Sub lblMensaje_Click(sender As Object, e As EventArgs) Handles lblMensaje.Click

    End Sub

    Private Sub btnCambiartitulo_Click(sender As Object, e As EventArgs) Handles btnCambiartitulo.Click
        Dim titulo As String
        titulo = txtBox.Text
        lblMensaje.Text = titulo
    End Sub
End Class
