Public Class Form1
    Dim palabra1(6), palabra2(6), palabra3(6), palabra4(6), palabra5(6), palabra6(6), palabra7(6), palabra8(6), palabra9(6), palabra10(6), palabraActual(6) As Char
    Dim intentos, numeroPalabra As Integer
    Dim ganar, iniciar As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTrampa.Click
        If lblTrampa.Visible = True Then
            lblTrampa.Visible = False
        ElseIf lblTrampa.Visible = False Then
            lblTrampa.Visible = True
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        'Este evento click las 10 palabras, genera un numero al azar que es el numero de la palaba
        'y le asigna la palabra presente a una variable que se llama "palabraActual"
        'ademas de eso, hace que la picture box sea visible, y que el textbox este disponible
        btnReiniciar.Text = "Reiniciar"
        'tbxVerificar.ReadOnly = False
        tbxVerificar.Enabled = True
        PictureBox1.Visible = True
        ganar = False
        iniciar = True
        PictureBox1.Image = My.Resources.Intento7
        intentos = 7
        palabra1 = "c" & "a" & "n" & "i" & "n" & "o"
        palabra2 = "b" & "o" & "c" & "i" & "n" & "a"
        palabra3 = "m" & "a" & "n" & "i" & "t" & "o"
        palabra4 = "m" & "a" & "r" & "t" & "e" & "s"
        palabra5 = "z" & "a" & "p" & "a" & "t" & "o"
        palabra6 = "k" & "o" & "n" & "a" & "m" & "i"
        palabra7 = "o" & "c" & "e" & "a" & "n" & "o"
        palabra8 = "s" & "a" & "l" & "i" & "d" & "a"
        palabra9 = "a" & "m" & "i" & "g" & "o" & "s"
        palabra10 = "b" & "o" & "n" & "d" & "a" & "d"
        lblIntentos.Text = "Intentos" & vbNewLine & "Restantes: " & intentos
        lbl1.Text = "_"
        lbl2.Text = "_"
        lbl3.Text = "_"
        lbl4.Text = "_"
        lbl5.Text = "_"
        lbl6.Text = "_"
        Randomize()
        numeroPalabra = (9 * Rnd() + 1)

        If numeroPalabra = 1 Then
            palabraActual = palabra1
        End If
        If numeroPalabra = 2 Then
            palabraActual = palabra2
        End If
        If numeroPalabra = 3 Then
            palabraActual = palabra3
        End If
        If numeroPalabra = 4 Then
            palabraActual = palabra4
        End If
        If numeroPalabra = 5 Then
            palabraActual = palabra5
        End If
        If numeroPalabra = 6 Then
            palabraActual = palabra6
        End If
        If numeroPalabra = 7 Then
            palabraActual = palabra7
        End If
        If numeroPalabra = 8 Then
            palabraActual = palabra8
        End If
        If numeroPalabra = 9 Then
            palabraActual = palabra9
        End If
        If numeroPalabra = 10 Then
            palabraActual = palabra10
        End If
        lblTrampa.Text = palabraActual

    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim i As Integer
        'se declara el contador y se actualiza el label con el numero de intentos
        lblIntentos.Text = "Intentos" & vbNewLine & "Restantes: " & intentos
        'evaluacion letra por letra del textbox con la palabra actual
        'si una de las letras de la palabra actual coincide con la del textbox
        'el o los labels de la letra correspondiente se "revelan" por asi decirlo
        'en realidad el texto del label toma el valor de la letra en el textbox
        For i = 0 To 5

            If tbxVerificar.Text = palabraActual(i) Then
                If i = 0 Then
                    lbl1.Text = tbxVerificar.Text
                End If
                If i = 1 Then
                    lbl2.Text = tbxVerificar.Text
                End If
                If i = 2 Then
                    lbl3.Text = tbxVerificar.Text
                End If
                If i = 3 Then
                    lbl4.Text = tbxVerificar.Text
                End If
                If i = 4 Then
                    lbl5.Text = tbxVerificar.Text
                End If
                If i = 5 Then
                    lbl6.Text = tbxVerificar.Text
                End If
            End If
        Next
        'se resta un intento
        If iniciar = True Then
            'intentos -= 1

            'se actualizan visualmente los intentos restantes
            lblIntentos.Text = "Intentos" & vbNewLine & "Restantes: " & intentos
        Else
            intentos = 7
        End If
        'PictureBox1.Image = My.Resources.




        If intentos >= 0 Then
            'se verifica si ya se han descubierto todas las letras de la palabra y se desactiva el texbox si asi sucede
            If (lbl1.Text = palabraActual(0)) And (lbl2.Text = palabraActual(1)) And (lbl3.Text = palabraActual(2)) And (lbl4.Text = palabraActual(3)) And (lbl5.Text = palabraActual(4)) And (lbl6.Text = palabraActual(5)) Then
                lblIntentos.Text = "Intentos" & vbNewLine & "Restantes: " & intentos
                'tbxVerificar.ReadOnly = True
                tbxVerificar.Enabled = False
                MsgBox("Ganaste")
                ganar = True
            End If
        End If

        If ganar = False Then

            If intentos = 6 Then
                PictureBox1.Image = My.Resources.Intento6
            End If
            If intentos = 5 Then
                PictureBox1.Image = My.Resources.Intento5
            End If
            If intentos = 4 Then
                PictureBox1.Image = My.Resources.Intento4
            End If
            If intentos = 3 Then
                PictureBox1.Image = My.Resources.Intento3
            End If
            If intentos = 2 Then
                PictureBox1.Image = My.Resources.Intento2
            End If
            If intentos = 1 Then
                PictureBox1.Image = My.Resources.Intento1
            End If

        End If
        'si los intentos son 0 y aun no se han descubierto todas las letras (vease variable ganar) se notifica la derrota y se revelan las letras de todas formas
        If intentos = 0 And ganar = False Then
            MsgBox("Perdiste")
            tbxVerificar.Enabled = False
            For i = 0 To 5

                If i = 0 Then
                    lbl1.Text = palabraActual(i)
                End If
                If i = 1 Then
                    lbl2.Text = palabraActual(i)
                End If
                If i = 2 Then
                    lbl3.Text = palabraActual(i)
                End If
                If i = 3 Then
                    lbl4.Text = palabraActual(i)
                End If
                If i = 4 Then
                    lbl5.Text = palabraActual(i)
                End If
                If i = 5 Then
                    lbl6.Text = palabraActual(i)
                End If

            Next
            If (tbxVerificar.Text = lbl1.Text) Or (tbxVerificar.Text = lbl2.Text) Or (tbxVerificar.Text = lbl3.Text) Or (tbxVerificar.Text = lbl4.Text) Or (tbxVerificar.Text = lbl5.Text) Or (tbxVerificar.Text = lbl6.Text) Then
                intentos = intentos + 1
                lblIntentos.Text = "Intentos" & vbNewLine & "Restantes: " & intentos
            Else
                intentos = intentos - 1
                lblIntentos.Text = "Intentos" & vbNewLine & "Restantes: " & intentos
            End If

        End If
        'se limpia el texbox cada vez que se verifica una letra 
        tbxVerificar.Clear()
        If iniciar = False Then
            lblIntentos.Text = "Intentos" & vbNewLine & "Restantes: "
        End If
    End Sub
End Class
