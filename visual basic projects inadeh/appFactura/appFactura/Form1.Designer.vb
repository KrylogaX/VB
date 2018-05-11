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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbCodigo = New System.Windows.Forms.TextBox()
        Me.txbDescripcion = New System.Windows.Forms.TextBox()
        Me.txbCantidad = New System.Windows.Forms.TextBox()
        Me.txbPrecioUnit = New System.Windows.Forms.TextBox()
        Me.btnSubtotal = New System.Windows.Forms.Button()
        Me.btnImpuesto = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txbSubtotal = New System.Windows.Forms.TextBox()
        Me.txbImpuesto = New System.Windows.Forms.TextBox()
        Me.txbTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Unitario"
        '
        'txbCodigo
        '
        Me.txbCodigo.Location = New System.Drawing.Point(137, 38)
        Me.txbCodigo.Name = "txbCodigo"
        Me.txbCodigo.Size = New System.Drawing.Size(110, 22)
        Me.txbCodigo.TabIndex = 4
        '
        'txbDescripcion
        '
        Me.txbDescripcion.Location = New System.Drawing.Point(137, 73)
        Me.txbDescripcion.Name = "txbDescripcion"
        Me.txbDescripcion.Size = New System.Drawing.Size(110, 22)
        Me.txbDescripcion.TabIndex = 5
        '
        'txbCantidad
        '
        Me.txbCantidad.Location = New System.Drawing.Point(137, 108)
        Me.txbCantidad.Name = "txbCantidad"
        Me.txbCantidad.Size = New System.Drawing.Size(110, 22)
        Me.txbCantidad.TabIndex = 6
        '
        'txbPrecioUnit
        '
        Me.txbPrecioUnit.Location = New System.Drawing.Point(137, 150)
        Me.txbPrecioUnit.Name = "txbPrecioUnit"
        Me.txbPrecioUnit.Size = New System.Drawing.Size(110, 22)
        Me.txbPrecioUnit.TabIndex = 7
        '
        'btnSubtotal
        '
        Me.btnSubtotal.Location = New System.Drawing.Point(15, 237)
        Me.btnSubtotal.Name = "btnSubtotal"
        Me.btnSubtotal.Size = New System.Drawing.Size(106, 36)
        Me.btnSubtotal.TabIndex = 8
        Me.btnSubtotal.Text = "Subtotal"
        Me.btnSubtotal.UseVisualStyleBackColor = True
        '
        'btnImpuesto
        '
        Me.btnImpuesto.Location = New System.Drawing.Point(127, 237)
        Me.btnImpuesto.Name = "btnImpuesto"
        Me.btnImpuesto.Size = New System.Drawing.Size(106, 36)
        Me.btnImpuesto.TabIndex = 9
        Me.btnImpuesto.Text = "Impuesto"
        Me.btnImpuesto.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(239, 237)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(106, 36)
        Me.btnTotal.TabIndex = 10
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Impuesto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(79, 434)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(168, 49)
        Me.btnCalcular.TabIndex = 14
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txbSubtotal
        '
        Me.txbSubtotal.Location = New System.Drawing.Point(127, 309)
        Me.txbSubtotal.Name = "txbSubtotal"
        Me.txbSubtotal.Size = New System.Drawing.Size(114, 22)
        Me.txbSubtotal.TabIndex = 15
        '
        'txbImpuesto
        '
        Me.txbImpuesto.Location = New System.Drawing.Point(127, 352)
        Me.txbImpuesto.Name = "txbImpuesto"
        Me.txbImpuesto.Size = New System.Drawing.Size(114, 22)
        Me.txbImpuesto.TabIndex = 16
        '
        'txbTotal
        '
        Me.txbTotal.Location = New System.Drawing.Point(127, 393)
        Me.txbTotal.Name = "txbTotal"
        Me.txbTotal.Size = New System.Drawing.Size(114, 22)
        Me.txbTotal.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 504)
        Me.Controls.Add(Me.txbTotal)
        Me.Controls.Add(Me.txbImpuesto)
        Me.Controls.Add(Me.txbSubtotal)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnImpuesto)
        Me.Controls.Add(Me.btnSubtotal)
        Me.Controls.Add(Me.txbPrecioUnit)
        Me.Controls.Add(Me.txbCantidad)
        Me.Controls.Add(Me.txbDescripcion)
        Me.Controls.Add(Me.txbCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbCodigo As TextBox
    Friend WithEvents txbDescripcion As TextBox
    Friend WithEvents txbCantidad As TextBox
    Friend WithEvents txbPrecioUnit As TextBox
    Friend WithEvents btnSubtotal As Button
    Friend WithEvents btnImpuesto As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txbSubtotal As TextBox
    Friend WithEvents txbImpuesto As TextBox
    Friend WithEvents txbTotal As TextBox
End Class
