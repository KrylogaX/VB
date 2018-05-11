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
        Me.txbNota1 = New System.Windows.Forms.TextBox()
        Me.txbSexo = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.txbCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbNota2 = New System.Windows.Forms.TextBox()
        Me.txbNota3 = New System.Windows.Forms.TextBox()
        Me.txbProm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbNota1
        '
        Me.txbNota1.Location = New System.Drawing.Point(149, 171)
        Me.txbNota1.Name = "txbNota1"
        Me.txbNota1.Size = New System.Drawing.Size(110, 22)
        Me.txbNota1.TabIndex = 15
        '
        'txbSexo
        '
        Me.txbSexo.Location = New System.Drawing.Point(149, 129)
        Me.txbSexo.Name = "txbSexo"
        Me.txbSexo.Size = New System.Drawing.Size(110, 22)
        Me.txbSexo.TabIndex = 14
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(149, 94)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(110, 22)
        Me.txbNombre.TabIndex = 13
        '
        'txbCedula
        '
        Me.txbCedula.Location = New System.Drawing.Point(149, 59)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(110, 22)
        Me.txbCedula.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nota 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Sexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cedula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nota 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nota 3"
        '
        'txbNota2
        '
        Me.txbNota2.Location = New System.Drawing.Point(149, 203)
        Me.txbNota2.Name = "txbNota2"
        Me.txbNota2.Size = New System.Drawing.Size(110, 22)
        Me.txbNota2.TabIndex = 18
        '
        'txbNota3
        '
        Me.txbNota3.Location = New System.Drawing.Point(149, 231)
        Me.txbNota3.Name = "txbNota3"
        Me.txbNota3.Size = New System.Drawing.Size(110, 22)
        Me.txbNota3.TabIndex = 19
        '
        'txbProm
        '
        Me.txbProm.Location = New System.Drawing.Point(149, 285)
        Me.txbProm.Name = "txbProm"
        Me.txbProm.Size = New System.Drawing.Size(110, 22)
        Me.txbProm.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Promedio"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(131, 324)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(140, 41)
        Me.btnCalcular.TabIndex = 22
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 389)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txbProm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbNota3)
        Me.Controls.Add(Me.txbNota2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbNota1)
        Me.Controls.Add(Me.txbSexo)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.txbCedula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbNota1 As TextBox
    Friend WithEvents txbSexo As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txbCedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbNota2 As TextBox
    Friend WithEvents txbNota3 As TextBox
    Friend WithEvents txbProm As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCalcular As Button
End Class
