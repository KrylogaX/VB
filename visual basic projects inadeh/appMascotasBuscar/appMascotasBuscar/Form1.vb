Public Class Form1
    Dim arrMascota() As tipoMascota
    Dim cantidadMascota As Double
    Dim impuesto As Decimal

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ReDim Preserve arrMascota(cantidadMascota)
        impuesto = 0.1
        arrMascota(cantidadMascota).edad = tbxEdad.Text
        arrMascota(cantidadMascota).Nombre = tbxNombre.Text
        arrMascota(cantidadMascota).raza = cmbRaza.SelectedItem

        cantidadMascota += 1

        tbxNombre.Clear()
        tbxEdad.Clear()

    End Sub

    Private Sub btnMostrarTodos_Click(sender As Object, e As EventArgs) Handles btnMostrarTodos.Click
        Dim i As Integer
        lbxInfo.Items.Clear()
        If cantidadMascota = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadMascota - 1

                lbxInfo.Items.Add("Nombre: " & arrMascota(i).Nombre)
                lbxInfo.Items.Add("Edad: " & arrMascota(i).edad)
                lbxInfo.Items.Add("Raza: " & arrMascota(i).raza)
                lbxInfo.Items.Add("")


            Next
        End If
    End Sub

    Private Sub bntBuscar_Click(sender As Object, e As EventArgs) Handles bntBuscar.Click
        Dim i As Integer
        Dim razaBuscada As String
        Dim edadHasta, edadDesde As Integer

        razaBuscada = cmbRazaBuscar.SelectedItem
        edadHasta = tbxHasta.Text
        edadDesde = tbxDesde.Text
        lbxInfo.Items.Clear()

        If cantidadMascota = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadMascota - 1
                If (razaBuscada = arrMascota(i).raza) And (arrMascota(i).edad <= edadHasta) And (arrMascota(i).edad >= edadDesde) Then
                    lbxInfo.Items.Add("Nombre: " & arrMascota(i).Nombre)
                    lbxInfo.Items.Add("Edad: " & arrMascota(i).edad)
                    lbxInfo.Items.Add("Raza: " & arrMascota(i).raza)
                    lbxInfo.Items.Add("")
                End If
            Next
        End If
    End Sub
End Class
Structure tipoMascota
    Dim edad As Integer
    Dim raza As String
    Dim Nombre As String
End Structure