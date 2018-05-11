<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAreas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTriangulo = New System.Windows.Forms.Button()
        Me.btnCuadrado = New System.Windows.Forms.Button()
        Me.btnRectangulo = New System.Windows.Forms.Button()
        Me.btnCirculo = New System.Windows.Forms.Button()
        Me.btnPentagono = New System.Windows.Forms.Button()
        Me.btnFormula = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTriangulo
        '
        Me.btnTriangulo.Location = New System.Drawing.Point(12, 12)
        Me.btnTriangulo.Name = "btnTriangulo"
        Me.btnTriangulo.Size = New System.Drawing.Size(77, 73)
        Me.btnTriangulo.TabIndex = 0
        Me.btnTriangulo.Text = "Triangulo"
        Me.btnTriangulo.UseVisualStyleBackColor = True
        '
        'btnCuadrado
        '
        Me.btnCuadrado.Location = New System.Drawing.Point(95, 12)
        Me.btnCuadrado.Name = "btnCuadrado"
        Me.btnCuadrado.Size = New System.Drawing.Size(77, 73)
        Me.btnCuadrado.TabIndex = 1
        Me.btnCuadrado.Text = "Cuadrado"
        Me.btnCuadrado.UseVisualStyleBackColor = True
        '
        'btnRectangulo
        '
        Me.btnRectangulo.Location = New System.Drawing.Point(12, 91)
        Me.btnRectangulo.Name = "btnRectangulo"
        Me.btnRectangulo.Size = New System.Drawing.Size(77, 73)
        Me.btnRectangulo.TabIndex = 2
        Me.btnRectangulo.Text = "Rectangulo"
        Me.btnRectangulo.UseVisualStyleBackColor = True
        '
        'btnCirculo
        '
        Me.btnCirculo.Location = New System.Drawing.Point(95, 91)
        Me.btnCirculo.Name = "btnCirculo"
        Me.btnCirculo.Size = New System.Drawing.Size(77, 73)
        Me.btnCirculo.TabIndex = 3
        Me.btnCirculo.Text = "Circulo"
        Me.btnCirculo.UseVisualStyleBackColor = True
        '
        'btnPentagono
        '
        Me.btnPentagono.Location = New System.Drawing.Point(12, 172)
        Me.btnPentagono.Name = "btnPentagono"
        Me.btnPentagono.Size = New System.Drawing.Size(77, 73)
        Me.btnPentagono.TabIndex = 4
        Me.btnPentagono.Text = "Pentagono"
        Me.btnPentagono.UseVisualStyleBackColor = True
        '
        'btnFormula
        '
        Me.btnFormula.Location = New System.Drawing.Point(95, 170)
        Me.btnFormula.Name = "btnFormula"
        Me.btnFormula.Size = New System.Drawing.Size(77, 73)
        Me.btnFormula.TabIndex = 5
        Me.btnFormula.Text = "Formula General (no es un area pero yo que se)"
        Me.btnFormula.UseVisualStyleBackColor = True
        '
        'formAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 264)
        Me.Controls.Add(Me.btnFormula)
        Me.Controls.Add(Me.btnPentagono)
        Me.Controls.Add(Me.btnCirculo)
        Me.Controls.Add(Me.btnRectangulo)
        Me.Controls.Add(Me.btnCuadrado)
        Me.Controls.Add(Me.btnTriangulo)
        Me.Name = "formAreas"
        Me.Text = "Calcular el Area"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTriangulo As Button
    Friend WithEvents btnCuadrado As Button
    Friend WithEvents btnRectangulo As Button
    Friend WithEvents btnCirculo As Button
    Friend WithEvents btnPentagono As Button
    Friend WithEvents btnFormula As Button
End Class
