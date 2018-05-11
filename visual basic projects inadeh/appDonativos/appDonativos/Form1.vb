Public Class Form1
    Dim arrDonantes() As String
    Dim cantidadDonaciones, arrDonaciones() As Double
    Dim total As Double

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer
        'i = arrNumeros.Length
        lbxLista.Items.Clear()
        If cantidadDonaciones = 0 Then
            MsgBox("El arreglo no tiene elementos")
        Else
            For i = 0 To cantidadDonaciones - 1

                lbxLista.Items.Add(arrDonantes(i) & " = " & arrDonaciones(i))
            Next
        End If

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim i As Integer
        Dim total As Double
        For i = 0 To cantidadDonaciones - 1
            total = total + arrDonaciones(i)
        Next
        lblTotal.Text = "Total Donaciones: " & total
        'lbxLista.Items.Add("Total: " & total)
    End Sub

    Private Sub btnDonacion_Click(sender As Object, e As EventArgs) Handles btnDonacion.Click
        Dim monto As Double
        Dim nombre As String
        'monto = InputBox("Ingrese el monto")
        'nombre = InputBox("ingrese el nombre")
        monto = tbxMonto.Text
        nombre = tbxNombre.Text


        'redimensionando el arreglo, notese el "preserve" , sirve para que no se pierdan los datos que habia en el arreglo
        ReDim Preserve arrDonantes(cantidadDonaciones)
        ReDim Preserve arrDonaciones(cantidadDonaciones)

        arrDonantes(cantidadDonaciones) = nombre
        arrDonaciones(cantidadDonaciones) = monto

        cantidadDonaciones = cantidadDonaciones + 1
        tbxMonto.Clear()
        tbxNombre.Clear()
        tbxMonto.Focus()
        tbxMonto.Focus()
    End Sub
End Class
