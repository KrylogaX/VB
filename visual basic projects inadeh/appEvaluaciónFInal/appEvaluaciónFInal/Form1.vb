Public Class Form1

    Dim arrPasajero() As tipoPasajero
    Dim cantidadPasajeros As Integer
    Dim totalventas As Decimal

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        ReDim Preserve arrPasajero(cantidadPasajeros)

        arrPasajero(cantidadPasajeros).cedula = tbxCedula.Text
        arrPasajero(cantidadPasajeros).nombre = tbxNombre.Text
        arrPasajero(cantidadPasajeros).destino = tbxDestino.Text
        arrPasajero(cantidadPasajeros).maletas = tbxCantMaletas.Text

        arrPasajero(cantidadPasajeros).subtotal = Costos.subtotal(arrPasajero(cantidadPasajeros).maletas)

        arrPasajero(cantidadPasajeros).impuesto = Costos.impuesto(arrPasajero(cantidadPasajeros).subtotal)

        arrPasajero(cantidadPasajeros).total = Costos.total(arrPasajero(cantidadPasajeros).impuesto, arrPasajero(cantidadPasajeros).subtotal)


        cantidadPasajeros += 1

        tbxCedula.Clear()
        tbxNombre.Clear()
        tbxDestino.Clear()
        tbxCantMaletas.Clear()

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        lbxPasajeros.Items.Clear()
        totalventas = 0
        If cantidadPasajeros = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadPasajeros - 1

                lbxPasajeros.Items.Add("-Cedula: " & arrPasajero(i).cedula & " -Nombre: " & arrPasajero(i).nombre)
                lbxPasajeros.Items.Add("-Destino : " & arrPasajero(i).destino & " -Cantidad de maletas: " & arrPasajero(i).maletas)
                lbxPasajeros.Items.Add("-Subtotal: " & arrPasajero(i).subtotal & " -Impuesto: " & arrPasajero(i).impuesto)
                lbxPasajeros.Items.Add("-Total: " & arrPasajero(i).total)
                lbxPasajeros.Items.Add("")

                totalventas = totalventas + arrPasajero(i).total
            Next
        End If
        txbTotalVent.Text = totalventas
    End Sub
End Class

Structure tipoPasajero
    Dim cedula, nombre, destino As String
    Dim maletas As Integer
    Dim subtotal, total, impuesto As Decimal

End Structure
