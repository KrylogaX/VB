Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim b As Double
        Dim a As Double
        a = txtA.Text
        b = txtB.Text
        txtResultado.Text = a * b
    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim b As Double
        Dim a As Double
        a = txtA.Text
        b = txtB.Text
        txtResultado.Text = a + b

    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim b As Double
        Dim a As Double
        a = txtA.Text
        b = txtB.Text
        txtResultado.Text = a - b
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim b As Double
        Dim a As Double
        a = txtA.Text
        b = txtB.Text
        txtResultado.Text = a / b
    End Sub

    Private Sub btnResiduo_Click(sender As Object, e As EventArgs) Handles btnResiduo.Click
        Dim b As Double
        Dim a As Double
        a = txtA.Text
        b = txtB.Text
        txtResultado.Text = a Mod b
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        Dim b As Double
        Dim a As Double
        a = txtA.Text
        b = txtB.Text
        txtResultado.Text = a ^ b
    End Sub

    Private Sub btnDivisionEntera_Click(sender As Object, e As EventArgs) Handles btnDivisionEntera.Click
        Dim b As Double
        Dim a As Double
        a = txtA.Text
        b = txtB.Text
        txtResultado.Text = a \ b
    End Sub
End Class
