Public Class Form1
    Dim arrMascota() As tipoMascota
    Dim cantidadMascotas As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ReDim Preserve arrMascota(cantidadMascotas)

        arrMascota(cantidadMascotas).nombre = tbxNombre.Text
        arrMascota(cantidadMascotas).edad = tbxEdad.Text
        arrMascota(cantidadMascotas).raza = tbxRaza.Text
        arrMascota(cantidadMascotas).nombreAmo = tbxAmo.Text

        cantidadMascotas += 1

        tbxAmo.Clear()
        tbxEdad.Clear()
        tbxNombre.Clear()
        tbxRaza.Clear()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer

        'tbxNombre.Text = arrMascota(cantidadMascotas).nombre
        'tbxEdad.Text = arrMascota(cantidadMascotas).edad
        'tbxRaza.Text = arrMascota(cantidadMascotas).raza
        'tbxAmo.Text = arrMascota(cantidadMascotas).nombreAmo

        If cantidadMascotas = 0 Then
            MsgBox("No hay mascotas registradas aun")
        Else
            For i = 0 To cantidadMascotas - 1

                ListBox1.Items.Add("Nombre: " & arrMascota(i).nombre)
                ListBox1.Items.Add("Edad: " & arrMascota(i).edad)
                ListBox1.Items.Add("Raza: " & arrMascota(i).raza)
                ListBox1.Items.Add("Amo: " & arrMascota(i).nombreAmo)
                ListBox1.Items.Add("")

            Next
        End If

    End Sub
End Class

Structure tipoMascota
    Dim edad As Integer
    Dim nombre, raza, nombreAmo As String
End Structure
