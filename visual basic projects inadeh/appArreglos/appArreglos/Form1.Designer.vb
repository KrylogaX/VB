<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lbxNumeros = New System.Windows.Forms.ListBox()
        Me.btnSumatoria = New System.Windows.Forms.Button()
        Me.btnPromedio = New System.Windows.Forms.Button()
        Me.btnPares = New System.Windows.Forms.Button()
        Me.btnImpares = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(12, 12)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(100, 29)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(118, 12)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(100, 29)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lbxNumeros
        '
        Me.lbxNumeros.FormattingEnabled = True
        Me.lbxNumeros.Location = New System.Drawing.Point(12, 56)
        Me.lbxNumeros.Name = "lbxNumeros"
        Me.lbxNumeros.Size = New System.Drawing.Size(206, 134)
        Me.lbxNumeros.TabIndex = 2
        '
        'btnSumatoria
        '
        Me.btnSumatoria.Location = New System.Drawing.Point(12, 198)
        Me.btnSumatoria.Name = "btnSumatoria"
        Me.btnSumatoria.Size = New System.Drawing.Size(100, 29)
        Me.btnSumatoria.TabIndex = 3
        Me.btnSumatoria.Text = "Sumatoria"
        Me.btnSumatoria.UseVisualStyleBackColor = True
        '
        'btnPromedio
        '
        Me.btnPromedio.Location = New System.Drawing.Point(123, 199)
        Me.btnPromedio.Name = "btnPromedio"
        Me.btnPromedio.Size = New System.Drawing.Size(95, 28)
        Me.btnPromedio.TabIndex = 4
        Me.btnPromedio.Text = "Promedio"
        Me.btnPromedio.UseVisualStyleBackColor = True
        '
        'btnPares
        '
        Me.btnPares.Location = New System.Drawing.Point(224, 56)
        Me.btnPares.Name = "btnPares"
        Me.btnPares.Size = New System.Drawing.Size(77, 30)
        Me.btnPares.TabIndex = 5
        Me.btnPares.Text = "Pares"
        Me.btnPares.UseVisualStyleBackColor = True
        '
        'btnImpares
        '
        Me.btnImpares.Location = New System.Drawing.Point(224, 92)
        Me.btnImpares.Name = "btnImpares"
        Me.btnImpares.Size = New System.Drawing.Size(77, 30)
        Me.btnImpares.TabIndex = 6
        Me.btnImpares.Text = "Impares"
        Me.btnImpares.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 339)
        Me.Controls.Add(Me.btnImpares)
        Me.Controls.Add(Me.btnPares)
        Me.Controls.Add(Me.btnPromedio)
        Me.Controls.Add(Me.btnSumatoria)
        Me.Controls.Add(Me.lbxNumeros)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnCargar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCargar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents lbxNumeros As ListBox
    Friend WithEvents btnSumatoria As Button
    Friend WithEvents btnPromedio As Button
    Friend WithEvents btnPares As Button
    Friend WithEvents btnImpares As Button
End Class
