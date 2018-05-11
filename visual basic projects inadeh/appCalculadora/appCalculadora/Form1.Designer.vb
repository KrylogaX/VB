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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnResiduo = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnDivisionEntera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.AcceptsReturn = True
        Me.txtA.Location = New System.Drawing.Point(18, 32)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(89, 20)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(122, 32)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(89, 20)
        Me.txtB.TabIndex = 1
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(18, 58)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(193, 20)
        Me.txtResultado.TabIndex = 2
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(12, 98)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(89, 32)
        Me.btnSuma.TabIndex = 3
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(122, 98)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(89, 32)
        Me.btnResta.TabIndex = 4
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Location = New System.Drawing.Point(12, 138)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(89, 32)
        Me.btnMultiplicacion.TabIndex = 5
        Me.btnMultiplicacion.Text = "*"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(122, 138)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(89, 32)
        Me.btnDivision.TabIndex = 6
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnResiduo
        '
        Me.btnResiduo.Location = New System.Drawing.Point(12, 179)
        Me.btnResiduo.Name = "btnResiduo"
        Me.btnResiduo.Size = New System.Drawing.Size(89, 32)
        Me.btnResiduo.TabIndex = 7
        Me.btnResiduo.Text = "Residuo"
        Me.btnResiduo.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Location = New System.Drawing.Point(122, 179)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(89, 32)
        Me.btnPotencia.TabIndex = 8
        Me.btnPotencia.Text = "Potencia"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnDivisionEntera
        '
        Me.btnDivisionEntera.Location = New System.Drawing.Point(12, 217)
        Me.btnDivisionEntera.Name = "btnDivisionEntera"
        Me.btnDivisionEntera.Size = New System.Drawing.Size(89, 32)
        Me.btnDivisionEntera.TabIndex = 9
        Me.btnDivisionEntera.Text = "Division Entera"
        Me.btnDivisionEntera.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDivisionEntera)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnResiduo)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnResiduo As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnDivisionEntera As Button
End Class
