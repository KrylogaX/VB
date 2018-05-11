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
        Me.btnSemaforo = New System.Windows.Forms.Button()
        Me.btnCambiarverde = New System.Windows.Forms.Button()
        Me.btnCambiaramarillo = New System.Windows.Forms.Button()
        Me.bntCambiarrojo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSemaforo
        '
        Me.btnSemaforo.Enabled = False
        Me.btnSemaforo.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnSemaforo.Location = New System.Drawing.Point(-5, -2)
        Me.btnSemaforo.Name = "btnSemaforo"
        Me.btnSemaforo.Size = New System.Drawing.Size(789, 616)
        Me.btnSemaforo.TabIndex = 0
        Me.btnSemaforo.Text = "SOY TODO"
        Me.btnSemaforo.UseVisualStyleBackColor = True
        '
        'btnCambiarverde
        '
        Me.btnCambiarverde.Location = New System.Drawing.Point(28, 150)
        Me.btnCambiarverde.Name = "btnCambiarverde"
        Me.btnCambiarverde.Size = New System.Drawing.Size(57, 54)
        Me.btnCambiarverde.TabIndex = 1
        Me.btnCambiarverde.Text = "Cambiar a Verde"
        Me.btnCambiarverde.UseVisualStyleBackColor = True
        '
        'btnCambiaramarillo
        '
        Me.btnCambiaramarillo.Location = New System.Drawing.Point(110, 150)
        Me.btnCambiaramarillo.Name = "btnCambiaramarillo"
        Me.btnCambiaramarillo.Size = New System.Drawing.Size(57, 54)
        Me.btnCambiaramarillo.TabIndex = 2
        Me.btnCambiaramarillo.Text = "Cambiar a Amarillo"
        Me.btnCambiaramarillo.UseVisualStyleBackColor = True
        '
        'bntCambiarrojo
        '
        Me.bntCambiarrojo.Location = New System.Drawing.Point(198, 150)
        Me.bntCambiarrojo.Name = "bntCambiarrojo"
        Me.bntCambiarrojo.Size = New System.Drawing.Size(57, 54)
        Me.bntCambiarrojo.TabIndex = 3
        Me.bntCambiarrojo.Text = "Cambiar a Rojo"
        Me.bntCambiarrojo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bntCambiarrojo)
        Me.Controls.Add(Me.btnCambiaramarillo)
        Me.Controls.Add(Me.btnCambiarverde)
        Me.Controls.Add(Me.btnSemaforo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSemaforo As Button
    Friend WithEvents btnCambiarverde As Button
    Friend WithEvents btnCambiaramarillo As Button
    Friend WithEvents bntCambiarrojo As Button
End Class
