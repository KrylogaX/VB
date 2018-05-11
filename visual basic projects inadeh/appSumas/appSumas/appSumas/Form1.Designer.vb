<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOperaciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.btnSaludarAmigo = New System.Windows.Forms.Button()
        Me.btnSaludo2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(12, 12)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(106, 46)
        Me.btnSuma.TabIndex = 0
        Me.btnSuma.Text = "Sumar Numeros"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Location = New System.Drawing.Point(12, 116)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(106, 53)
        Me.btnMultiplicacion.TabIndex = 1
        Me.btnMultiplicacion.Text = "Multiplicar Numeros"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(12, 64)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(106, 45)
        Me.btnResta.TabIndex = 2
        Me.btnResta.Text = "Restar Numeros"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(12, 175)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(106, 45)
        Me.btnDivision.TabIndex = 3
        Me.btnDivision.Text = "Dividir Numeros"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnSalida
        '
        Me.btnSalida.Location = New System.Drawing.Point(124, 13)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(106, 45)
        Me.btnSalida.TabIndex = 4
        Me.btnSalida.Text = "Saludo"
        Me.btnSalida.UseVisualStyleBackColor = True
        '
        'btnSaludarAmigo
        '
        Me.btnSaludarAmigo.Location = New System.Drawing.Point(124, 64)
        Me.btnSaludarAmigo.Name = "btnSaludarAmigo"
        Me.btnSaludarAmigo.Size = New System.Drawing.Size(106, 45)
        Me.btnSaludarAmigo.TabIndex = 5
        Me.btnSaludarAmigo.Text = "Saludar amigo"
        Me.btnSaludarAmigo.UseVisualStyleBackColor = True
        '
        'btnSaludo2
        '
        Me.btnSaludo2.Location = New System.Drawing.Point(124, 116)
        Me.btnSaludo2.Name = "btnSaludo2"
        Me.btnSaludo2.Size = New System.Drawing.Size(106, 53)
        Me.btnSaludo2.TabIndex = 6
        Me.btnSaludo2.Text = "Saludar amigo 2"
        Me.btnSaludo2.UseVisualStyleBackColor = True
        '
        'formOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 266)
        Me.Controls.Add(Me.btnSaludo2)
        Me.Controls.Add(Me.btnSaludarAmigo)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnSuma)
        Me.Name = "formOperaciones"
        Me.Text = "Operaciones Basicas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSuma As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnSalida As Button
    Friend WithEvents btnSaludarAmigo As Button
    Friend WithEvents btnSaludo2 As Button
End Class
