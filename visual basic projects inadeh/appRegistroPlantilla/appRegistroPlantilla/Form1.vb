Public Class Form1
    Dim arrEmpleado() As tipoEmpleado
    Dim cantidadEmpleado As Double
    Dim impuesto As Decimal

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ReDim Preserve arrEmpleado(cantidadEmpleado)
        impuesto = 0.1
        arrEmpleado(cantidadEmpleado).codigo = tbxCodigo.Text
        arrEmpleado(cantidadEmpleado).Nombre = tbxNombre.Text
        arrEmpleado(cantidadEmpleado).salarioBruto = tbxSalarioBruto.Text

        arrEmpleado(cantidadEmpleado).salarioNeto = arrEmpleado(cantidadEmpleado).salarioBruto - (arrEmpleado(cantidadEmpleado).salarioBruto * impuesto)


        cantidadEmpleado += 1

        tbxNombre.Clear()
        tbxCodigo.Clear()
        tbxSalarioBruto.Clear()

    End Sub

    Private Sub btnMostrarPlanilla_Click(sender As Object, e As EventArgs) Handles btnMostrarPlanilla.Click
        Dim totalsalarioneto As Double
        totalsalarioneto = 0
        lbxInfo.Items.Clear()
        If cantidadEmpleado = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadEmpleado - 1

                lbxInfo.Items.Add("Codigo: " & arrEmpleado(i).codigo)
                lbxInfo.Items.Add("Nombre: " & arrEmpleado(i).Nombre)
                lbxInfo.Items.Add("Salario Neto: " & arrEmpleado(i).salarioNeto)
                lbxInfo.Items.Add("")


            Next
        End If
        For i = 0 To cantidadEmpleado - 1


            totalsalarioneto += arrEmpleado(i).salarioNeto


        Next
        lbxInfo.Items.Add("Total =" & totalsalarioneto)
    End Sub

    Private Sub bntMostrarImpuestos_Click(sender As Object, e As EventArgs) Handles btnMostrarImpuestos.Click
        Dim totalimpuesto As Double
        Dim impuesto As Decimal
        totalimpuesto = 0
        impuesto = 0.1
        lbxInfo.Items.Clear()
        If cantidadEmpleado = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadEmpleado - 1

                lbxInfo.Items.Add("Codigo: " & arrEmpleado(i).codigo)
                lbxInfo.Items.Add("Nombre: " & arrEmpleado(i).Nombre)
                lbxInfo.Items.Add("Impuesto: " & arrEmpleado(i).salarioBruto * impuesto)
                lbxInfo.Items.Add("")

            Next

            For i = 0 To cantidadEmpleado - 1


                totalimpuesto += (impuesto * arrEmpleado(i).salarioBruto)


            Next
            lbxInfo.Items.Add("Total =" & totalimpuesto)
        End If
    End Sub

    Private Sub bntBuscar_Click(sender As Object, e As EventArgs) Handles bntBuscar.Click
        Dim i As Integer
        Dim codigoBuscado As Double

        codigoBuscado = InputBox("Ingrese el codigo del empleado que desea buscar")
        lbxInfo.Items.Clear()

        If cantidadEmpleado = 0 Then
            MsgBox("No hay Articulos registrados aun")
        Else
            For i = 0 To cantidadEmpleado - 1
                If codigoBuscado = arrEmpleado(i).codigo Then
                    lbxInfo.Items.Add("Codigo: " & arrEmpleado(i).codigo)
                    lbxInfo.Items.Add("Nombre: " & arrEmpleado(i).Nombre)
                    lbxInfo.Items.Add("Impuesto: " & arrEmpleado(i).salarioBruto * impuesto)
                    lbxInfo.Items.Add("")
                End If
            Next
        End If

    End Sub
End Class

Structure tipoEmpleado
    Dim codigo As Double
    Dim salarioBruto, impuesto, salarioNeto As Decimal
    Dim Nombre As String
End Structure