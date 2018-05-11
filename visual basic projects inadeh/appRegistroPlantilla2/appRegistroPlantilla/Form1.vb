Public Class Form1
    Dim arrPerros() As tipoPerros
    Dim cantidadPerros As Double


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ReDim Preserve arrPerros(cantidadPerros)

        arrPerros(cantidadPerros).Raza = ComboBox1.SelectedItem
        arrPerros(cantidadPerros).Nombre = tbxNombre.Text
        arrPerros(cantidadPerros).edad = tbxEdad.Text




        cantidadPerros += 1

        tbxNombre.Clear()

        tbxEdad.Clear()

    End Sub

    Private Sub btnMostrarPlanilla_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
       
        lbxInfo.Items.Clear()
        If cantidadPerros = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadPerros - 1

                lbxInfo.Items.Add("Nombre: " & arrPerros(i).Nombre)
                lbxInfo.Items.Add("Edad: " & arrPerros(i).Edad)
                lbxInfo.Items.Add("Raza: " & arrPerros(i).Raza)
                lbxInfo.Items.Add("")


            Next
        End If
        
    End Sub

    

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscarXEdad.Click
        Dim i As Integer


        lbxInfo.Items.Clear()

        For i = 0 To cantidadPerros - 1
            If (arrPerros(i).Edad <= tbxde.Text) Or (arrPerros(i).Edad >= tbxhasta.Text) Then
                lbxInfo.Items.Add("Nombre: " & arrPerros(i).Nombre)
                lbxInfo.Items.Add("Edad: " & arrPerros(i).Edad)
                lbxInfo.Items.Add("Raza: " & arrPerros(i).Raza)
                lbxInfo.Items.Add("")
            End If
        Next


    End Sub

    

    Private Sub btnBuscarXRaza_Click(sender As Object, e As EventArgs) Handles btnBuscarXRaza.Click
        Dim i As Integer
        Dim BuscarX As String
        BuscarX = ComboBox2.SelectedItem
        lbxInfo.Items.Clear()

        For i = 0 To cantidadPerros - 1
            If (BuscarX = arrPerros(i).Raza) Then
                lbxInfo.Items.Add("Nombre: " & arrPerros(i).Nombre)
                lbxInfo.Items.Add("Edad: " & arrPerros(i).Edad)
                lbxInfo.Items.Add("Raza: " & arrPerros(i).Raza)
                lbxInfo.Items.Add("")
            End If
        Next


    End Sub
End Class

Structure tipoPerros
    Dim Edad As Double
    Dim Nombre, Raza As String
End Structure