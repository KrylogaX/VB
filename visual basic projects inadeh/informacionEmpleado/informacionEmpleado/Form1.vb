Public Class Form1
    Dim totalPlanilla As Decimal
    Private Sub lbxInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxInfo.SelectedIndexChanged

    End Sub
    Private Sub appInfoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String
        Dim salario As Decimal
        Dim cedula As String
        Dim informacion As String

        cedula = txtCedula.Text
        salario = txtSalario.Text
        nombre = txtNombre.Text

        informacion = cedula & " - " & nombre & " - " & salario

        lbxInfo.Items.Add(informacion)
        totalPlanilla = totalPlanilla + salario
    End Sub

    Private Sub btnPlanilla_Click(sender As Object, e As EventArgs) Handles btnPlanilla.Click
        Dim i As Integer = 0

        lblTotal.Text = Me.totalPlanilla

    End Sub
End Class
